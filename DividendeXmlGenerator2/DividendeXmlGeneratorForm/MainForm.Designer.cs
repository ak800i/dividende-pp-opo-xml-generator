namespace DividendeXmlGeneratorForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelObracunskiPeriod;
        private System.Windows.Forms.DateTimePicker obracunskiPeriodDateTimePicker;
        private System.Windows.Forms.Label labelValuta;
        private System.Windows.Forms.ComboBox valutaComboBox;
        private System.Windows.Forms.Label labelBrutoPrihod;
        private System.Windows.Forms.TextBox brutoPrihodTextBox;
        private System.Windows.Forms.Label labelPorezPlacenDrugojDrzavi;
        private System.Windows.Forms.TextBox porezPlacenTextBox;
        private System.Windows.Forms.Button submitButton;

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
            this.obracunskiPeriodDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valutaComboBox = new System.Windows.Forms.ComboBox();
            this.brutoPrihodTextBox = new System.Windows.Forms.TextBox();
            this.porezPlacenTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.labelObracunskiPeriod = new System.Windows.Forms.Label();
            this.labelBrutoPrihod = new System.Windows.Forms.Label();
            this.labelValuta = new System.Windows.Forms.Label();
            this.labelPorezPlacenDrugojDrzavi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // obracunskiPeriodDateTimePicker
            // 
            this.obracunskiPeriodDateTimePicker.Location = new System.Drawing.Point(12, 31);
            this.obracunskiPeriodDateTimePicker.Name = "obracunskiPeriodDateTimePicker";
            this.obracunskiPeriodDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.obracunskiPeriodDateTimePicker.TabIndex = 1;
            // 
            // valutaComboBox
            // 
            this.valutaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valutaComboBox.FormattingEnabled = true;
            this.valutaComboBox.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP"});
            this.valutaComboBox.Location = new System.Drawing.Point(12, 83);
            this.valutaComboBox.Name = "valutaComboBox";
            this.valutaComboBox.Size = new System.Drawing.Size(200, 23);
            this.valutaComboBox.TabIndex = 3;
            // 
            // brutoPrihodTextBox
            // 
            this.brutoPrihodTextBox.Location = new System.Drawing.Point(12, 135);
            this.brutoPrihodTextBox.Name = "brutoPrihodTextBox";
            this.brutoPrihodTextBox.Size = new System.Drawing.Size(200, 23);
            this.brutoPrihodTextBox.TabIndex = 5;
            // 
            // porezPlacenTextBox
            // 
            this.porezPlacenTextBox.Location = new System.Drawing.Point(12, 187);
            this.porezPlacenTextBox.Name = "porezPlacenTextBox";
            this.porezPlacenTextBox.Size = new System.Drawing.Size(200, 23);
            this.porezPlacenTextBox.TabIndex = 7;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 232);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // labelObracunskiPeriod
            // 
            this.labelObracunskiPeriod.AutoSize = true;
            this.labelObracunskiPeriod.Location = new System.Drawing.Point(12, 15);
            this.labelObracunskiPeriod.Name = "labelObracunskiPeriod";
            this.labelObracunskiPeriod.Size = new System.Drawing.Size(104, 15);
            this.labelObracunskiPeriod.TabIndex = 0;
            this.labelObracunskiPeriod.Text = "Obracunski period";
            // 
            // labelBrutoPrihod
            // 
            this.labelBrutoPrihod.AutoSize = true;
            this.labelBrutoPrihod.Location = new System.Drawing.Point(12, 119);
            this.labelBrutoPrihod.Name = "labelBrutoPrihod";
            this.labelBrutoPrihod.Size = new System.Drawing.Size(74, 15);
            this.labelBrutoPrihod.TabIndex = 4;
            this.labelBrutoPrihod.Text = "Bruto prihod";
            // 
            // labelValuta
            // 
            this.labelValuta.AutoSize = true;
            this.labelValuta.Location = new System.Drawing.Point(12, 67);
            this.labelValuta.Name = "labelValuta";
            this.labelValuta.Size = new System.Drawing.Size(39, 15);
            this.labelValuta.TabIndex = 2;
            this.labelValuta.Text = "Valuta";
            // 
            // labelPorezPlacenDrugojDrzavi
            // 
            this.labelPorezPlacenDrugojDrzavi.AutoSize = true;
            this.labelPorezPlacenDrugojDrzavi.Location = new System.Drawing.Point(12, 171);
            this.labelPorezPlacenDrugojDrzavi.Name = "labelPorezPlacenDrugojDrzavi";
            this.labelPorezPlacenDrugojDrzavi.Size = new System.Drawing.Size(146, 15);
            this.labelPorezPlacenDrugojDrzavi.TabIndex = 6;
            this.labelPorezPlacenDrugojDrzavi.Text = "Porez placen drugoj drzavi";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(244, 267);
            this.Controls.Add(this.labelPorezPlacenDrugojDrzavi);
            this.Controls.Add(this.labelValuta);
            this.Controls.Add(this.labelBrutoPrihod);
            this.Controls.Add(this.labelObracunskiPeriod);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.porezPlacenTextBox);
            this.Controls.Add(this.valutaComboBox);
            this.Controls.Add(this.brutoPrihodTextBox);
            this.Controls.Add(this.obracunskiPeriodDateTimePicker);
            this.Name = "MainForm";
            this.Text = "PP OPO XML generator za Dividende";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }

    #endregion
}
