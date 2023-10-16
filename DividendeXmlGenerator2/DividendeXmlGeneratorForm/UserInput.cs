using CsvHelper.Configuration.Attributes;

namespace DividendeXmlGeneratorForm
{
    public class UserInput
    {
        [Name("Ime i prezime")]
        public string? ImePrezime { get; set; }

        [Name("Ulica i broj")]
        public string? UlicaBroj { get; set; }

        [Name("poreski ID obveznika")]
        public string? PoreskiIdentifikacioniBrojObveznika { get; set; }

        [Name("JMBG")]
        public string? Jmbg { get; set; }

        [Name("Telefon kontakt osobe")]
        public string? TelefonKontaktOsobe { get; set; }

        [Name("email")]
        public string? Email { get; set; }

        [Name("Opstina prebivalista")]
        public string? OpstinaPrebivalista { get; set; }

        [Name("Datum ostvarivanja prihoda")]
        public DateTime? DatumOstvarivanjaPrihoda { get; set; }

        [Name("Valuta")]
        public string? Valuta { get; set; }

        [Name("Bruto prihod")]
        public string? BrutoPrihod { get; set; }

        [Name("Porez placen u drugoj drzavi")]
        public string? PorezPlacenDrugojDrzavi { get; set; }
    }
}
