namespace DividendeXmlGeneratorForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label imePrezimeLabel;
        private TextBox imePrezimeTextBox;
        private Label ulicaBrojLabel;
        private TextBox ulicaBrojTextBox;
        private Label jmbgLabel;
        private TextBox jmbgTextBox;
        private Label telefonLabel;
        private TextBox telefonTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label prebivalisteLabel;
        private TextBox prebivalisteTextBox;
        private Label datumOstvarivanjaPrihodaLabel;
        private DateTimePicker obracunskiPeriodDateTimePicker;
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
            this.imePrezimeTextBox = new System.Windows.Forms.TextBox();
            this.ulicaBrojLabel = new System.Windows.Forms.Label();
            this.ulicaBrojTextBox = new System.Windows.Forms.TextBox();
            this.jmbgLabel = new System.Windows.Forms.Label();
            this.jmbgTextBox = new System.Windows.Forms.TextBox();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.prebivalisteLabel = new System.Windows.Forms.Label();
            this.prebivalisteTextBox = new System.Windows.Forms.TextBox();
            this.datumOstvarivanjaPrihodaLabel = new System.Windows.Forms.Label();
            this.obracunskiPeriodDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            // imePrezimeTextBox
            // 
            this.imePrezimeTextBox.Location = new System.Drawing.Point(200, 20);
            this.imePrezimeTextBox.Name = "imePrezimeTextBox";
            this.imePrezimeTextBox.Size = new System.Drawing.Size(160, 23);
            this.imePrezimeTextBox.TabIndex = 1;
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
            // jmbgTextBox
            // 
            this.jmbgTextBox.Location = new System.Drawing.Point(200, 100);
            this.jmbgTextBox.Name = "jmbgTextBox";
            this.jmbgTextBox.Size = new System.Drawing.Size(160, 23);
            this.jmbgTextBox.TabIndex = 5;
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
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(200, 140);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(160, 23);
            this.telefonTextBox.TabIndex = 7;
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
            // prebivalisteTextBox
            // 
            this.prebivalisteTextBox.Location = new System.Drawing.Point(200, 220);
            this.prebivalisteTextBox.Name = "prebivalisteTextBox";
            this.prebivalisteTextBox.Size = new System.Drawing.Size(160, 23);
            this.prebivalisteTextBox.TabIndex = 11;
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
            // obracunskiPeriodDateTimePicker
            // 
            this.obracunskiPeriodDateTimePicker.Location = new System.Drawing.Point(200, 260);
            this.obracunskiPeriodDateTimePicker.Name = "obracunskiPeriodDateTimePicker";
            this.obracunskiPeriodDateTimePicker.Size = new System.Drawing.Size(160, 23);
            this.obracunskiPeriodDateTimePicker.TabIndex = 13;
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
            this.Controls.Add(this.imePrezimeTextBox);
            this.Controls.Add(this.ulicaBrojLabel);
            this.Controls.Add(this.ulicaBrojTextBox);
            this.Controls.Add(this.jmbgLabel);
            this.Controls.Add(this.jmbgTextBox);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.prebivalisteLabel);
            this.Controls.Add(this.prebivalisteTextBox);
            this.Controls.Add(this.datumOstvarivanjaPrihodaLabel);
            this.Controls.Add(this.obracunskiPeriodDateTimePicker);
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
