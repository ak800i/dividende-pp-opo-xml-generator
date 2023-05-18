namespace DividendeXmlGeneratorForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label imePrezimeLabel;
        private TextBox imePrezimeObveznikaTextBox;
        private Label ulicaBrojLabel;
        private TextBox ulicaBrojTextBox;
        private Label jmbgLabel;
        private TextBox jmbgPodnosiocaTextBox;
        private Label telefonLabel;
        private TextBox telefonKontaktOsobeTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label prebivalisteLabel;
        private ComboBox opstinaPrebivalistaComboBox;
        private Label datumOstvarivanjaPrihodaLabel;
        private DateTimePicker datumOstvarivanjaPrihodaDateTimePicker;
        private Label valutaLabel;
        private ComboBox valutaComboBox;
        private Label brutoPrihodLabel;
        private TextBox brutoPrihodTextBox;
        private Label porezPlacenLabel;
        private TextBox porezPlacenTextBox;
        private Button submitButton;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imePrezimeLabel = new System.Windows.Forms.Label();
            this.imePrezimeObveznikaTextBox = new System.Windows.Forms.TextBox();
            this.ulicaBrojLabel = new System.Windows.Forms.Label();
            this.ulicaBrojTextBox = new System.Windows.Forms.TextBox();
            this.jmbgLabel = new System.Windows.Forms.Label();
            this.jmbgPodnosiocaTextBox = new System.Windows.Forms.TextBox();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.telefonKontaktOsobeTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.prebivalisteLabel = new System.Windows.Forms.Label();
            this.opstinaPrebivalistaComboBox = new System.Windows.Forms.ComboBox();
            this.datumOstvarivanjaPrihodaLabel = new System.Windows.Forms.Label();
            this.datumOstvarivanjaPrihodaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.brutoPrihodLabel = new System.Windows.Forms.Label();
            this.brutoPrihodTextBox = new System.Windows.Forms.TextBox();
            this.valutaLabel = new System.Windows.Forms.Label();
            this.valutaComboBox = new System.Windows.Forms.ComboBox();
            this.porezPlacenLabel = new System.Windows.Forms.Label();
            this.porezPlacenTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imePrezimeLabel
            // 
            this.imePrezimeLabel.AutoSize = true;
            this.imePrezimeLabel.Location = new System.Drawing.Point(20, 20);
            this.imePrezimeLabel.Name = "imePrezimeLabel";
            this.imePrezimeLabel.Size = new System.Drawing.Size(137, 15);
            this.imePrezimeLabel.TabIndex = 0;
            this.imePrezimeLabel.Text = "Ime i prezime obveznika:";
            // 
            // imePrezimeObveznikaTextBox
            // 
            this.imePrezimeObveznikaTextBox.Location = new System.Drawing.Point(200, 20);
            this.imePrezimeObveznikaTextBox.Name = "imePrezimeTextBox";
            this.imePrezimeObveznikaTextBox.Size = new System.Drawing.Size(160, 23);
            this.imePrezimeObveznikaTextBox.TabIndex = 1;
            // 
            // ulicaBrojLabel
            // 
            this.ulicaBrojLabel.AutoSize = true;
            this.ulicaBrojLabel.Location = new System.Drawing.Point(20, 60);
            this.ulicaBrojLabel.Name = "ulicaBrojLabel";
            this.ulicaBrojLabel.Size = new System.Drawing.Size(122, 15);
            this.ulicaBrojLabel.TabIndex = 2;
            this.ulicaBrojLabel.Text = "Ulica i broj obveznika:";
            // 
            // ulicaBrojTextBox
            // 
            this.ulicaBrojTextBox.Location = new System.Drawing.Point(200, 60);
            this.ulicaBrojTextBox.Name = "ulicaBrojTextBox";
            this.ulicaBrojTextBox.Size = new System.Drawing.Size(160, 23);
            this.ulicaBrojTextBox.TabIndex = 3;
            // 
            // jmbgLabel
            // 
            this.jmbgLabel.AutoSize = true;
            this.jmbgLabel.Location = new System.Drawing.Point(20, 100);
            this.jmbgLabel.Name = "jmbgLabel";
            this.jmbgLabel.Size = new System.Drawing.Size(143, 15);
            this.jmbgLabel.TabIndex = 4;
            this.jmbgLabel.Text = "JMBG podnosioca prijave:";
            // 
            // jmbgPodnosiocaTextBox
            // 
            this.jmbgPodnosiocaTextBox.Location = new System.Drawing.Point(200, 100);
            this.jmbgPodnosiocaTextBox.Name = "jmbgTextBox";
            this.jmbgPodnosiocaTextBox.Size = new System.Drawing.Size(160, 23);
            this.jmbgPodnosiocaTextBox.TabIndex = 5;
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Location = new System.Drawing.Point(20, 140);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(127, 15);
            this.telefonLabel.TabIndex = 6;
            this.telefonLabel.Text = "Telefon kontakt osobe:";
            // 
            // telefonKontaktOsobeTextBox
            // 
            this.telefonKontaktOsobeTextBox.Location = new System.Drawing.Point(200, 140);
            this.telefonKontaktOsobeTextBox.Name = "telefonTextBox";
            this.telefonKontaktOsobeTextBox.Size = new System.Drawing.Size(160, 23);
            this.telefonKontaktOsobeTextBox.TabIndex = 7;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(20, 180);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(39, 15);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(200, 180);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(160, 23);
            this.emailTextBox.TabIndex = 9;
            // 
            // prebivalisteLabel
            // 
            this.prebivalisteLabel.AutoSize = true;
            this.prebivalisteLabel.Location = new System.Drawing.Point(20, 220);
            this.prebivalisteLabel.Name = "prebivalisteLabel";
            this.prebivalisteLabel.Size = new System.Drawing.Size(143, 15);
            this.prebivalisteLabel.TabIndex = 10;
            this.prebivalisteLabel.Text = "Prebivaliste opstina - kod:";
            // 
            // opstinaPrebivalistaComboBox
            // 
            this.opstinaPrebivalistaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opstinaPrebivalistaComboBox.FormattingEnabled = true;
            this.opstinaPrebivalistaComboBox.Items.AddRange(new object[] {
            "Ada - 201",
            "Aleksandrovac - 001",
            "Aleksinac - 002",
            "Alibunar - 202",
            "Apatin - 203",
            "Aranđelovac - 003",
            "Arilje - 004",
            "Babušnica - 006",
            "Bajina Bašta - 007",
            "Barajevo - 010",
            "Batočina - 008",
            "Bač - 204",
            "Bačka Palanka - 205",
            "Bačka Topola - 206",
            "Bački Petrovac - 207",
            "Bela Palanka - 009",
            "Bela Crkva - 209",
            "Beočin - 210",
            "Bečej - 208",
            "Blace - 023",
            "Bogatić - 024",
            "Bojnik - 025",
            "Boljevac - 026",
            "Bor - 027",
            "Bosilegrad - 028",
            "Brus - 029",
            "Bujanovac - 030",
            "Valjevo - 107",
            "Varvarin - 108",
            "Velika Plana - 109",
            "Veliko Gradište - 110",
            "Vitina - 321",
            "Vladimirci - 112",
            "Vladičin Han - 111",
            "Vlasotince - 113",
            "Voždovac - 019",
            "Vranje - 114",
            "Vračar - 020",
            "Vrbas - 240",
            "Vrnjačka Banja - 115",
            "Vršac - 241",
            "Vučitrn - 322",
            "Gadžin Han - 039",
            "Glogovac - 304",
            "Gnjilane - 305",
            "Golubac - 040",
            "Gora - 331",
            "Gornji Milanovac - 041",
            "Grocka - 012",
            "Despotovac - 036",
            "Dečani - 301",
            "Dimitrovgrad - 037",
            "Doljevac - 038",
            "Đakovica - 303",
            "Žabalj - 243",
            "Žabari - 117",
            "Žagubica - 118",
            "Žitište - 244",
            "Žitorađa - 119",
            "Zaječar - 116",
            "Zvezdara - 022",
            "Zvečan - 330",
            "Zemun - 021",
            "Zrenjanin - 242",
            "Zubin Potok - 324",
            "Ivanjica - 042",
            "Inđija - 212",
            "Irig - 213",
            "Istok - 306",
            "Jagodina - 096",
            "Kanjiža - 214",
            "Kačanik - 307",
            "Kikinda - 215",
            "Kladovo - 043",
            "Klina - 308",
            "Knić - 044",
            "Knjaževac - 045",
            "Kovačica - 216",
            "Kovin - 217",
            "Kosjerić - 048",
            "Kosovo Polje - 328",
            "Kosovska Kamenica - 309",
            "Kosovska Mitrovica - 310",
            "Koceljeva - 046",
            "Kragujevac - 049",
            "Kraljevo - 050",
            "Krupanj - 051",
            "Kruševac - 052",
            "Kula - 218",
            "Kuršumlija - 054",
            "Kučevo - 053",
            "Lazarevac - 056",
            "Lajkovac - 055",
            "Lapovo - 121",
            "Lebane - 057",
            "Leposavić - 311",
            "Leskovac - 058",
            "Lipljan - 312",
            "Loznica - 059",
            "Lučani - 060",
            "Ljig - 061",
            "Ljubovija - 062",
            "Majdanpek - 063",
            "Mali Zvornik - 065",
            "Mali Iđoš - 219",
            "Malo Crniće - 066",
            "Medveđa - 067",
            "Mediana - 128",
            "Merošina - 068",
            "Mionica - 069",
            "Mladenovac - 070",
            "Negotin - 072",
            "Niška Banja - 122",
            "Nova Varoš - 074",
            "Nova Crnja - 220",
            "Novi Beograd - 013",
            "Novi Bečej - 221",
            "Novi Kneževac - 222",
            "Novi Pazar - 075",
            "Novi Sad - 223",
            "Novo Brdo - 329",
            "Obilić - 327",
            "Obrenovac - 014",
            "Opovo - 225",
            "Orahovac - 313",
            "Osečina - 076",
            "Odžaci - 224",
            "Palilula - 015",
            "Palilula (Niš) - 127",
            "Pantelej - 125",
            "Pančevo - 226",
            "Paraćin - 077",
            "Petrovaradin - 247",
            "Petrovac na Mlavi  - 078",
            "Peć - 314",
            "Pećinci - 227",
            "Pirot - 079",
            "Plandište - 228",
            "Podujevo - 315",
            "Požarevac - 080",
            "Požega - 081",
            "Preševo - 082",
            "Priboj na Limu - 083",
            "Prizren - 317",
            "Prijepolje - 084",
            "Priština - 316",
            "Prokuplje - 085",
            "Ražanj - 088",
            "Rakovica - 120",
            "Rača - 086",
            "Raška - 087",
            "Rekovac - 089",
            "Ruma - 229",
            "Savski venac - 016",
            "Svilajnac - 097",
            "Svrljig - 098",
            "Senta - 231",
            "Sečanj - 230",
            "Sjenica - 091",
            "Smederevo - 092",
            "Smederevska Palanka - 093",
            "Sokobanja - 094",
            "Sombor - 232",
            "Sopot - 017",
            "Srbica - 318",
            "Srbobran - 233",
            "Sremska Mitrovica - 234",
            "Sremski Karlovci - 250",
            "Stara Pazova - 235",
            "Stari grad - 018",
            "Stragari - 123",
            "Subotica - 236",
            "Suva Reka - 319",
            "Surdulica - 095",
            "Surčin - 124",
            "Temerin - 238",
            "Titel - 239",
            "Topola - 101",
            "Trgovište - 102",
            "Trstenik - 103",
            "Tutin - 104",
            "Ćićevac - 032",
            "Ćuprija - 033",
            "Ub - 105",
            "Užice - 100",
            "Uroševac - 320",
            "Crveni krst - 126",
            "Crna Trava - 031",
            "Čajetina - 035",
            "Čačak - 034",
            "Čoka - 211",
            "Čukarica - 011",
            "Šabac - 099",
            "Šid - 237",
            "Štimlje - 325",
            "Štrpce - 326"});
            this.opstinaPrebivalistaComboBox.Location = new System.Drawing.Point(200, 220);
            this.opstinaPrebivalistaComboBox.Name = "prebivalisteComboBox";
            this.opstinaPrebivalistaComboBox.Size = new System.Drawing.Size(160, 23);
            this.opstinaPrebivalistaComboBox.TabIndex = 11;
            // 
            // datumOstvarivanjaPrihodaLabel
            // 
            this.datumOstvarivanjaPrihodaLabel.AutoSize = true;
            this.datumOstvarivanjaPrihodaLabel.Location = new System.Drawing.Point(20, 260);
            this.datumOstvarivanjaPrihodaLabel.Name = "datumOstvarivanjaPrihodaLabel";
            this.datumOstvarivanjaPrihodaLabel.Size = new System.Drawing.Size(156, 15);
            this.datumOstvarivanjaPrihodaLabel.TabIndex = 12;
            this.datumOstvarivanjaPrihodaLabel.Text = "Datum ostvarivanja prihoda:";
            // 
            // datumOstvarivanjaPrihodaDateTimePicker
            // 
            this.datumOstvarivanjaPrihodaDateTimePicker.Location = new System.Drawing.Point(200, 260);
            this.datumOstvarivanjaPrihodaDateTimePicker.Name = "datumOstvarivanjaPrihodaDateTimePicker";
            this.datumOstvarivanjaPrihodaDateTimePicker.Size = new System.Drawing.Size(160, 23);
            this.datumOstvarivanjaPrihodaDateTimePicker.TabIndex = 13;
            // 
            // brutoPrihodLabel
            // 
            this.brutoPrihodLabel.AutoSize = true;
            this.brutoPrihodLabel.Location = new System.Drawing.Point(20, 340);
            this.brutoPrihodLabel.Name = "brutoPrihodLabel";
            this.brutoPrihodLabel.Size = new System.Drawing.Size(77, 15);
            this.brutoPrihodLabel.TabIndex = 16;
            this.brutoPrihodLabel.Text = "Bruto prihod:";
            // 
            // brutoPrihodTextBox
            // 
            this.brutoPrihodTextBox.Location = new System.Drawing.Point(200, 340);
            this.brutoPrihodTextBox.Name = "brutoPrihodTextBox";
            this.brutoPrihodTextBox.Size = new System.Drawing.Size(160, 23);
            this.brutoPrihodTextBox.TabIndex = 17;
            // 
            // valutaLabel
            // 
            this.valutaLabel.AutoSize = true;
            this.valutaLabel.Location = new System.Drawing.Point(20, 300);
            this.valutaLabel.Name = "valutaLabel";
            this.valutaLabel.Size = new System.Drawing.Size(42, 15);
            this.valutaLabel.TabIndex = 14;
            this.valutaLabel.Text = "Valuta:";
            // 
            // valutaComboBox
            // 
            this.valutaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valutaComboBox.FormattingEnabled = true;
            this.valutaComboBox.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "AUD",
            "CAD",
            "CNY",
            "CZK",
            "DKK",
            "HUF",
            "INR",
            "JPY",
            "KWD",
            "NOK",
            "RUB",
            "SEK",
            "CHF",
            "AED",
            "MKD",
            "GBP",
            "BYN",
            "RON",
            "TRY",
            "BGN",
            "BAM",
            "PLN",
            "ATS",
            "BEF",
            "FIM",
            "FRF",
            "DEM",
            "GRD",
            "IEP",
            "ITL",
            "LUF",
            "PTE",
            "ESP"});
            this.valutaComboBox.Location = new System.Drawing.Point(200, 300);
            this.valutaComboBox.Name = "valutaComboBox";
            this.valutaComboBox.Size = new System.Drawing.Size(160, 23);
            this.valutaComboBox.TabIndex = 15;
            // 
            // porezPlacenLabel
            // 
            this.porezPlacenLabel.AutoSize = true;
            this.porezPlacenLabel.Location = new System.Drawing.Point(20, 380);
            this.porezPlacenLabel.Name = "porezPlacenLabel";
            this.porezPlacenLabel.Size = new System.Drawing.Size(149, 15);
            this.porezPlacenLabel.TabIndex = 18;
            this.porezPlacenLabel.Text = "Porez placen drugoj drzavi:";
            // 
            // porezPlacenTextBox
            // 
            this.porezPlacenTextBox.Location = new System.Drawing.Point(200, 380);
            this.porezPlacenTextBox.Name = "porezPlacenTextBox";
            this.porezPlacenTextBox.Size = new System.Drawing.Size(160, 23);
            this.porezPlacenTextBox.TabIndex = 19;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(200, 420);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 20;
            this.submitButton.Text = "Submit";
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.imePrezimeLabel);
            this.Controls.Add(this.imePrezimeObveznikaTextBox);
            this.Controls.Add(this.ulicaBrojLabel);
            this.Controls.Add(this.ulicaBrojTextBox);
            this.Controls.Add(this.jmbgLabel);
            this.Controls.Add(this.jmbgPodnosiocaTextBox);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.telefonKontaktOsobeTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.prebivalisteLabel);
            this.Controls.Add(this.opstinaPrebivalistaComboBox);
            this.Controls.Add(this.datumOstvarivanjaPrihodaLabel);
            this.Controls.Add(this.datumOstvarivanjaPrihodaDateTimePicker);
            this.Controls.Add(this.valutaLabel);
            this.Controls.Add(this.valutaComboBox);
            this.Controls.Add(this.brutoPrihodLabel);
            this.Controls.Add(this.brutoPrihodTextBox);
            this.Controls.Add(this.porezPlacenLabel);
            this.Controls.Add(this.porezPlacenTextBox);
            this.Controls.Add(this.submitButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PP OPO XML generator za Dividende";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }

    #endregion
}
