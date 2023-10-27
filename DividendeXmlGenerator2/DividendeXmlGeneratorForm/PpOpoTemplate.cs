namespace DividendeXmlGeneratorForm
{
    internal class PpOpoTemplate
    {

        public static readonly string ppOpoXmlTemplate =
            @"
<ns1:PodaciPoreskeDeklaracije xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'
    xmlns:ns1='http://pid.purs.gov.rs'>
    <ns1:PodaciOPrijavi>
        <ns1:VrstaPrijave>3</ns1:VrstaPrijave>
        <ns1:ObracunskiPeriod>{ObracunskiPeriod}</ns1:ObracunskiPeriod>
        <ns1:DatumOstvarivanjaPrihoda>{DatumOstvarivanjaPrihoda}</ns1:DatumOstvarivanjaPrihoda>
        <ns1:Rok>1</ns1:Rok>
        <ns1:DatumDospelostiObaveze>{DatumDospelostiObaveze}</ns1:DatumDospelostiObaveze>
        <ns1:DatumObracunaKamate>{DatumObracunaKamate}</ns1:DatumObracunaKamate>

    </ns1:PodaciOPrijavi>
    <ns1:PodaciOPoreskomObvezniku>
        <ns1:PoreskiIdentifikacioniBroj>{PoreskiIdentifikacioniBroj}</ns1:PoreskiIdentifikacioniBroj>
        <ns1:ImePrezimeObveznika><![CDATA[{ImePrezimeObveznika}]]></ns1:ImePrezimeObveznika>
        <ns1:UlicaBrojPoreskogObveznika><![CDATA[{UlicaBrojPoreskogObveznika}]]></ns1:UlicaBrojPoreskogObveznika>
        <ns1:PrebivalisteOpstina>{PrebivalisteOpstina}</ns1:PrebivalisteOpstina>
        <ns1:JMBGPodnosiocaPrijave>{JMBGPodnosiocaPrijave}</ns1:JMBGPodnosiocaPrijave>
        <ns1:TelefonKontaktOsobe>{TelefonKontaktOsobe}</ns1:TelefonKontaktOsobe>
        <ns1:ElektronskaPosta>{ElektronskaPosta}</ns1:ElektronskaPosta>

    </ns1:PodaciOPoreskomObvezniku>
    <ns1:PodaciONacinuOstvarivanjaPrihoda>
        <ns1:NacinIsplate>3</ns1:NacinIsplate>

        <ns1:Ostalo>Na račun brokera u Kanadi</ns1:Ostalo>
    </ns1:PodaciONacinuOstvarivanjaPrihoda>
    <ns1:DeklarisaniPodaciOVrstamaPrihoda>

        <ns1:PodaciOVrstamaPrihoda>
            <ns1:RedniBroj>1</ns1:RedniBroj>
            <ns1:SifraVrstePrihoda>{SifraVrstePrihoda}</ns1:SifraVrstePrihoda>

            <ns1:BrutoPrihod>{BrutoPrihod}</ns1:BrutoPrihod>
            <ns1:OsnovicaZaPorez>{OsnovicaZaPorez}</ns1:OsnovicaZaPorez>
            <ns1:ObracunatiPorez>{ObracunatiPorez}</ns1:ObracunatiPorez>
            <ns1:PorezPlacenDrugojDrzavi>{PorezPlacenDrugojDrzavi}</ns1:PorezPlacenDrugojDrzavi>

        </ns1:PodaciOVrstamaPrihoda>

    </ns1:DeklarisaniPodaciOVrstamaPrihoda>
    <ns1:Ukupno>
        <ns1:FondSati>0.00</ns1:FondSati>
        <ns1:BrutoPrihod>{BrutoPrihod}</ns1:BrutoPrihod>
        <ns1:OsnovicaZaPorez>{OsnovicaZaPorez}</ns1:OsnovicaZaPorez>
        <ns1:ObracunatiPorez>{ObracunatiPorez}</ns1:ObracunatiPorez>
        <ns1:PorezPlacenDrugojDrzavi>{PorezPlacenDrugojDrzavi}</ns1:PorezPlacenDrugojDrzavi>
        <ns1:PorezZaUplatu>{PorezZaUplatuUkupno}</ns1:PorezZaUplatu>
        <ns1:OsnovicaZaDoprinose>0.00</ns1:OsnovicaZaDoprinose>
        <ns1:PIO>0.00</ns1:PIO>
        <ns1:ZDRAVSTVO>0.00</ns1:ZDRAVSTVO>
        <ns1:NEZAPOSLENOST>0.00</ns1:NEZAPOSLENOST>
    </ns1:Ukupno>
    <ns1:Kamata>
        <ns1:PorezZaUplatu>{PorezZaUplatuKamata}</ns1:PorezZaUplatu>
        <ns1:OsnovicaZaDoprinose>0.00</ns1:OsnovicaZaDoprinose>
        <ns1:PIO>0.00</ns1:PIO>
        <ns1:ZDRAVSTVO>0.00</ns1:ZDRAVSTVO>
        <ns1:NEZAPOSLENOST>0.00</ns1:NEZAPOSLENOST>
    </ns1:Kamata>
    <ns1:PodaciODodatnojKamati>

    </ns1:PodaciODodatnojKamati>
</ns1:PodaciPoreskeDeklaracije>

";
    }
}
