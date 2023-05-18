using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DividendeXmlGeneratorForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateInput();
            if (!string.IsNullOrEmpty(errorMessage))
            {
                // Display error message
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the user input
            string imePrezimeObveznika = imePrezimeTextBox.Text;
            string ulicaBroj = ulicaBrojTextBox.Text;
            string jmbgPodnosioca = jmbgTextBox.Text;
            string telefonKontaktOsobe = telefonTextBox.Text;
            string email = emailTextBox.Text;
            string opstinaPrebivalista = prebivalisteComboBox.Text;
            string kodOpstinePrebivalista = opstinaPrebivalista.Split(" - ")[1];
            DateTime datumOstvarivanjaPrihoda = datumOstvarivanjaPrihodaDateTimePicker.Value;
            string valuta = valutaComboBox.Text;
            decimal brutoPrihod = decimal.Parse(brutoPrihodTextBox.Text);
            decimal porezPlacenDrugojDrzavi = decimal.Parse(porezPlacenTextBox.Text);



            // Input validation passed, perform further actions
            string xml = Core.GenerateXml(
                obracunskiPeriodGodina: datumOstvarivanjaPrihoda.Year.ToString(),
                obracunskiPeriodMesec: datumOstvarivanjaPrihoda.Month.ToString(),
                obracunskiPeriodDan: datumOstvarivanjaPrihoda.Day.ToString(),
                brutoPrihod: Math.Round(brutoPrihod, 2),
                porezPlacenDrugojDrzavi: porezPlacenDrugojDrzavi,
                valuta: valuta);

            // Create a new XML file with the filled-in template
            string newFilePath = String.Format(@"{0}\{1}-pp-opo.xml", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), datumOstvarivanjaPrihoda);
            File.WriteAllText(newFilePath, xml);

            Console.WriteLine($"New file created at {newFilePath}");

            // Close the GUI window
            this.Close();
        }

        private string ValidateInput()
        {
            // Perform your validation logic here
            // Return an error message if validation fails, or an empty string if validation passes
            if (string.IsNullOrWhiteSpace(imePrezimeTextBox.Text))
            {
                return $"{imePrezimeLabel.Text} must be entered.";
            }

            if (string.IsNullOrWhiteSpace(ulicaBrojTextBox.Text))
            {
                return $"{ulicaBrojLabel.Text} must be entered.";
            }

            if (string.IsNullOrWhiteSpace(jmbgTextBox.Text))
            {
                return $"{jmbgLabel.Text} must be entered.";
            }

            if (jmbgTextBox.Text.Length != 13)
            {
                return $"{jmbgLabel.Text} mora imati 13 cifara.";
            }

            if (ContainsNonNumericCharacters(jmbgTextBox.Text))
            {
                return $"{jmbgLabel.Text} mora imati samo cifre.";
            }

            if (string.IsNullOrWhiteSpace(telefonTextBox.Text))
            {
                return $"{telefonLabel.Text} must be entered.";
            }

            if (ContainsNonNumericCharacters(telefonTextBox.Text))
            {
                return $"{telefonLabel.Text} mora imati samo cifre.";
            }

            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                return $"{emailLabel.Text} must be entered.";
            }

            if (string.IsNullOrWhiteSpace(prebivalisteComboBox.Text))
            {
                return $"{prebivalisteLabel.Text} must be selected.";
            }

            if (datumOstvarivanjaPrihodaDateTimePicker.Value > DateTime.Now)
            {
                return $"{datumOstvarivanjaPrihodaLabel.Text} ne sme biti u buducnosti.";
            }

            if (valutaComboBox.Text.Length <= 0)
            {
                return $"{valutaLabel.Text} must be selected.";
            }

            if (string.IsNullOrWhiteSpace(brutoPrihodTextBox.Text))
            {
                return $"{brutoPrihodLabel.Text} must be entered.";
            }

            if (string.IsNullOrWhiteSpace(porezPlacenTextBox.Text))
            {
                return $"{porezPlacenLabel.Text} must be entered.";
            }

            if (decimal.Parse(porezPlacenTextBox.Text) < 0)
            {
                return "Porez placen drugoj drzavi must be a non-negative value.";
            }

            // Validation passed
            return string.Empty;
        }

        private static bool ContainsNonNumericCharacters(string input)
        {
            Regex regex = new Regex(@"\D"); // Matches any non-digit character
            return regex.IsMatch(input);
        }
    }
}
