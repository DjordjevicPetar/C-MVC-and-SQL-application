namespace B13_B14
{
    partial class Autori
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioUnos = new System.Windows.Forms.RadioButton();
            this.radioBrisanje = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InputSifra = new System.Windows.Forms.TextBox();
            this.InputIme = new System.Windows.Forms.TextBox();
            this.InputPrezime = new System.Windows.Forms.TextBox();
            this.InputDatum = new System.Windows.Forms.DateTimePicker();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBrisanje);
            this.groupBox1.Controls.Add(this.radioUnos);
            this.groupBox1.Location = new System.Drawing.Point(85, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izbor";
            // 
            // radioUnos
            // 
            this.radioUnos.AutoSize = true;
            this.radioUnos.Checked = true;
            this.radioUnos.Location = new System.Drawing.Point(7, 43);
            this.radioUnos.Name = "radioUnos";
            this.radioUnos.Size = new System.Drawing.Size(50, 17);
            this.radioUnos.TabIndex = 0;
            this.radioUnos.TabStop = true;
            this.radioUnos.Text = "Unos";
            this.radioUnos.UseVisualStyleBackColor = true;
            // 
            // radioBrisanje
            // 
            this.radioBrisanje.AutoSize = true;
            this.radioBrisanje.Location = new System.Drawing.Point(110, 43);
            this.radioBrisanje.Name = "radioBrisanje";
            this.radioBrisanje.Size = new System.Drawing.Size(62, 17);
            this.radioBrisanje.TabIndex = 1;
            this.radioBrisanje.Text = "Brisanje";
            this.radioBrisanje.UseVisualStyleBackColor = true;
            this.radioBrisanje.CheckedChanged += new System.EventHandler(this.radioBrisanje_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Datum rodjenja";
            // 
            // InputSifra
            // 
            this.InputSifra.Enabled = false;
            this.InputSifra.Location = new System.Drawing.Point(120, 146);
            this.InputSifra.Name = "InputSifra";
            this.InputSifra.Size = new System.Drawing.Size(200, 20);
            this.InputSifra.TabIndex = 5;
            this.InputSifra.TextChanged += new System.EventHandler(this.InputSifra_TextChanged);
            // 
            // InputIme
            // 
            this.InputIme.Location = new System.Drawing.Point(120, 181);
            this.InputIme.Name = "InputIme";
            this.InputIme.Size = new System.Drawing.Size(200, 20);
            this.InputIme.TabIndex = 6;
            // 
            // InputPrezime
            // 
            this.InputPrezime.Location = new System.Drawing.Point(120, 213);
            this.InputPrezime.Name = "InputPrezime";
            this.InputPrezime.Size = new System.Drawing.Size(200, 20);
            this.InputPrezime.TabIndex = 7;
            // 
            // InputDatum
            // 
            this.InputDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InputDatum.Location = new System.Drawing.Point(120, 242);
            this.InputDatum.MaxDate = new System.DateTime(2021, 5, 21, 8, 27, 44, 0);
            this.InputDatum.Name = "InputDatum";
            this.InputDatum.Size = new System.Drawing.Size(200, 20);
            this.InputDatum.TabIndex = 9;
            this.InputDatum.Value = new System.DateTime(2021, 5, 21, 0, 0, 0, 0);
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(16, 310);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(77, 34);
            this.btnUpisi.TabIndex = 10;
            this.btnUpisi.Text = "Upisi";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Enabled = false;
            this.btnObrisi.Location = new System.Drawing.Point(130, 310);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(77, 34);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(243, 310);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(77, 34);
            this.btnIzadji.TabIndex = 12;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // Autori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 410);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.InputDatum);
            this.Controls.Add(this.InputPrezime);
            this.Controls.Add(this.InputIme);
            this.Controls.Add(this.InputSifra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Autori";
            this.Text = "Autori";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBrisanje;
        private System.Windows.Forms.RadioButton radioUnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InputSifra;
        private System.Windows.Forms.TextBox InputIme;
        private System.Windows.Forms.TextBox InputPrezime;
        private System.Windows.Forms.DateTimePicker InputDatum;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzadji;
    }
}