using System.Diagnostics;
using Newtonsoft.Json;

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
            string datumOstvarivanjaPrihodaGodina = datumOstvarivanjaPrihodaDateTime.ToString("yyyy");
            string datumOstvarivanjaPrihodaMesec = datumOstvarivanjaPrihodaDateTime.ToString("MM");
            string datumOstvarivanjaPrihodaDan = datumOstvarivanjaPrihodaDateTime.ToString("dd");

            brutoPrihod = Math.Round(brutoPrihod, 2);
            porezPlacenDrugojDrzavi = Math.Round(porezPlacenDrugojDrzavi, 2);

            decimal poreskaStopaSrbija = 0.15M;

            decimal kursNaDanOstvarivanjaPrihoda = GetKursNaDan(datumOstvarivanjaPrihodaDateTime, valuta);
            string obracunskiPeriod = $"{datumOstvarivanjaPrihodaGodina}-{datumOstvarivanjaPrihodaMesec}";
            string datumDospelostiObaveze = FirstNextWorkingDayMonthLater(new DateTime(int.Parse(datumOstvarivanjaPrihodaGodina), int.Parse(datumOstvarivanjaPrihodaMesec), int.Parse(datumOstvarivanjaPrihodaDan)));
            string datumObracunaKamate = FirstNextWorkingDay(DateTime.Today);
            string datumOstvarivanjaPrihoda = $"{datumOstvarivanjaPrihodaGodina}-{datumOstvarivanjaPrihodaMesec}-{datumOstvarivanjaPrihodaDan}";
            decimal brutoPrihodDouble = Math.Round(brutoPrihod * kursNaDanOstvarivanjaPrihoda, 2);
            decimal osnovicaZaPorezDouble = brutoPrihodDouble;
            decimal obracunatiPorezDouble = Math.Round(osnovicaZaPorezDouble * poreskaStopaSrbija, 2);
            decimal porezPlacenDrugojDrzaviDouble = Math.Round(porezPlacenDrugojDrzavi * kursNaDanOstvarivanjaPrihoda, 2);
            decimal porezZaUplatuUkupnoDouble = Math.Max(0m, obracunatiPorezDouble - porezPlacenDrugojDrzaviDouble);

            decimal porezZaUplatuKamata = 0m;
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


        private static async Task<decimal> GetExchangeRateAsync(string currencyCode, DateTime date)
        {
            string apiUrl = $"https://kurs.resenje.org/api/v1/currencies/{currencyCode}/rates/{date:yyyy-MM-dd}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.Timeout = TimeSpan.FromSeconds(3);
                    HttpResponseMessage response = await client.GetAsync(apiUrl).ConfigureAwait(false);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();


                    // Handle possible null response from JSON deserialization
                    if (string.IsNullOrEmpty(responseBody))
                    {
                        throw new InvalidOperationException("Response body cannot be null or empty.");
                    }

                    var deserialized = JsonConvert.DeserializeObject(responseBody) ?? throw new InvalidOperationException("Failed to deserialize JSON response.");
                    dynamic jsonResponse = deserialized;

                    return jsonResponse.exchange_middle ?? throw new InvalidOperationException("Exchange rate is missing in the response.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                throw new InvalidOperationException("Failed.");
            }
        }

        private static decimal GetKursNaDan(DateTime datum, string valuta)
        {
            return GetExchangeRateAsync(valuta, datum).GetAwaiter().GetResult();
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
