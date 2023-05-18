using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            DateTime obracunskiPeriod = datumOstvarivanjaPrihodaDateTimePicker.Value;
            decimal brutoPrihod = decimal.Parse(brutoPrihodTextBox.Text);
            string valuta = valutaComboBox.Text;
            decimal porezPlacen = decimal.Parse(porezPlacenTextBox.Text);

            // Input validation passed, perform further actions
            string xml = Core.GenerateXml(
                obracunskiPeriodGodina: obracunskiPeriod.Year.ToString(),
                obracunskiPeriodMesec: obracunskiPeriod.Month.ToString(),
                obracunskiPeriodDan: obracunskiPeriod.Day.ToString(),
                brutoPrihod: Math.Round(brutoPrihod, 2),
                porezPlacenDrugojDrzavi: porezPlacen,
                valuta: valuta);

            // Create a new XML file with the filled-in template
            string newFilePath = String.Format(@"{0}\{1}-pp-opo.xml", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), obracunskiPeriod);
            File.WriteAllText(newFilePath, xml);

            Console.WriteLine($"New file created at {newFilePath}");

            // Close the GUI window
            this.Close();
        }

        private string ValidateInput()
        {
            // Perform your validation logic here
            // Return an error message if validation fails, or an empty string if validation passes
            if (string.IsNullOrWhiteSpace(brutoPrihodTextBox.Text))
            {
                return "Bruto prihod must be entered.";
            }

            if (string.IsNullOrWhiteSpace(porezPlacenTextBox.Text))
            {
                return "Porez placen drugoj drzavi must be entered.";
            }

            if (decimal.Parse(brutoPrihodTextBox.Text) <= 0)
            {
                return "Bruto prihod must be greater than 0.";
            }

            if (decimal.Parse(porezPlacenTextBox.Text) < 0)
            {
                return "Porez placen drugoj drzavi must be a positive value.";
            }

            // Validation passed
            return string.Empty;
        }
    }
}
