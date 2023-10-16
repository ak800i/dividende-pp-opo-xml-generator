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
        private TextBox ulicaBrojPoreskogObveznikaTextBox;
        private Label poreskiIdentifikacioniBrojObveznikaLabel;
        private TextBox poreskiIdentifikacioniBrojObveznikaTextBox;
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
        private Button importButton;

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
            imePrezimeLabel = new Label();
            imePrezimeObveznikaTextBox = new TextBox();
            ulicaBrojLabel = new Label();
            ulicaBrojPoreskogObveznikaTextBox = new TextBox();
            poreskiIdentifikacioniBrojObveznikaLabel = new Label();
            poreskiIdentifikacioniBrojObveznikaTextBox = new TextBox();
            jmbgLabel = new Label();
            jmbgPodnosiocaTextBox = new TextBox();
            telefonLabel = new Label();
            telefonKontaktOsobeTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            prebivalisteLabel = new Label();
            opstinaPrebivalistaComboBox = new ComboBox();
            datumOstvarivanjaPrihodaLabel = new Label();
            datumOstvarivanjaPrihodaDateTimePicker = new DateTimePicker();
            brutoPrihodLabel = new Label();
            brutoPrihodTextBox = new TextBox();
            valutaLabel = new Label();
            valutaComboBox = new ComboBox();
            porezPlacenLabel = new Label();
            porezPlacenTextBox = new TextBox();
            submitButton = new Button();
            importButton = new Button();
            this.SuspendLayout();
            // 
            // imePrezimeLabel
            // 
            imePrezimeLabel.AutoSize = true;
            imePrezimeLabel.Location = new Point(20, 20);
            imePrezimeLabel.Name = "imePrezimeLabel";
            imePrezimeLabel.Size = new Size(137, 15);
            imePrezimeLabel.TabIndex = 0;
            imePrezimeLabel.Text = "Ime i prezime obveznika:";
            // 
            // imePrezimeObveznikaTextBox
            // 
            imePrezimeObveznikaTextBox.Location = new Point(200, 20);
            imePrezimeObveznikaTextBox.Name = "imePrezimeObveznikaTextBox";
            imePrezimeObveznikaTextBox.Size = new Size(160, 23);
            imePrezimeObveznikaTextBox.TabIndex = 1;
            // 
            // ulicaBrojLabel
            // 
            ulicaBrojLabel.AutoSize = true;
            ulicaBrojLabel.Location = new Point(20, 60);
            ulicaBrojLabel.Name = "ulicaBrojLabel";
            ulicaBrojLabel.Size = new Size(122, 15);
            ulicaBrojLabel.TabIndex = 2;
            ulicaBrojLabel.Text = "Ulica i broj obveznika:";
            // 
            // ulicaBrojPoreskogObveznikaTextBox
            // 
            ulicaBrojPoreskogObveznikaTextBox.Location = new Point(200, 60);
            ulicaBrojPoreskogObveznikaTextBox.Name = "ulicaBrojPoreskogObveznikaTextBox";
            ulicaBrojPoreskogObveznikaTextBox.Size = new Size(160, 23);
            ulicaBrojPoreskogObveznikaTextBox.TabIndex = 3;
            // 
            // poreskiIdentifikacioniBrojObveznikaLabel
            // 
            poreskiIdentifikacioniBrojObveznikaLabel.Location = new Point(20, 100);
            poreskiIdentifikacioniBrojObveznikaLabel.Name = "poreskiIdentifikacioniBrojObveznikaLabel";
            poreskiIdentifikacioniBrojObveznikaLabel.Size = new Size(100, 23);
            poreskiIdentifikacioniBrojObveznikaLabel.TabIndex = 4;
            poreskiIdentifikacioniBrojObveznikaLabel.Text = "poreski ID obveznika:";
            // 
            // poreskiIdentifikacioniBrojObveznikaTextBox
            // 
            poreskiIdentifikacioniBrojObveznikaTextBox.Location = new Point(200, 100);
            poreskiIdentifikacioniBrojObveznikaTextBox.Name = "poreskiIdentifikacioniBrojObveznikaTextBox";
            poreskiIdentifikacioniBrojObveznikaTextBox.Size = new Size(160, 23);
            poreskiIdentifikacioniBrojObveznikaTextBox.TabIndex = 5;
            // 
            // jmbgLabel
            // 
            jmbgLabel.AutoSize = true;
            jmbgLabel.Location = new Point(20, 140);
            jmbgLabel.Name = "jmbgLabel";
            jmbgLabel.Size = new Size(143, 15);
            jmbgLabel.TabIndex = 6;
            jmbgLabel.Text = "JMBG podnosioca prijave:";
            // 
            // jmbgPodnosiocaTextBox
            // 
            jmbgPodnosiocaTextBox.Location = new Point(200, 140);
            jmbgPodnosiocaTextBox.Name = "jmbgPodnosiocaTextBox";
            jmbgPodnosiocaTextBox.Size = new Size(160, 23);
            jmbgPodnosiocaTextBox.TabIndex = 7;
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new Point(20, 180);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new Size(126, 15);
            telefonLabel.TabIndex = 8;
            telefonLabel.Text = "Telefon kontakt osobe:";
            // 
            // telefonKontaktOsobeTextBox
            // 
            telefonKontaktOsobeTextBox.Location = new Point(200, 180);
            telefonKontaktOsobeTextBox.Name = "telefonKontaktOsobeTextBox";
            telefonKontaktOsobeTextBox.Size = new Size(160, 23);
            telefonKontaktOsobeTextBox.TabIndex = 9;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(20, 220);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 15);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(200, 220);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(160, 23);
            emailTextBox.TabIndex = 11;
            // 
            // prebivalisteLabel
            // 
            prebivalisteLabel.AutoSize = true;
            prebivalisteLabel.Location = new Point(20, 260);
            prebivalisteLabel.Name = "prebivalisteLabel";
            prebivalisteLabel.Size = new Size(143, 15);
            prebivalisteLabel.TabIndex = 12;
            prebivalisteLabel.Text = "Prebivaliste opstina - kod:";
            // 
            // opstinaPrebivalistaComboBox
            // 
            opstinaPrebivalistaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            opstinaPrebivalistaComboBox.FormattingEnabled = true;
            opstinaPrebivalistaComboBox.Items.AddRange(new object[] { "Ada - 201", "Aleksandrovac - 001", "Aleksinac - 002", "Alibunar - 202", "Apatin - 203", "Aranđelovac - 003", "Arilje - 004", "Babušnica - 006", "Bajina Bašta - 007", "Barajevo - 010", "Batočina - 008", "Bač - 204", "Bačka Palanka - 205", "Bačka Topola - 206", "Bački Petrovac - 207", "Bela Palanka - 009", "Bela Crkva - 209", "Beočin - 210", "Bečej - 208", "Blace - 023", "Bogatić - 024", "Bojnik - 025", "Boljevac - 026", "Bor - 027", "Bosilegrad - 028", "Brus - 029", "Bujanovac - 030", "Valjevo - 107", "Varvarin - 108", "Velika Plana - 109", "Veliko Gradište - 110", "Vitina - 321", "Vladimirci - 112", "Vladičin Han - 111", "Vlasotince - 113", "Voždovac - 019", "Vranje - 114", "Vračar - 020", "Vrbas - 240", "Vrnjačka Banja - 115", "Vršac - 241", "Vučitrn - 322", "Gadžin Han - 039", "Glogovac - 304", "Gnjilane - 305", "Golubac - 040", "Gora - 331", "Gornji Milanovac - 041", "Grocka - 012", "Despotovac - 036", "Dečani - 301", "Dimitrovgrad - 037", "Doljevac - 038", "Đakovica - 303", "Žabalj - 243", "Žabari - 117", "Žagubica - 118", "Žitište - 244", "Žitorađa - 119", "Zaječar - 116", "Zvezdara - 022", "Zvečan - 330", "Zemun - 021", "Zrenjanin - 242", "Zubin Potok - 324", "Ivanjica - 042", "Inđija - 212", "Irig - 213", "Istok - 306", "Jagodina - 096", "Kanjiža - 214", "Kačanik - 307", "Kikinda - 215", "Kladovo - 043", "Klina - 308", "Knić - 044", "Knjaževac - 045", "Kovačica - 216", "Kovin - 217", "Kosjerić - 048", "Kosovo Polje - 328", "Kosovska Kamenica - 309", "Kosovska Mitrovica - 310", "Koceljeva - 046", "Kragujevac - 049", "Kraljevo - 050", "Krupanj - 051", "Kruševac - 052", "Kula - 218", "Kuršumlija - 054", "Kučevo - 053", "Lazarevac - 056", "Lajkovac - 055", "Lapovo - 121", "Lebane - 057", "Leposavić - 311", "Leskovac - 058", "Lipljan - 312", "Loznica - 059", "Lučani - 060", "Ljig - 061", "Ljubovija - 062", "Majdanpek - 063", "Mali Zvornik - 065", "Mali Iđoš - 219", "Malo Crniće - 066", "Medveđa - 067", "Mediana - 128", "Merošina - 068", "Mionica - 069", "Mladenovac - 070", "Negotin - 072", "Niška Banja - 122", "Nova Varoš - 074", "Nova Crnja - 220", "Novi Beograd - 013", "Novi Bečej - 221", "Novi Kneževac - 222", "Novi Pazar - 075", "Novi Sad - 223", "Novo Brdo - 329", "Obilić - 327", "Obrenovac - 014", "Opovo - 225", "Orahovac - 313", "Osečina - 076", "Odžaci - 224", "Palilula - 015", "Palilula (Niš) - 127", "Pantelej - 125", "Pančevo - 226", "Paraćin - 077", "Petrovaradin - 247", "Petrovac na Mlavi  - 078", "Peć - 314", "Pećinci - 227", "Pirot - 079", "Plandište - 228", "Podujevo - 315", "Požarevac - 080", "Požega - 081", "Preševo - 082", "Priboj na Limu - 083", "Prizren - 317", "Prijepolje - 084", "Priština - 316", "Prokuplje - 085", "Ražanj - 088", "Rakovica - 120", "Rača - 086", "Raška - 087", "Rekovac - 089", "Ruma - 229", "Savski venac - 016", "Svilajnac - 097", "Svrljig - 098", "Senta - 231", "Sečanj - 230", "Sjenica - 091", "Smederevo - 092", "Smederevska Palanka - 093", "Sokobanja - 094", "Sombor - 232", "Sopot - 017", "Srbica - 318", "Srbobran - 233", "Sremska Mitrovica - 234", "Sremski Karlovci - 250", "Stara Pazova - 235", "Stari grad - 018", "Stragari - 123", "Subotica - 236", "Suva Reka - 319", "Surdulica - 095", "Surčin - 124", "Temerin - 238", "Titel - 239", "Topola - 101", "Trgovište - 102", "Trstenik - 103", "Tutin - 104", "Ćićevac - 032", "Ćuprija - 033", "Ub - 105", "Užice - 100", "Uroševac - 320", "Crveni krst - 126", "Crna Trava - 031", "Čajetina - 035", "Čačak - 034", "Čoka - 211", "Čukarica - 011", "Šabac - 099", "Šid - 237", "Štimlje - 325", "Štrpce - 326" });
            opstinaPrebivalistaComboBox.Location = new Point(200, 260);
            opstinaPrebivalistaComboBox.Name = "opstinaPrebivalistaComboBox";
            opstinaPrebivalistaComboBox.Size = new Size(160, 23);
            opstinaPrebivalistaComboBox.TabIndex = 13;
            // 
            // datumOstvarivanjaPrihodaLabel
            // 
            datumOstvarivanjaPrihodaLabel.AutoSize = true;
            datumOstvarivanjaPrihodaLabel.Location = new Point(20, 300);
            datumOstvarivanjaPrihodaLabel.Name = "datumOstvarivanjaPrihodaLabel";
            datumOstvarivanjaPrihodaLabel.Size = new Size(156, 15);
            datumOstvarivanjaPrihodaLabel.TabIndex = 14;
            datumOstvarivanjaPrihodaLabel.Text = "Datum ostvarivanja prihoda:";
            // 
            // datumOstvarivanjaPrihodaDateTimePicker
            // 
            datumOstvarivanjaPrihodaDateTimePicker.Location = new Point(200, 300);
            datumOstvarivanjaPrihodaDateTimePicker.Name = "datumOstvarivanjaPrihodaDateTimePicker";
            datumOstvarivanjaPrihodaDateTimePicker.Size = new Size(160, 23);
            datumOstvarivanjaPrihodaDateTimePicker.TabIndex = 15;
            // 
            // brutoPrihodLabel
            // 
            brutoPrihodLabel.AutoSize = true;
            brutoPrihodLabel.Location = new Point(20, 380);
            brutoPrihodLabel.Name = "brutoPrihodLabel";
            brutoPrihodLabel.Size = new Size(77, 15);
            brutoPrihodLabel.TabIndex = 16;
            brutoPrihodLabel.Text = "Bruto prihod:";
            // 
            // brutoPrihodTextBox
            // 
            brutoPrihodTextBox.Location = new Point(200, 380);
            brutoPrihodTextBox.Name = "brutoPrihodTextBox";
            brutoPrihodTextBox.Size = new Size(160, 23);
            brutoPrihodTextBox.TabIndex = 17;
            // 
            // valutaLabel
            // 
            valutaLabel.AutoSize = true;
            valutaLabel.Location = new Point(20, 340);
            valutaLabel.Name = "valutaLabel";
            valutaLabel.Size = new Size(42, 15);
            valutaLabel.TabIndex = 18;
            valutaLabel.Text = "Valuta:";
            // 
            // valutaComboBox
            // 
            valutaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            valutaComboBox.FormattingEnabled = true;
            valutaComboBox.Items.AddRange(new object[] { "EUR", "USD", "AUD", "CAD", "CNY", "CZK", "DKK", "HUF", "INR", "JPY", "KWD", "NOK", "RUB", "SEK", "CHF", "AED", "MKD", "GBP", "BYN", "RON", "TRY", "BGN", "BAM", "PLN", "ATS", "BEF", "FIM", "FRF", "DEM", "GRD", "IEP", "ITL", "LUF", "PTE", "ESP" });
            valutaComboBox.Location = new Point(200, 340);
            valutaComboBox.Name = "valutaComboBox";
            valutaComboBox.Size = new Size(160, 23);
            valutaComboBox.TabIndex = 19;
            // 
            // porezPlacenLabel
            // 
            porezPlacenLabel.AutoSize = true;
            porezPlacenLabel.Location = new Point(20, 420);
            porezPlacenLabel.Name = "porezPlacenLabel";
            porezPlacenLabel.Size = new Size(149, 15);
            porezPlacenLabel.TabIndex = 20;
            porezPlacenLabel.Text = "Porez placen drugoj drzavi:";
            // 
            // porezPlacenTextBox
            // 
            porezPlacenTextBox.Location = new Point(200, 420);
            porezPlacenTextBox.Name = "porezPlacenTextBox";
            porezPlacenTextBox.Size = new Size(160, 23);
            porezPlacenTextBox.TabIndex = 21;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(200, 460);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 22;
            submitButton.Text = "Submit";
            submitButton.Click += this.SubmitButton_Click;
            // 
            // importButton
            // 
            importButton.Location = new Point(82, 460);
            importButton.Name = "importButton";
            importButton.Size = new Size(75, 23);
            importButton.TabIndex = 23;
            importButton.Text = "Import";
            importButton.Click += this.importButton_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(400, 500);
            Controls.Add(importButton);
            Controls.Add(imePrezimeLabel);
            Controls.Add(imePrezimeObveznikaTextBox);
            Controls.Add(ulicaBrojLabel);
            Controls.Add(ulicaBrojPoreskogObveznikaTextBox);
            Controls.Add(poreskiIdentifikacioniBrojObveznikaLabel);
            Controls.Add(poreskiIdentifikacioniBrojObveznikaTextBox);
            Controls.Add(jmbgLabel);
            Controls.Add(jmbgPodnosiocaTextBox);
            Controls.Add(telefonLabel);
            Controls.Add(telefonKontaktOsobeTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(prebivalisteLabel);
            Controls.Add(opstinaPrebivalistaComboBox);
            Controls.Add(datumOstvarivanjaPrihodaLabel);
            Controls.Add(datumOstvarivanjaPrihodaDateTimePicker);
            Controls.Add(valutaLabel);
            Controls.Add(valutaComboBox);
            Controls.Add(brutoPrihodLabel);
            Controls.Add(brutoPrihodTextBox);
            Controls.Add(porezPlacenLabel);
            Controls.Add(porezPlacenTextBox);
            Controls.Add(submitButton);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PP OPO XML generator za Dividende";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }

    #endregion
}
