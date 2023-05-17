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
        private Label obracunskiPeriodLabel;
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
            this.obracunskiPeriodLabel = new System.Windows.Forms.Label();
            this.obracunskiPeriodDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.brutoPrihodLabel = new System.Windows.Forms.Label();
            this.brutoPrihodTextBox = new System.Windows.Forms.TextBox();
            this.valutaLabel = new System.Windows.Forms.Label();
            this.valutaComboBox = new System.Windows.Forms.ComboBox();
            this.porezPlacenLabel = new System.Windows.Forms.Label();
            this.porezPlacenTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Set up the form
            this.Name = "MainForm";
            this.Text = "PP OPO XML generator za Dividende";
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            // imePrezimeLabel
            this.imePrezimeLabel.AutoSize = true;
            this.imePrezimeLabel.Location = new System.Drawing.Point(20, 20);
            this.imePrezimeLabel.Text = "Ime i prezime obveznika:";
            this.Controls.Add(this.imePrezimeLabel);

            // imePrezimeTextBox
            this.imePrezimeTextBox.Location = new System.Drawing.Point(200, 20);
            this.imePrezimeTextBox.Size = new System.Drawing.Size(160, 20);
            this.Controls.Add(this.imePrezimeTextBox);

            // ulicaBrojLabel
            this.ulicaBrojLabel.AutoSize = true;
            this.ulicaBrojLabel.Location = new System.Drawing.Point(20, 60);
            this.ulicaBrojLabel.Text = "Ulica i broj obveznika:";
            this.Controls.Add(this.ulicaBrojLabel);

            // ulicaBrojTextBox
            this.ulicaBrojTextBox.Location = new System.Drawing.Point(200, 60);
            this.ulicaBrojTextBox.Size = new System.Drawing.Size(160, 20);
            this.Controls.Add(this.ulicaBrojTextBox);

            // jmbgLabel
            this.jmbgLabel.AutoSize = true;
            this.jmbgLabel.Location = new System.Drawing.Point(20, 100);
            this.jmbgLabel.Text = "JMBG podnosioca prijave:";
            this.Controls.Add(this.jmbgLabel);

            // jmbgTextBox
            this.jmbgTextBox.Location = new System.Drawing.Point(200, 100);
            this.jmbgTextBox.Size = new System.Drawing.Size(160, 20);
            this.Controls.Add(this.jmbgTextBox);

            // telefonLabel
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Location = new System.Drawing.Point(20, 140);
            this.telefonLabel.Text = "Telefon kontakt osobe:";
            this.Controls.Add(this.telefonLabel);

            // telefonTextBox
            this.telefonTextBox.Location = new System.Drawing.Point(200, 140);
            this.telefonTextBox.Size = new System.Drawing.Size(160, 20);
            this.Controls.Add(this.telefonTextBox);

            // emailLabel
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(20, 180);
            this.emailLabel.Text = "Email:";
            this.Controls.Add(this.emailLabel);

            // emailTextBox
            this.emailTextBox.Location = new System.Drawing.Point(200, 180);
            this.emailTextBox.Size = new System.Drawing.Size(160, 20);
            this.Controls.Add(this.emailTextBox);

            // prebivalisteLabel
            this.prebivalisteLabel.AutoSize = true;
            this.prebivalisteLabel.Location = new System.Drawing.Point(20, 220);
            this.prebivalisteLabel.Text = "Prebivaliste opstina - kod:";
            this.Controls.Add(this.prebivalisteLabel);

            // prebivalisteTextBox
            this.prebivalisteTextBox.Location = new System.Drawing.Point(200, 220);
            this.prebivalisteTextBox.Size = new System.Drawing.Size(160, 20);
            this.Controls.Add(this.prebivalisteTextBox);

            // obracunskiPeriodLabel
            this.obracunskiPeriodLabel.AutoSize = true;
            this.obracunskiPeriodLabel.Location = new System.Drawing.Point(20, 260);
            this.obracunskiPeriodLabel.Text = "Datum ostvarivanja prihoda:";
            this.Controls.Add(this.obracunskiPeriodLabel);

            // obracunskiPeriodDateTimePicker
            this.obracunskiPeriodDateTimePicker.Location = new System.Drawing.Point(200, 260);
            this.obracunskiPeriodDateTimePicker.Size = new System.Drawing.Size(160, 20);
            this.Controls.Add(this.obracunskiPeriodDateTimePicker);

            // valutaLabel
            this.valutaLabel.AutoSize = true;
            this.valutaLabel.Location = new System.Drawing.Point(20, 300);
            this.valutaLabel.Text = "Valuta:";
            this.Controls.Add(this.valutaLabel);

            // valutaComboBox
            this.valutaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valutaComboBox.FormattingEnabled = true;
            this.valutaComboBox.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP"});
            this.valutaComboBox.Location = new System.Drawing.Point(200, 300);
            this.valutaComboBox.Size = new System.Drawing.Size(160, 20);
            this.Controls.Add(this.valutaComboBox);

            // brutoPrihodLabel
            this.brutoPrihodLabel.AutoSize = true;
            this.brutoPrihodLabel.Location = new System.Drawing.Point(20, 340);
            this.brutoPrihodLabel.Text = "Bruto prihod:";
            this.Controls.Add(this.brutoPrihodLabel);

            // brutoPrihodTextBox
            this.brutoPrihodTextBox.Location = new System.Drawing.Point(200, 340);
            this.brutoPrihodTextBox.Size = new System.Drawing.Size(160, 20);
            this.Controls.Add(this.brutoPrihodTextBox);

            // porezPlacenLabel
            this.porezPlacenLabel.AutoSize = true;
            this.porezPlacenLabel.Location = new System.Drawing.Point(20, 380);
            this.porezPlacenLabel.Text = "Porez placen drugoj drzavi:";
            this.Controls.Add(this.porezPlacenLabel);

            // porezPlacenTextBox
            this.porezPlacenTextBox.Location = new System.Drawing.Point(200, 380);
            this.porezPlacenTextBox.Size = new System.Drawing.Size(160, 20);
            this.Controls.Add(this.porezPlacenTextBox);

            // submitButton
            this.submitButton.Location = new System.Drawing.Point(200, 420);
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.Text = "Submit";
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            this.Controls.Add(this.submitButton);

            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }

    #endregion
}
