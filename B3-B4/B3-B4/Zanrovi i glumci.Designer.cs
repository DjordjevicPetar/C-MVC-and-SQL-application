namespace B3_B4
{
    partial class Zanrovi_i_glumci
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
            this.InputZanr = new System.Windows.Forms.ComboBox();
            this.InputIme = new System.Windows.Forms.TextBox();
            this.InputPrezime = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv zanra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime glumca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime glumca";
            // 
            // InputZanr
            // 
            this.InputZanr.FormattingEnabled = true;
            this.InputZanr.Location = new System.Drawing.Point(156, 36);
            this.InputZanr.Name = "InputZanr";
            this.InputZanr.Size = new System.Drawing.Size(121, 24);
            this.InputZanr.TabIndex = 3;
            // 
            // InputIme
            // 
            this.InputIme.Location = new System.Drawing.Point(156, 74);
            this.InputIme.Name = "InputIme";
            this.InputIme.Size = new System.Drawing.Size(121, 22);
            this.InputIme.TabIndex = 4;
            // 
            // InputPrezime
            // 
            this.InputPrezime.Location = new System.Drawing.Point(156, 109);
            this.InputPrezime.Name = "InputPrezime";
            this.InputPrezime.Size = new System.Drawing.Size(121, 22);
            this.InputPrezime.TabIndex = 5;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(296, 36);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(94, 35);
            this.btnPrikazi.TabIndex = 6;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(296, 96);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(94, 35);
            this.btnIzadji.TabIndex = 7;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(378, 270);
            this.dataGridView1.TabIndex = 8;
            // 
            // Zanrovi_i_glumci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.InputPrezime);
            this.Controls.Add(this.InputIme);
            this.Controls.Add(this.InputZanr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Zanrovi_i_glumci";
            this.Text = "Zanrovi i glumci";
            this.Load += new System.EventHandler(this.Zanrovi_i_glumci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox InputZanr;
        private System.Windows.Forms.TextBox InputIme;
        private System.Windows.Forms.TextBox InputPrezime;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}