/// Copyright(c) 2023 Aleksa Jankovic aleksajankovic995@gmail.com
/// 
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
/// 
/// The above copyright notice and this permission notice shall be included in all
/// copies or substantial portions of the Software.
/// 
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
/// SOFTWARE.

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DividendeXmlGenerator
{
    /// <summary>
    /// This program will generate the required XML template
    /// that you can upload to ePorezi.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get user input
            string obracunskiPeriodGodina = "2023";
            string ObracunskiPeriodMesec = "03";
            string ObracunskiPeriodDan = "09";
            double BrutoPrihodUsd = 10.00;
            double PorezPlacenDrugojDrzaviUsd = 3.00;

            // One-time user input
            string imePrezimeObveznika = "ALEKSA JANKOVIĆ";
            string ulicaBrojPoreskogObveznika = "Београдска 33";
            string jmbgPodnosiocaPrijave = "1101995445566";
            string telefonKontaktOsobe = "0613334444";
            string elektronskaPosta = "aleksa@gmail.com";
            string prebivalisteOpstina = "013"; // OVO JE ZA NOVI BEOGRAD, ZA DRUGE OPSTINE, SAZNAJTE GENERISANJEM XML-a

            double kursNaDanOstvarivanjaPrihoda = GetKursNaDan(obracunskiPeriodGodina, ObracunskiPeriodMesec, ObracunskiPeriodDan);
            string obracunskiPeriod = $"{obracunskiPeriodGodina}-{ObracunskiPeriodMesec}";
            string datumDospelostiObaveze = MonthLater(new DateTime(int.Parse(obracunskiPeriodGodina), int.Parse(ObracunskiPeriodMesec), int.Parse(ObracunskiPeriodDan)));
            string datumObracunaKamate = FirstNextWorkingDay(DateTime.Today);
            string datumOstvarivanjaPrihoda = $"{obracunskiPeriodGodina}-{ObracunskiPeriodMesec}-{ObracunskiPeriodDan}";
            double brutoPrihodDouble = Math.Round(BrutoPrihodUsd * kursNaDanOstvarivanjaPrihoda, 2);
            double osnovicaZaPorezDouble = brutoPrihodDouble;
            double obracunatiPorezDouble = Math.Round(osnovicaZaPorezDouble * 0.15, 2);
            double porezPlacenDrugojDrzaviDouble = Math.Round(PorezPlacenDrugojDrzaviUsd * kursNaDanOstvarivanjaPrihoda, 2);

            // Read the template file
            string templateFilePath = @"D:\Users\Belgr\Desktop\dividende-template.xml";
            string template = File.ReadAllText(templateFilePath);

            // Fill in the template with user input
            string filledTemplate = template
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
                .Replace("{BrutoPrihod}", brutoPrihodDouble.ToString())
                .Replace("{OsnovicaZaPorez}", osnovicaZaPorezDouble.ToString())
                .Replace("{ObracunatiPorez}", obracunatiPorezDouble.ToString())
                .Replace("{PorezPlacenDrugojDrzavi}", porezPlacenDrugojDrzaviDouble.ToString());

            // Create a new XML file with the filled-in template
            string newFilePath = String.Format(@"D:\Users\Belgr\Desktop\{0}-pp-opo.xml", obracunskiPeriod);
            File.WriteAllText(newFilePath, filledTemplate);

            Console.WriteLine($"New file created at {newFilePath}");
        }

        private static double GetKursNaDan(string obracunskiPeriodGodina, string obracunskiPeriodMesec, string obracunskiPeriodDan)
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

            // Wait for the page to load and locate the "FORMIRANA NA DAN" date and the "SREDNJI KURS" value for EUR
            var formiranaNaDan = driver.FindElement(By.Id("index:id31")).Text;
            var srednjiKurs = driver.FindElement(By.XPath("//td[contains(text(), 'USD')]/following-sibling::td[4]")).Text;

            // Print the retrieved values
            Console.WriteLine($"FORMIRANA NA DAN: {formiranaNaDan}");
            Console.WriteLine($"SREDNJI KURS USD: {srednjiKurs}");

            // Close the web browser
            driver.Quit();

            if (formiranaNaDan != $"{obracunskiPeriodDan}.{obracunskiPeriodMesec}.{obracunskiPeriodGodina}.")
            {
                throw new Exception("Something went wrong");
            }

            return double.Parse(srednjiKurs.Replace(',', '.'));
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