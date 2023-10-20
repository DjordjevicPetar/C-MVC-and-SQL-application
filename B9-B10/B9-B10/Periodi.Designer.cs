namespace B9_B10
{
    partial class Periodi
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
            this.InputSifra = new System.Windows.Forms.TextBox();
            this.InputNaziv = new System.Windows.Forms.TextBox();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // InputSifra
            // 
            this.InputSifra.Location = new System.Drawing.Point(79, 22);
            this.InputSifra.Name = "InputSifra";
            this.InputSifra.Size = new System.Drawing.Size(100, 20);
            this.InputSifra.TabIndex = 2;
            this.InputSifra.TextChanged += new System.EventHandler(this.InputSifra_TextChanged);
            // 
            // InputNaziv
            // 
            this.InputNaziv.Location = new System.Drawing.Point(79, 65);
            this.InputNaziv.Name = "InputNaziv";
            this.InputNaziv.Size = new System.Drawing.Size(100, 20);
            this.InputNaziv.TabIndex = 3;
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(27, 130);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(91, 37);
            this.btnUpisi.TabIndex = 4;
            this.btnUpisi.Text = "Upisi";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(175, 130);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(91, 37);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(323, 130);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(91, 37);
            this.btnIzmeni.TabIndex = 6;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(175, 180);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(91, 37);
            this.btnIzadji.TabIndex = 7;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // Periodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 241);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.InputNaziv);
            this.Controls.Add(this.InputSifra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Periodi";
            this.Text = "Periodi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputSifra;
        private System.Windows.Forms.TextBox InputNaziv;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnIzadji;
    }
}