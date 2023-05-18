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

        private static readonly Dictionary<string, string> opstineSifre = new Dictionary<string, string>
        {
            { "Ada", "201" },
            { "Aleksandrovac", "001" },
            { "Aleksinac", "002" },
            { "Alibunar", "202" },
            { "Apatin", "203" },
            { "Aranđelovac", "003" },
            { "Arilje", "004" },
            { "Babušnica", "006" },
            { "Bajina Bašta", "007" },
            { "Barajevo", "010" },
            { "Batočina", "008" },
            { "Bač", "204" },
            { "Bačka Palanka", "205" },
            { "Bačka Topola", "206" },
            { "Bački Petrovac", "207" },
            { "Bela Palanka", "009" },
            { "Bela Crkva", "209" },
            { "Beočin", "210" },
            { "Bečej", "208" },
            { "Blace", "023" },
            { "Bogatić", "024" },
            { "Bojnik", "025" },
            { "Boljevac", "026" },
            { "Bor", "027" },
            { "Bosilegrad", "028" },
            { "Brus", "029" },
            { "Bujanovac", "030" },
            { "Valjevo", "107" },
            { "Varvarin", "108" },
            { "Velika Plana", "109" },
            { "Veliko Gradište", "110" },
            { "Vitina", "321" },
            { "Vladimirci", "112" },
            { "Vladičin Han", "111" },
            { "Vlasotince", "113" },
            { "Voždovac", "019" },
            { "Vranje", "114" },
            { "Vračar", "020" },
            { "Vrbas", "240" },
            { "Vrnjačka Banja", "115" },
            { "Vršac", "241" },
            { "Vučitrn", "322" },
            { "Gadžin Han", "039" },
            { "Glogovac", "304" },
            { "Gnjilane", "305" },
            { "Golubac", "040" },
            { "Gora", "331" },
            { "Gornji Milanovac", "041" },
            { "Grocka", "012" },
            { "Despotovac", "036" },
            { "Dečani", "301" },
            { "Dimitrovgrad", "037" },
            { "Doljevac", "038" },
            { "Đakovica", "303" },
            { "Žabalj", "243" },
            { "Žabari", "117" },
            { "Žagubica", "118" },
            { "Žitište", "244" },
            { "Žitorađa", "119" },
            { "Zaječar", "116" },
            { "Zvezdara", "022" },
            { "Zvečan", "330" },
            { "Zemun", "021" },
            { "Zrenjanin", "242" },
            { "Zubin Potok", "324" },
            { "Ivanjica", "042" },
            { "Inđija", "212" },
            { "Irig", "213" },
            { "Istok", "306" },
            { "Jagodina", "096" },
            { "Kanjiža", "214" },
            { "Kačanik", "307" },
            { "Kikinda", "215" },
            { "Kladovo", "043" },
            { "Klina", "308" },
            { "Knić", "044" },
            { "Knjaževac", "045" },
            { "Kovačica", "216" },
            { "Kovin", "217" },
            { "Kosjerić", "048" },
            { "Kosovo Polje", "328" },
            { "Kosovska Kamenica", "309" },
            { "Kosovska Mitrovica", "310" },
            { "Koceljeva", "046" },
            { "Kragujevac", "049" },
            { "Kraljevo", "050" },
            { "Krupanj", "051" },
            { "Kruševac", "052" },
            { "Kula", "218" },
            { "Kuršumlija", "054" },
            { "Kučevo", "053" },
            { "Lazarevac", "056" },
            { "Lajkovac", "055" },
            { "Lapovo", "121" },
            { "Lebane", "057" },
            { "Leposavić", "311" },
            { "Leskovac", "058" },
            { "Lipljan", "312" },
            { "Loznica", "059" },
            { "Lučani", "060" },
            { "Ljig", "061" },
            { "Ljubovija", "062" },
            { "Majdanpek", "063" },
            { "Mali Zvornik", "065" },
            { "Mali Iđoš", "219" },
            { "Malo Crniće", "066" },
            { "Medveđa", "067" },
            { "Mediana", "128" },
            { "Merošina", "068" },
            { "Mionica", "069" },
            { "Mladenovac", "070" },
            { "Negotin", "072" },
            { "Niška Banja", "122" },
            { "Nova Varoš", "074" },
            { "Nova Crnja", "220" },
            { "Novi Beograd", "013" },
            { "Novi Bečej", "221" },
            { "Novi Kneževac", "222" },
            { "Novi Pazar", "075" },
            { "Novi Sad", "223" },
            { "Novo Brdo", "329" },
            { "Obilić", "327" },
            { "Obrenovac", "014" },
            { "Opovo", "225" },
            { "Orahovac", "313" },
            { "Osečina", "076" },
            { "Odžaci", "224" },
            { "Palilula", "015" },
            { "Palilula (Niš)", "127" },
            { "Pantelej", "125" },
            { "Pančevo", "226" },
            { "Paraćin", "077" },
            { "Petrovaradin", "247" },
            { "Petrovac na Mlavi ", "078" },
            { "Peć", "314" },
            { "Pećinci", "227" },
            { "Pirot", "079" },
            { "Plandište", "228" },
            { "Podujevo", "315" },
            { "Požarevac", "080" },
            { "Požega", "081" },
            { "Preševo", "082" },
            { "Priboj na Limu", "083" },
            { "Prizren", "317" },
            { "Prijepolje", "084" },
            { "Priština", "316" },
            { "Prokuplje", "085" },
            { "Ražanj", "088" },
            { "Rakovica", "120" },
            { "Rača", "086" },
            { "Raška", "087" },
            { "Rekovac", "089" },
            { "Ruma", "229" },
            { "Savski venac", "016" },
            { "Svilajnac", "097" },
            { "Svrljig", "098" },
            { "Senta", "231" },
            { "Sečanj", "230" },
            { "Sjenica", "091" },
            { "Smederevo", "092" },
            { "Smederevska Palanka", "093" },
            { "Sokobanja", "094" },
            { "Sombor", "232" },
            { "Sopot", "017" },
            { "Srbica", "318" },
            { "Srbobran", "233" },
            { "Sremska Mitrovica", "234" },
            { "Sremski Karlovci", "250" },
            { "Stara Pazova", "235" },
            { "Stari grad", "018" },
            { "Stragari", "123" },
            { "Subotica", "236" },
            { "Suva Reka", "319" },
            { "Surdulica", "095" },
            { "Surčin", "124" },
            { "Temerin", "238" },
            { "Titel", "239" },
            { "Topola", "101" },
            { "Trgovište", "102" },
            { "Trstenik", "103" },
            { "Tutin", "104" },
            { "Ćićevac", "032" },
            { "Ćuprija", "033" },
            { "Ub", "105" },
            { "Užice", "100" },
            { "Uroševac", "320" },
            { "Crveni krst", "126" },
            { "Crna Trava", "031" },
            { "Čajetina", "035" },
            { "Čačak", "034" },
            { "Čoka", "211" },
            { "Čukarica", "011" },
            { "Šabac", "099" },
            { "Šid", "237" },
            { "Štimlje", "325" },
            { "Štrpce", "326" },
        };
    }
}
