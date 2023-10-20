namespace B3_B4
{
    partial class Producenti
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
            this.InputSifra = new System.Windows.Forms.TextBox();
            this.InputIme = new System.Windows.Forms.TextBox();
            this.InputMail = new System.Windows.Forms.TextBox();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.listaProducenata = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // InputSifra
            // 
            this.InputSifra.Location = new System.Drawing.Point(98, 66);
            this.InputSifra.Name = "InputSifra";
            this.InputSifra.Size = new System.Drawing.Size(169, 22);
            this.InputSifra.TabIndex = 3;
            this.InputSifra.TextChanged += new System.EventHandler(this.InputSifra_TextChanged);
            // 
            // InputIme
            // 
            this.InputIme.Location = new System.Drawing.Point(98, 101);
            this.InputIme.Name = "InputIme";
            this.InputIme.Size = new System.Drawing.Size(169, 22);
            this.InputIme.TabIndex = 4;
            // 
            // InputMail
            // 
            this.InputMail.Location = new System.Drawing.Point(98, 135);
            this.InputMail.Name = "InputMail";
            this.InputMail.Size = new System.Drawing.Size(169, 22);
            this.InputMail.TabIndex = 5;
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(334, 40);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(90, 36);
            this.btnUpisi.TabIndex = 6;
            this.btnUpisi.Text = "Unesi";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(334, 82);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(90, 36);
            this.btnObrisi.TabIndex = 7;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(334, 124);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(90, 36);
            this.btnIzmeni.TabIndex = 8;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(334, 166);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(90, 36);
            this.btnIzadji.TabIndex = 9;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // listaProducenata
            // 
            this.listaProducenata.HideSelection = false;
            this.listaProducenata.Location = new System.Drawing.Point(12, 208);
            this.listaProducenata.Name = "listaProducenata";
            this.listaProducenata.Size = new System.Drawing.Size(412, 230);
            this.listaProducenata.TabIndex = 10;
            this.listaProducenata.UseCompatibleStateImageBehavior = false;
            this.listaProducenata.View = System.Windows.Forms.View.Details;
            // 
            // Producenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.listaProducenata);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.InputMail);
            this.Controls.Add(this.InputIme);
            this.Controls.Add(this.InputSifra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Producenti";
            this.Text = "Producenti";
            this.Load += new System.EventHandler(this.Producenti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputSifra;
        private System.Windows.Forms.TextBox InputIme;
        private System.Windows.Forms.TextBox InputMail;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.ListView listaProducenata;
    }
}