using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DividendeXmlGeneratorForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();

            // Set the CustomFormat string.
            this.datumOstvarivanjaPrihodaDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.datumOstvarivanjaPrihodaDateTimePicker.CustomFormat = "dd.MM.yyyy.";

            // TODO: Rehydrate user input
            this.RehydrateUserInputFromFile();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //TODO: save user input
            this.SaveUserInputToFile();
            string errorMessage = this.ValidateInput();
            if (!string.IsNullOrEmpty(errorMessage))
            {
                // Display error message
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the user input
            string imePrezimeObveznika = imePrezimeObveznikaTextBox.Text;
            string ulicaBrojPoreskogObveznika = ulicaBrojPoreskogObveznikaTextBox.Text;
            string poreskiIdentifikacioniBrojObveznika = poreskiIdentifikacioniBrojObveznikaTextBox.Text;
            string jmbgPodnosioca = jmbgPodnosiocaTextBox.Text;
            string telefonKontaktOsobe = telefonKontaktOsobeTextBox.Text;
            string email = emailTextBox.Text;
            string opstinaPrebivalista = opstinaPrebivalistaComboBox.Text;
            string kodOpstinePrebivalista = opstinaPrebivalista.Split(" - ")[1];
            string valuta = valutaComboBox.Text;

            DateTime datumOstvarivanjaPrihoda = datumOstvarivanjaPrihodaDateTimePicker.Value;
            decimal brutoPrihod = decimal.Parse(brutoPrihodTextBox.Text);
            decimal porezPlacenDrugojDrzavi = decimal.Parse(porezPlacenTextBox.Text);

            Core.GeneratePpOpoXmlFile(
                imePrezimeObveznika: imePrezimeObveznika,
                ulicaBrojPoreskogObveznika: ulicaBrojPoreskogObveznika,
                jmbgPodnosioca: jmbgPodnosioca,
                poreskiIdentifikacioniBrojObveznika: poreskiIdentifikacioniBrojObveznika,
                telefonKontaktOsobe: telefonKontaktOsobe,
                email: email,
                kodOpstinePrebivalista: kodOpstinePrebivalista,
                valuta: valuta,
                datumOstvarivanjaPrihodaDateTime: datumOstvarivanjaPrihoda,
                brutoPrihod: brutoPrihod,
                porezPlacenDrugojDrzavi: porezPlacenDrugojDrzavi,
                newFolderName: "PP-OPO");

            // Close the GUI window
            this.Close();
        }

        private void SaveUserInputToFile()
        {
            var userInput = new UserInput
            {
                ImePrezime = this.imePrezimeObveznikaTextBox.Text,
                UlicaBroj = this.ulicaBrojPoreskogObveznikaTextBox.Text,
                PoreskiIdentifikacioniBrojObveznika = this.poreskiIdentifikacioniBrojObveznikaTextBox.Text,
                Jmbg = this.jmbgPodnosiocaTextBox.Text,
                TelefonKontaktOsobe = this.telefonKontaktOsobeTextBox.Text,
                Email = this.emailTextBox.Text,
                OpstinaPrebivalista = this.opstinaPrebivalistaComboBox.Text,
                DatumOstvarivanjaPrihoda = this.datumOstvarivanjaPrihodaDateTimePicker.Value,
                Valuta = this.valutaComboBox.Text,
                BrutoPrihod = this.brutoPrihodTextBox.Text,
                PorezPlacenDrugojDrzavi = this.porezPlacenTextBox.Text,
            };

            try
            {
                string? directory = Path.GetDirectoryName(path: System.Reflection.Assembly.GetEntryAssembly()?.Location);
                if (directory == null) throw new Exception();
                string filePath = Path.Combine(directory, "userInput.csv");

                using (var writer = new StreamWriter(filePath))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture) { HasHeaderRecord = true }))
                {
                    csv.WriteRecords(new List<UserInput> { userInput });
                }

                Console.WriteLine("Class saved successfully.");
            }
            catch
            {
                // Saving in the directory of the executable failed, fallback to the Documents directory
                string documentsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filePath = Path.Combine(documentsDirectory, "userInput.csv");

                using (var writer = new StreamWriter(filePath))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture) { HasHeaderRecord = true }))
                {
                    csv.WriteRecords(new List<UserInput> { userInput });
                }

                Console.WriteLine("Class saved to Documents directory.");
            }
        }

        private void RehydrateUserInputFromFile()
        {
            IEnumerable<UserInput>? records = null;
            try
            {
                string? directory = Path.GetDirectoryName(path: System.Reflection.Assembly.GetEntryAssembly()?.Location);
                if (directory == null) throw new Exception();
                string filePath = Path.Combine(directory, "userInput.csv");

                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    records = csv.GetRecords<UserInput>().ToList();
                }
            }
            catch { }

            if (records != null && records.Any())
            {
                try
                {

                    // File not found in the directory of the executable, try the Documents directory
                    string documentsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string filePath = Path.Combine(documentsDirectory, "userInput.csv");

                    using (var reader = new StreamReader(filePath))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        records = csv.GetRecords<UserInput>().ToList();
                    }
                }
                catch { }
            }

            if (records != null && records.Any())
            {
                UserInput firstRecord = records.First();

                this.imePrezimeObveznikaTextBox.Text = firstRecord.ImePrezime;
                this.ulicaBrojPoreskogObveznikaTextBox.Text = firstRecord.UlicaBroj;
                this.poreskiIdentifikacioniBrojObveznikaTextBox.Text = firstRecord.PoreskiIdentifikacioniBrojObveznika;
                this.jmbgPodnosiocaTextBox.Text = firstRecord.Jmbg;
                this.telefonKontaktOsobeTextBox.Text = firstRecord.TelefonKontaktOsobe;
                this.emailTextBox.Text = firstRecord.Email;
                this.opstinaPrebivalistaComboBox.Text = firstRecord.OpstinaPrebivalista;
                this.datumOstvarivanjaPrihodaDateTimePicker.Value =
                    firstRecord.DatumOstvarivanjaPrihoda.HasValue
                        ? firstRecord.DatumOstvarivanjaPrihoda.Value
                        : DateTime.Now;
                this.valutaComboBox.Text = firstRecord.Valuta;
                this.brutoPrihodTextBox.Text = firstRecord.BrutoPrihod;
                this.porezPlacenTextBox.Text = firstRecord.PorezPlacenDrugojDrzavi;
            }
        }

        private string ValidateInput()
        {
            // Perform your validation logic here
            // Return an error message if validation fails, or an empty string if validation passes
            if (string.IsNullOrWhiteSpace(imePrezimeObveznikaTextBox.Text))
            {
                return $"{imePrezimeLabel.Text} must be entered.";
            }

            if (string.IsNullOrWhiteSpace(ulicaBrojPoreskogObveznikaTextBox.Text))
            {
                return $"{ulicaBrojLabel.Text} must be entered.";
            }

            if (string.IsNullOrWhiteSpace(jmbgPodnosiocaTextBox.Text))
            {
                return $"{jmbgLabel.Text} must be entered.";
            }

            if (jmbgPodnosiocaTextBox.Text.Length != 13)
            {
                return $"{jmbgLabel.Text} mora imati 13 cifara.";
            }

            if (ContainsNonNumericCharacters(jmbgPodnosiocaTextBox.Text))
            {
                return $"{jmbgLabel.Text} mora imati samo cifre.";
            }

            if (string.IsNullOrWhiteSpace(telefonKontaktOsobeTextBox.Text))
            {
                return $"{telefonLabel.Text} must be entered.";
            }

            if (ContainsNonNumericCharacters(telefonKontaktOsobeTextBox.Text))
            {
                return $"{telefonLabel.Text} mora imati samo cifre.";
            }

            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                return $"{emailLabel.Text} must be entered.";
            }

            if (string.IsNullOrWhiteSpace(opstinaPrebivalistaComboBox.Text))
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

        private void importButton_Click(object sender, EventArgs e)
        {
            //TODO: save user input
            this.SaveUserInputToFile();
            string errorMessage = this.ValidateInput();
            if (!string.IsNullOrEmpty(errorMessage))
            {
                // Display error message
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the user input
            string imePrezimeObveznika = imePrezimeObveznikaTextBox.Text;
            string ulicaBrojPoreskogObveznika = ulicaBrojPoreskogObveznikaTextBox.Text;
            string poreskiIdentifikacioniBrojObveznika = poreskiIdentifikacioniBrojObveznikaTextBox.Text;
            string jmbgPodnosioca = jmbgPodnosiocaTextBox.Text;
            string telefonKontaktOsobe = telefonKontaktOsobeTextBox.Text;
            string email = emailTextBox.Text;
            string opstinaPrebivalista = opstinaPrebivalistaComboBox.Text;
            string kodOpstinePrebivalista = opstinaPrebivalista.Split(" - ")[1];
            string valuta = valutaComboBox.Text;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files|*.csv|All Files|*.*",
                Title = "Select a File"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                // Display error message
                MessageBox.Show("File not selected", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<DividendTradeData> tradeDataList = ParseTradeDataFromCsv(openFileDialog.FileName);
            foreach (DividendTradeData tradeData in tradeDataList)
            {
                DateTime datumOstvarivanjaPrihoda = tradeData.TradeDate;
                decimal brutoPrihod = tradeData.Priliv;
                decimal porezPlacenDrugojDrzavi = 0m;

                Core.GeneratePpOpoXmlFile(
                    imePrezimeObveznika: imePrezimeObveznika,
                    ulicaBrojPoreskogObveznika: ulicaBrojPoreskogObveznika,
                    jmbgPodnosioca: jmbgPodnosioca,
                    poreskiIdentifikacioniBrojObveznika: poreskiIdentifikacioniBrojObveznika,
                    telefonKontaktOsobe: telefonKontaktOsobe,
                    email: email,
                    kodOpstinePrebivalista: kodOpstinePrebivalista,
                    valuta: valuta,
                    datumOstvarivanjaPrihodaDateTime: datumOstvarivanjaPrihoda,
                    brutoPrihod: brutoPrihod,
                    porezPlacenDrugojDrzavi: porezPlacenDrugojDrzavi,
                    newFolderName: Path.GetFileName(openFileDialog.FileName));
            }

            // Close the GUI window
            this.Close();
        }

        static List<DividendTradeData> ParseTradeDataFromCsv(string filePath)
        {
            List<DividendTradeData> tradeDataList = new List<DividendTradeData>();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.SetDelimiters(";"); // Set the delimiter used in your CSV

                // Skip the header row
                parser.ReadLine();

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    // Assuming the order of fields in the CSV matches the TradeData class
                    DividendTradeData tradeData = new DividendTradeData
                    {
                        TradeDate = DateTime.Parse(fields[0]),
                        Tran = fields[1],
                        Quantity = int.Parse(fields[2]),
                        Description = fields[3],
                        Odliv = decimal.Parse(fields[4]),
                        Priliv = decimal.Parse(fields[5]),
                        SveZajedno = decimal.Parse(fields[6])
                    };

                    tradeDataList.Add(tradeData);
                }
            }

            return tradeDataList;
        }
        class DividendTradeData
        {
            public DateTime TradeDate { get; set; }
            public string Tran { get; set; }
            public int Quantity { get; set; }
            public string Description { get; set; }
            public decimal Odliv { get; set; }
            public decimal Priliv { get; set; }
            public decimal SveZajedno { get; set; }
        }
    }
}
