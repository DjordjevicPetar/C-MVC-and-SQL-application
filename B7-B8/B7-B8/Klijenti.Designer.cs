namespace B7_B8
{
    partial class Klijenti
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
            this.InputGrad = new System.Windows.Forms.TextBox();
            this.InputTelefon = new System.Windows.Forms.TextBox();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnPrethodni = new System.Windows.Forms.Button();
            this.btnSledeci = new System.Windows.Forms.Button();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.InputAdresa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon";
            // 
            // InputSifra
            // 
            this.InputSifra.Enabled = false;
            this.InputSifra.Location = new System.Drawing.Point(84, 39);
            this.InputSifra.Name = "InputSifra";
            this.InputSifra.Size = new System.Drawing.Size(100, 20);
            this.InputSifra.TabIndex = 5;
            // 
            // InputIme
            // 
            this.InputIme.Location = new System.Drawing.Point(84, 65);
            this.InputIme.Name = "InputIme";
            this.InputIme.Size = new System.Drawing.Size(100, 20);
            this.InputIme.TabIndex = 6;
            // 
            // InputPrezime
            // 
            this.InputPrezime.Location = new System.Drawing.Point(84, 91);
            this.InputPrezime.Name = "InputPrezime";
            this.InputPrezime.Size = new System.Drawing.Size(100, 20);
            this.InputPrezime.TabIndex = 7;
            // 
            // InputGrad
            // 
            this.InputGrad.Location = new System.Drawing.Point(84, 143);
            this.InputGrad.Name = "InputGrad";
            this.InputGrad.Size = new System.Drawing.Size(100, 20);
            this.InputGrad.TabIndex = 8;
            // 
            // InputTelefon
            // 
            this.InputTelefon.Location = new System.Drawing.Point(84, 169);
            this.InputTelefon.Name = "InputTelefon";
            this.InputTelefon.Size = new System.Drawing.Size(100, 20);
            this.InputTelefon.TabIndex = 9;
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(284, 55);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(75, 23);
            this.btnNovi.TabIndex = 10;
            this.btnNovi.Text = "Novi";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // btnPrethodni
            // 
            this.btnPrethodni.Location = new System.Drawing.Point(284, 81);
            this.btnPrethodni.Name = "btnPrethodni";
            this.btnPrethodni.Size = new System.Drawing.Size(75, 23);
            this.btnPrethodni.TabIndex = 11;
            this.btnPrethodni.Text = "Prethodni";
            this.btnPrethodni.UseVisualStyleBackColor = true;
            this.btnPrethodni.Click += new System.EventHandler(this.btnPrethodni_Click);
            // 
            // btnSledeci
            // 
            this.btnSledeci.Location = new System.Drawing.Point(284, 107);
            this.btnSledeci.Name = "btnSledeci";
            this.btnSledeci.Size = new System.Drawing.Size(75, 23);
            this.btnSledeci.TabIndex = 12;
            this.btnSledeci.Text = "Sledeci";
            this.btnSledeci.UseVisualStyleBackColor = true;
            this.btnSledeci.Click += new System.EventHandler(this.btnSledeci_Click);
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(284, 133);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(75, 23);
            this.btnUpisi.TabIndex = 13;
            this.btnUpisi.Text = "Upisi";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(284, 159);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 14;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Adresa";
            // 
            // InputAdresa
            // 
            this.InputAdresa.Location = new System.Drawing.Point(84, 118);
            this.InputAdresa.Name = "InputAdresa";
            this.InputAdresa.Size = new System.Drawing.Size(100, 20);
            this.InputAdresa.TabIndex = 16;
            // 
            // Klijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 209);
            this.Controls.Add(this.InputAdresa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.btnSledeci);
            this.Controls.Add(this.btnPrethodni);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.InputTelefon);
            this.Controls.Add(this.InputGrad);
            this.Controls.Add(this.InputPrezime);
            this.Controls.Add(this.InputIme);
            this.Controls.Add(this.InputSifra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Klijenti";
            this.Text = "Klijenti";
            this.Load += new System.EventHandler(this.Klijenti_Load);
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
        private System.Windows.Forms.TextBox InputGrad;
        private System.Windows.Forms.TextBox InputTelefon;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnPrethodni;
        private System.Windows.Forms.Button btnSledeci;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InputAdresa;
    }
}