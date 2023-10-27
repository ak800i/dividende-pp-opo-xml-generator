using Microsoft.VisualBasic.FileIO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividendeXmlGeneratorForm
{
    internal class Core
    {
        public static void GeneratePpOpoXmlFile(
            string imePrezimeObveznika,
            string ulicaBrojPoreskogObveznika,
            string jmbgPodnosioca,
            string poreskiIdentifikacioniBrojObveznika,
            string telefonKontaktOsobe,
            string email,
            string kodOpstinePrebivalista,
            string valuta,
            DateTime datumOstvarivanjaPrihodaDateTime,
            decimal brutoPrihod,
            decimal porezPlacenDrugojDrzavi,
            string newFolderName)
        {
            // Generate the XML content
            string xml = GeneratePpOpoXml(
                imePrezimeObveznika: imePrezimeObveznika,
                ulicaBrojPoreskogObveznika: ulicaBrojPoreskogObveznika,
                jmbgPodnosioca: jmbgPodnosioca,
                poreskiIdentifikacioniBrojObveznika: poreskiIdentifikacioniBrojObveznika,
                telefonKontaktOsobe: telefonKontaktOsobe,
                email: email,
                kodOpstinePrebivalista: kodOpstinePrebivalista,
                valuta: valuta,
                datumOstvarivanjaPrihodaDateTime: datumOstvarivanjaPrihodaDateTime,
                brutoPrihod: brutoPrihod,
                porezPlacenDrugojDrzavi: porezPlacenDrugojDrzavi);

            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), newFolderName);

            // Create the directory if it doesn't exist
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Measure time with nanosecond precision using Stopwatch
            long nanoseconds = Stopwatch.GetTimestamp() * 1000000000L / Stopwatch.Frequency;

            // Convert the nanoseconds to a string with leading zeros for precision
            string nanosecondsString = nanoseconds.ToString("D9");

            string newFilePath = Path.Combine(folderPath, $"pp-opo-{DateTime.Now:yyyyMMddHHmmssfff}{nanosecondsString}-{Guid.NewGuid()}.xml");

            // Create a new XML file with the filled-in template
            File.WriteAllText(newFilePath, xml);
            Console.WriteLine($"New file created at {newFilePath}");
        }

        /// <summary>
        /// Returns XML as string.
        /// </summary>
        /// <returns>XML as string. Persist it with <see cref="File.WriteAllText(string, string)"/>.</returns>
        private static string GeneratePpOpoXml(
            string imePrezimeObveznika,
            string ulicaBrojPoreskogObveznika,
            string jmbgPodnosioca,
            string poreskiIdentifikacioniBrojObveznika,
            string telefonKontaktOsobe,
            string email,
            string kodOpstinePrebivalista,
            string valuta,
            DateTime datumOstvarivanjaPrihodaDateTime,
            decimal brutoPrihod,
            decimal porezPlacenDrugojDrzavi)
        {
            string datumOstvarivanjaPrihodaGodina = datumOstvarivanjaPrihodaDateTime.Year.ToString();
            string datumOstvarivanjaPrihodaMesec = datumOstvarivanjaPrihodaDateTime.Month.ToString("00");
            string datumOstvarivanjaPrihodaDan = datumOstvarivanjaPrihodaDateTime.Day.ToString("00");

            brutoPrihod = Math.Round(brutoPrihod, 2);
            porezPlacenDrugojDrzavi = Math.Round(porezPlacenDrugojDrzavi, 2);

            decimal poreskaStopaSrbija = 0.15M;

            decimal kursNaDanOstvarivanjaPrihoda = GetKursNaDan(datumOstvarivanjaPrihodaGodina, datumOstvarivanjaPrihodaMesec, datumOstvarivanjaPrihodaDan, valuta);
            string obracunskiPeriod = $"{datumOstvarivanjaPrihodaGodina}-{datumOstvarivanjaPrihodaMesec}";
            string datumDospelostiObaveze = FirstNextWorkingDayMonthLater(new DateTime(int.Parse(datumOstvarivanjaPrihodaGodina), int.Parse(datumOstvarivanjaPrihodaMesec), int.Parse(datumOstvarivanjaPrihodaDan)));
            string datumObracunaKamate = FirstNextWorkingDay(DateTime.Today);
            string datumOstvarivanjaPrihoda = $"{datumOstvarivanjaPrihodaGodina}-{datumOstvarivanjaPrihodaMesec}-{datumOstvarivanjaPrihodaDan}";
            decimal brutoPrihodDouble = Math.Round(brutoPrihod * kursNaDanOstvarivanjaPrihoda, 2);
            decimal osnovicaZaPorezDouble = brutoPrihodDouble;
            decimal obracunatiPorezDouble = Math.Round(osnovicaZaPorezDouble * poreskaStopaSrbija, 2);
            decimal porezPlacenDrugojDrzaviDouble = Math.Round(porezPlacenDrugojDrzavi * kursNaDanOstvarivanjaPrihoda, 2);
            decimal porezZaUplatuUkupnoDouble = obracunatiPorezDouble - porezPlacenDrugojDrzaviDouble;

            decimal porezZaUplatuKamata = Math.Round(GetUkupanIznosKamate(datumOstvarivanjaPrihodaDateTime, porezZaUplatuUkupnoDouble), 2);
            decimal porezZaUplatuKamataDouble = Math.Round(porezZaUplatuKamata, 2);

            // Fill in the template with user input
            string filledTemplate = PpOpoTemplate.ppOpoXmlTemplate
                .Replace("{ImePrezimeObveznika}", imePrezimeObveznika)
                .Replace("{UlicaBrojPoreskogObveznika}", ulicaBrojPoreskogObveznika)
                .Replace("{JMBGPodnosiocaPrijave}", jmbgPodnosioca)
                .Replace("{PoreskiIdentifikacioniBroj}", poreskiIdentifikacioniBrojObveznika)
                .Replace("{ElektronskaPosta}", email)
                .Replace("{PrebivalisteOpstina}", kodOpstinePrebivalista)
                .Replace("{TelefonKontaktOsobe}", telefonKontaktOsobe)

                .Replace("{ObracunskiPeriod}", obracunskiPeriod)
                .Replace("{DatumOstvarivanjaPrihoda}", datumOstvarivanjaPrihoda)
                .Replace("{DatumDospelostiObaveze}", datumDospelostiObaveze)
                .Replace("{DatumObracunaKamate}", datumObracunaKamate)
                .Replace("{BrutoPrihod}", brutoPrihodDouble.ToString())
                .Replace("{OsnovicaZaPorez}", osnovicaZaPorezDouble.ToString())
                .Replace("{ObracunatiPorez}", obracunatiPorezDouble.ToString())
                .Replace("{PorezPlacenDrugojDrzavi}", porezPlacenDrugojDrzaviDouble.ToString())
                .Replace("{PorezZaUplatuUkupno}", porezZaUplatuUkupnoDouble.ToString())
                .Replace("{PorezZaUplatuKamata}", porezZaUplatuKamataDouble.ToString())
                .Replace("{SifraVrstePrihoda}", "111402000");

            return filledTemplate;
        }

        static decimal GetUkupanIznosKamate(DateTime datumOstvarivanjaPrihodaDateTime, decimal porezZaUplatuUkupnoDouble)
        {
            decimal ukupanIznosKamate = 0;
            string filePath = @"D:\Users\Belgr\Desktop\poreska-godisnja-stopa.csv";
            List<PoreskGodisnjaStopaDataEntry> dataEntries = ParsePoreskGodisnjaStopaCsv(filePath);
            // Example: Loop for each day between minDate and today
            DateTime currentDate = DateTime.Now.Date;
            foreach (DateTime date in EachDay(datumOstvarivanjaPrihodaDateTime, currentDate))
            {
                PoreskGodisnjaStopaDataEntry entryForDate = FindEntriesForDate(dataEntries, date).Single();
                decimal propisanjaGodisnjaStopa = entryForDate.PoreskaStopa;
                int numberOfDays = GetNumberOfDaysInYear(date.Year);

                decimal iznosDnevneKamate = porezZaUplatuUkupnoDouble * propisanjaGodisnjaStopa / 100 / numberOfDays;
                ukupanIznosKamate += iznosDnevneKamate;
            }

            return ukupanIznosKamate;
        }

        static int GetNumberOfDaysInYear(int year)
        {
            DateTime startOfYear = new DateTime(year, 1, 1);
            DateTime endOfYear = new DateTime(year, 12, 31);

            TimeSpan span = endOfYear - startOfYear;

            // Add 1 to include both start and end dates
            return span.Days + 1;
        }

        static IEnumerable<DateTime> EachDay(DateTime from, DateTime to)
        {
            for (var day = from.Date; day.Date <= to.Date; day = day.AddDays(1))
            {
                yield return day;
            }
        }

        static List<PoreskGodisnjaStopaDataEntry> FindEntriesForDate(List<PoreskGodisnjaStopaDataEntry> dataEntries, DateTime date)
        {
            return dataEntries
                .Where(entry => date >= entry.PeriodOd && date <= entry.PeriodDo)
                .ToList();
        }

        private static List<PoreskGodisnjaStopaDataEntry> ParsePoreskGodisnjaStopaCsv(string filePath)
        {
            List<PoreskGodisnjaStopaDataEntry> dataEntries = new List<PoreskGodisnjaStopaDataEntry>();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.SetDelimiters(";");

                // Skip the header line
                parser.ReadLine();

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    // Assuming the order of fields is PeriodOd, PeriodDo, PeriodDana, Poreska
                    string periodOd = fields[0];
                    string periodDo = fields[1];
                    int periodDana = int.Parse(fields[2]);
                    decimal poreskaStopa = decimal.Parse(fields[3], CultureInfo.InvariantCulture); // Use InvariantCulture to handle ',' as decimal separator

                    PoreskGodisnjaStopaDataEntry entry = new PoreskGodisnjaStopaDataEntry
                    {
                        PeriodOd = DateTime.ParseExact(periodOd, "dd.MM.yyyy.", CultureInfo.InvariantCulture),
                        PeriodDo = DateTime.ParseExact(periodDo, "dd.MM.yyyy.", CultureInfo.InvariantCulture),
                        PeriodDana = periodDana,
                        PoreskaStopa = poreskaStopa
                    };

                    dataEntries.Add(entry);
                }
            }

            return dataEntries;
        }

        class PoreskGodisnjaStopaDataEntry
        {
            public DateTime PeriodOd { get; set; }
            public DateTime PeriodDo { get; set; }
            public int PeriodDana { get; set; }
            public decimal PoreskaStopa { get; set; }
        }

        class KursNaDan
        {
            public string RadniDan { get; set; }
            public string KalendarskiDan { get; set; }
            public int Jedinica { get; set; }
            public decimal Kurs { get; set; }
        }

        static List<KursNaDan> cadKursCsv;
        static List<KursNaDan> usdKursCsv;

        static Core()
        {
            try
            {
                cadKursCsv = ParseKursCsv(@"D:\Users\Belgr\Desktop\CAD-kurs-istorija.csv");
                usdKursCsv = ParseKursCsv(@"D:\Users\Belgr\Desktop\USD-kurs-istorija.csv");
            }
            catch
            {
                throw;
            }
        }

        static List<KursNaDan> ParseKursCsv(string filePath)
        {
            List<KursNaDan> csvDataList = new List<KursNaDan>();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                // Skip the header
                parser.ReadLine();

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (fields != null && fields.Length == 4)
                    {
                        KursNaDan csvData = new KursNaDan
                        {
                            RadniDan = fields[0],
                            KalendarskiDan = fields[1],
                            Jedinica = int.Parse(fields[2]),
                            Kurs = decimal.Parse(fields[3])
                        };

                        csvDataList.Add(csvData);
                    }
                    else
                    {
                        // Handle the case where a line doesn't have the expected number of fields
                        Console.WriteLine("Error parsing line: " + string.Join(", ", fields));
                    }
                }
            }

            return csvDataList;
        }

        private static decimal GetKursNaDan(string obracunskiPeriodGodina, string obracunskiPeriodMesec, string obracunskiPeriodDan, string valuta)
        {
            // Hot path to use cached value
            if (valuta == "CAD")
            {
                // try obtaining value from cache, if not, continue to chrome driver logic
                try
                {
                    return cadKursCsv
                        .Where(item => item.KalendarskiDan == $"{obracunskiPeriodDan}.{obracunskiPeriodMesec}.{obracunskiPeriodGodina}.")
                        .Single().Kurs;
                }
                catch { }
            }

            // Hot path to use cached value
            if (valuta == "USD")
            {
                // try obtaining value from cache, if not, continue to chrome driver logic
                try
                {
                    return usdKursCsv
                        .Where(item => item.KalendarskiDan == $"{obracunskiPeriodDan}.{obracunskiPeriodMesec}.{obracunskiPeriodGodina}.")
                        .Single().Kurs;
                }
                catch { }
            }

            while (true)
            {
                try
                {
                    Thread.Sleep(TimeSpan.FromSeconds(6));

                    // Open the Chrome browser and navigate to the website
                    var driver = new ChromeDriver(@"C:\ProgramData\chocolatey\bin\chromedriver.exe");
                    driver.Navigate().GoToUrl("https://www.nbs.rs/kursnaListaModul/naZeljeniDan.faces?lang=lat");

                    // Locate the date and "Vrsta" dropdown fields and fill in the required values
                    var dateField = driver.FindElement(By.Id("index:inputCalendar1"));
                    dateField.Clear();
                    dateField.SendKeys($"{obracunskiPeriodDan}.{obracunskiPeriodMesec}.{obracunskiPeriodGodina}.");

                    var vrstaDropdown = driver.FindElement(By.Id("index:vrstaInner"));
                    var vrstaSelect = new SelectElement(vrstaDropdown);
                    vrstaSelect.SelectByText("srednji kurs");

                    // Submit the form
                    var submitButton = driver.FindElement(By.Id("index:buttonShow"));
                    submitButton.Click();

                    // Wait for the page to load and locate the "FORMIRANA NA DAN" date and the "SREDNJI KURS" value for the given currency
                    var formiranaNaDan = driver.FindElement(By.Id("index:id31")).Text;
                    var srednjiKurs = driver.FindElement(By.XPath($"//td[contains(text(), '{valuta}')]/following-sibling::td[4]")).Text;
                    var vaziZa = driver.FindElement(By.XPath($"//td[contains(text(), '{valuta}')]/following-sibling::td[3]")).Text;

                    // Print the retrieved values
                    Console.WriteLine($"FORMIRANA NA DAN: {formiranaNaDan}");
                    Console.WriteLine($"SREDNJI KURS {valuta}: {srednjiKurs}");

                    // Close the web browser
                    driver.Quit();

                    /*
                    if (formiranaNaDan != $"{obracunskiPeriodDan}.{obracunskiPeriodMesec}.{obracunskiPeriodGodina}."
                        && formiranaNaDan != $"{obracunskiPeriodDan}.0{obracunskiPeriodMesec}.{obracunskiPeriodGodina}."
                        && formiranaNaDan != $"0{obracunskiPeriodDan}.{obracunskiPeriodMesec}.{obracunskiPeriodGodina}."
                        && formiranaNaDan != $"0{obracunskiPeriodDan}.0{obracunskiPeriodMesec}.{obracunskiPeriodGodina}.")
                    {
                        throw new Exception("Something went wrong");
                    }
                    */

                    return decimal.Parse(srednjiKurs.Replace(',', '.')) / int.Parse(vaziZa);
                }
                catch (Exception)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(30));
                }
            }
        }

        public static string FirstNextWorkingDayMonthLater(DateTime from)
        {
            DateTime oneMonthLater = from.AddMonths(1);
            Console.WriteLine($"One month later from today is {oneMonthLater:yyyy-MM-dd}");

            return FirstNextWorkingDay(oneMonthLater);
        }

        public static string FirstNextWorkingDay(DateTime from)
        {
            // Loop through the days until we find the first working day
            DateTime firstWorkingDay = from;
            while (firstWorkingDay.DayOfWeek == DayOfWeek.Saturday || firstWorkingDay.DayOfWeek == DayOfWeek.Sunday)
            {
                firstWorkingDay = firstWorkingDay.AddDays(1);
            }

            Console.WriteLine("The first working day of that month is {0:dd.MM.yyyy.}", firstWorkingDay);

            return string.Format("{0:yyyy-MM-dd}", firstWorkingDay);
        }
    }
}
