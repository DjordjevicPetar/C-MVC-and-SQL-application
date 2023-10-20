namespace B35_B36
{
    partial class Ulov
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
            this.InputPecaros = new System.Windows.Forms.ComboBox();
            this.InputBrojUlova = new System.Windows.Forms.TextBox();
            this.InputDatum = new System.Windows.Forms.MaskedTextBox();
            this.InputVreme = new System.Windows.Forms.MaskedTextBox();
            this.InputVrsta = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioUpisi = new System.Windows.Forms.RadioButton();
            this.radioObrisi = new System.Windows.Forms.RadioButton();
            this.btnIzvrsi = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pecaros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Redni broj ulova";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vreme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vrsta ribe";
            // 
            // InputPecaros
            // 
            this.InputPecaros.FormattingEnabled = true;
            this.InputPecaros.Location = new System.Drawing.Point(130, 22);
            this.InputPecaros.Name = "InputPecaros";
            this.InputPecaros.Size = new System.Drawing.Size(164, 21);
            this.InputPecaros.TabIndex = 5;
            // 
            // InputBrojUlova
            // 
            this.InputBrojUlova.Enabled = false;
            this.InputBrojUlova.Location = new System.Drawing.Point(130, 65);
            this.InputBrojUlova.Name = "InputBrojUlova";
            this.InputBrojUlova.Size = new System.Drawing.Size(164, 20);
            this.InputBrojUlova.TabIndex = 6;
            // 
            // InputDatum
            // 
            this.InputDatum.Location = new System.Drawing.Point(130, 108);
            this.InputDatum.Mask = "00/00/0000";
            this.InputDatum.Name = "InputDatum";
            this.InputDatum.Size = new System.Drawing.Size(164, 20);
            this.InputDatum.TabIndex = 8;
            this.InputDatum.ValidatingType = typeof(System.DateTime);
            // 
            // InputVreme
            // 
            this.InputVreme.Location = new System.Drawing.Point(130, 156);
            this.InputVreme.Mask = "00:00";
            this.InputVreme.Name = "InputVreme";
            this.InputVreme.Size = new System.Drawing.Size(164, 20);
            this.InputVreme.TabIndex = 9;
            this.InputVreme.ValidatingType = typeof(System.DateTime);
            // 
            // InputVrsta
            // 
            this.InputVrsta.FormattingEnabled = true;
            this.InputVrsta.Location = new System.Drawing.Point(130, 195);
            this.InputVrsta.Name = "InputVrsta";
            this.InputVrsta.Size = new System.Drawing.Size(164, 21);
            this.InputVrsta.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioObrisi);
            this.groupBox1.Controls.Add(this.radioUpisi);
            this.groupBox1.Location = new System.Drawing.Point(322, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Akcija";
            // 
            // radioUpisi
            // 
            this.radioUpisi.AutoSize = true;
            this.radioUpisi.Checked = true;
            this.radioUpisi.Location = new System.Drawing.Point(71, 28);
            this.radioUpisi.Name = "radioUpisi";
            this.radioUpisi.Size = new System.Drawing.Size(48, 17);
            this.radioUpisi.TabIndex = 0;
            this.radioUpisi.TabStop = true;
            this.radioUpisi.Text = "Upisi";
            this.radioUpisi.UseVisualStyleBackColor = true;
            // 
            // radioObrisi
            // 
            this.radioObrisi.AutoSize = true;
            this.radioObrisi.Location = new System.Drawing.Point(71, 67);
            this.radioObrisi.Name = "radioObrisi";
            this.radioObrisi.Size = new System.Drawing.Size(51, 17);
            this.radioObrisi.TabIndex = 1;
            this.radioObrisi.Text = "Obrisi";
            this.radioObrisi.UseVisualStyleBackColor = true;
            this.radioObrisi.CheckedChanged += new System.EventHandler(this.radioObrisi_CheckedChanged);
            // 
            // btnIzvrsi
            // 
            this.btnIzvrsi.Location = new System.Drawing.Point(374, 137);
            this.btnIzvrsi.Name = "btnIzvrsi";
            this.btnIzvrsi.Size = new System.Drawing.Size(88, 32);
            this.btnIzvrsi.TabIndex = 12;
            this.btnIzvrsi.Text = "Izvrsi";
            this.btnIzvrsi.UseVisualStyleBackColor = true;
            this.btnIzvrsi.Click += new System.EventHandler(this.btnIzvrsi_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(374, 184);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(88, 32);
            this.btnIzadji.TabIndex = 13;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // Ulov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 251);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnIzvrsi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InputVrsta);
            this.Controls.Add(this.InputVreme);
            this.Controls.Add(this.InputDatum);
            this.Controls.Add(this.InputBrojUlova);
            this.Controls.Add(this.InputPecaros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ulov";
            this.Text = "Ulov";
            this.Load += new System.EventHandler(this.Ulov_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox InputPecaros;
        private System.Windows.Forms.TextBox InputBrojUlova;
        private System.Windows.Forms.MaskedTextBox InputDatum;
        private System.Windows.Forms.MaskedTextBox InputVreme;
        private System.Windows.Forms.ComboBox InputVrsta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioObrisi;
        private System.Windows.Forms.RadioButton radioUpisi;
        private System.Windows.Forms.Button btnIzvrsi;
        private System.Windows.Forms.Button btnIzadji;
    }
}