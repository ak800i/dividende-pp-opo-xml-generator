using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividendeXmlGeneratorForm
{
    internal class Core
    {
        /// <summary>
        /// Returns XML as string.
        /// </summary>
        /// <param name="datumOstvarivanjaPrihodaGodina"></param>
        /// <param name="datumOstvarivanjaPrihodaMesec"></param>
        /// <param name="datumOstvarivanjaPrihodaDan"></param>
        /// <param name="brutoPrihod"></param>
        /// <param name="porezPlacenDrugojDrzavi"></param>
        /// <param name="valuta"></param>
        /// <returns>XML as string. Persist it with <see cref="File.WriteAllText(string, string)"/>.</returns>
        public static string GenerateXml(
            string imePrezimeObveznika,
            string ulicaBrojPoreskogObveznika,
            string jmbgPodnosiocaPrijave,
            string telefonKontaktOsobe,
            string elektronskaPosta,
            string prebivalisteOpstina,
            string datumOstvarivanjaPrihodaGodina,
            string datumOstvarivanjaPrihodaMesec,
            string datumOstvarivanjaPrihodaDan,
            string valuta,
            decimal brutoPrihod,
            decimal porezPlacenDrugojDrzavi)
        {
            // Get user input
            /*
            string datumOstvarivanjaPrihodaGodina = "2023";
            string datumOstvarivanjaPrihodaMesec = "03";
            string datumOstvarivanjaPrihodaDan = "09";
            double brutoPrihod = 10.00;
            double porezPlacenDrugojDrzavi = 3.00;
            

            // One-time user input
            string imePrezimeObveznika = "ALEKSA JANKOVIĆ";
            string ulicaBrojPoreskogObveznika = "Београдска 33";
            string jmbgPodnosiocaPrijave = "1101995445566";
            string telefonKontaktOsobe = "0613334444";
            string elektronskaPosta = "aleksa@gmail.com";
            string prebivalisteOpstina = "013"; // OVO JE ZA NOVI BEOGRAD, ZA DRUGE OPSTINE, SAZNAJTE GENERISANJEM XML-a
            */

            decimal poreskaStopaSrbija = 0.15M;

            decimal kursNaDanOstvarivanjaPrihoda = GetKursNaDan(datumOstvarivanjaPrihodaGodina, datumOstvarivanjaPrihodaMesec, datumOstvarivanjaPrihodaDan, valuta);
            string obracunskiPeriod = $"{datumOstvarivanjaPrihodaGodina}-{datumOstvarivanjaPrihodaMesec}";
            string datumDospelostiObaveze = MonthLater(new DateTime(int.Parse(datumOstvarivanjaPrihodaGodina), int.Parse(datumOstvarivanjaPrihodaMesec), int.Parse(datumOstvarivanjaPrihodaDan)));
            string datumObracunaKamate = FirstNextWorkingDay(DateTime.Today);
            string datumOstvarivanjaPrihoda = $"{datumOstvarivanjaPrihodaGodina}-{datumOstvarivanjaPrihodaMesec}-{datumOstvarivanjaPrihodaDan}";
            decimal brutoPrihodDouble = Math.Round(brutoPrihod * kursNaDanOstvarivanjaPrihoda, 2);
            decimal osnovicaZaPorezDouble = brutoPrihodDouble;
            decimal obracunatiPorezDouble = Math.Round(osnovicaZaPorezDouble * poreskaStopaSrbija, 2);
            decimal porezPlacenDrugojDrzaviDouble = Math.Round(porezPlacenDrugojDrzavi * kursNaDanOstvarivanjaPrihoda, 2);

            // Fill in the template with user input
            string filledTemplate = DividendeTemplate.dividendeXmlTemplate
                .Replace("{ImePrezimeObveznika}", imePrezimeObveznika)
                .Replace("{UlicaBrojPoreskogObveznika}", ulicaBrojPoreskogObveznika)
                .Replace("{JMBGPodnosiocaPrijave}", jmbgPodnosiocaPrijave)
                .Replace("{ElektronskaPosta}", elektronskaPosta)
                .Replace("{PrebivalisteOpstina}", prebivalisteOpstina)
                .Replace("{TelefonKontaktOsobe}", telefonKontaktOsobe)

                .Replace("{ObracunskiPeriod}", obracunskiPeriod)
                .Replace("{DatumOstvarivanjaPrihoda}", datumOstvarivanjaPrihoda)
                .Replace("{DatumDospelostiObaveze}", datumDospelostiObaveze)
                .Replace("{DatumObracunaKamate}", datumObracunaKamate)
                .Replace("{brutoPrihod}", brutoPrihodDouble.ToString())
                .Replace("{OsnovicaZaPorez}", osnovicaZaPorezDouble.ToString())
                .Replace("{ObracunatiPorez}", obracunatiPorezDouble.ToString())
                .Replace("{PorezPlacenDrugojDrzavi}", porezPlacenDrugojDrzaviDouble.ToString());

            return filledTemplate;
        }

        private static decimal GetKursNaDan(string obracunskiPeriodGodina, string obracunskiPeriodMesec, string obracunskiPeriodDan, string valuta)
        {
            // Open the Chrome browser and navigate to the website
            var driver = new ChromeDriver();
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

            if (formiranaNaDan != $"{obracunskiPeriodDan}.{obracunskiPeriodMesec}.{obracunskiPeriodGodina}.")
            {
                throw new Exception("Something went wrong");
            }

            return decimal.Parse(srednjiKurs.Replace(',', '.')) / int.Parse(vaziZa);
        }

        public static string MonthLater(DateTime from)
        {
            DateTime oneMonthLater = from.AddMonths(1);
            Console.WriteLine("One month later from today is {0:yyyy-MM-dd}", oneMonthLater);

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
