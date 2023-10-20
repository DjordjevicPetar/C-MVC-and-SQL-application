namespace B3_B4
{
    partial class Glumci
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InputSifra = new System.Windows.Forms.TextBox();
            this.InputIme = new System.Windows.Forms.TextBox();
            this.InputPrezime = new System.Windows.Forms.TextBox();
            this.InputDatum = new System.Windows.Forms.TextBox();
            this.InputMesto = new System.Windows.Forms.TextBox();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.BtnIzmeni = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.lista_glumaca = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum rodjenja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mesto rodjenja";
            // 
            // InputSifra
            // 
            this.InputSifra.Location = new System.Drawing.Point(134, 36);
            this.InputSifra.Name = "InputSifra";
            this.InputSifra.Size = new System.Drawing.Size(159, 22);
            this.InputSifra.TabIndex = 5;
            this.InputSifra.TextChanged += new System.EventHandler(this.InputSifra_TextChanged);
            // 
            // InputIme
            // 
            this.InputIme.Location = new System.Drawing.Point(134, 63);
            this.InputIme.Name = "InputIme";
            this.InputIme.Size = new System.Drawing.Size(159, 22);
            this.InputIme.TabIndex = 6;
            // 
            // InputPrezime
            // 
            this.InputPrezime.Location = new System.Drawing.Point(134, 90);
            this.InputPrezime.Name = "InputPrezime";
            this.InputPrezime.Size = new System.Drawing.Size(159, 22);
            this.InputPrezime.TabIndex = 7;
            // 
            // InputDatum
            // 
            this.InputDatum.Location = new System.Drawing.Point(134, 120);
            this.InputDatum.Name = "InputDatum";
            this.InputDatum.Size = new System.Drawing.Size(159, 22);
            this.InputDatum.TabIndex = 8;
            // 
            // InputMesto
            // 
            this.InputMesto.Location = new System.Drawing.Point(134, 148);
            this.InputMesto.Name = "InputMesto";
            this.InputMesto.Size = new System.Drawing.Size(159, 22);
            this.InputMesto.TabIndex = 9;
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(387, 33);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(91, 30);
            this.btnUpisi.TabIndex = 10;
            this.btnUpisi.Text = "Upisi";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(387, 69);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(91, 30);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // BtnIzmeni
            // 
            this.BtnIzmeni.Location = new System.Drawing.Point(387, 104);
            this.BtnIzmeni.Name = "BtnIzmeni";
            this.BtnIzmeni.Size = new System.Drawing.Size(91, 30);
            this.BtnIzmeni.TabIndex = 12;
            this.BtnIzmeni.Text = "Izmeni";
            this.BtnIzmeni.UseVisualStyleBackColor = true;
            this.BtnIzmeni.Click += new System.EventHandler(this.BtnIzmeni_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(387, 140);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(91, 30);
            this.btnIzadji.TabIndex = 13;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // lista_glumaca
            // 
            this.lista_glumaca.HideSelection = false;
            this.lista_glumaca.Location = new System.Drawing.Point(15, 191);
            this.lista_glumaca.Name = "lista_glumaca";
            this.lista_glumaca.Size = new System.Drawing.Size(463, 247);
            this.lista_glumaca.TabIndex = 14;
            this.lista_glumaca.UseCompatibleStateImageBehavior = false;
            this.lista_glumaca.View = System.Windows.Forms.View.Details;
            // 
            // Glumci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.lista_glumaca);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.BtnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.InputMesto);
            this.Controls.Add(this.InputDatum);
            this.Controls.Add(this.InputPrezime);
            this.Controls.Add(this.InputIme);
            this.Controls.Add(this.InputSifra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Glumci";
            this.Text = "Glumci";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Glumci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InputSifra;
        private System.Windows.Forms.TextBox InputIme;
        private System.Windows.Forms.TextBox InputPrezime;
        private System.Windows.Forms.TextBox InputDatum;
        private System.Windows.Forms.TextBox InputMesto;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button BtnIzmeni;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.ListView lista_glumaca;
    }
}