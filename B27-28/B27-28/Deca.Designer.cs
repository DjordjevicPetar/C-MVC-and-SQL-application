namespace B27_28
{
    partial class Deca
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InputSifra = new System.Windows.Forms.TextBox();
            this.InputIme = new System.Windows.Forms.TextBox();
            this.InputPrezime = new System.Windows.Forms.TextBox();
            this.InputDatum = new System.Windows.Forms.MaskedTextBox();
            this.InputRodID = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PolMuski = new System.Windows.Forms.CheckBox();
            this.PolZenski = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InputBeleske = new System.Windows.Forms.TextBox();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.btnPrethodni = new System.Windows.Forms.Button();
            this.btnSledeci = new System.Windows.Forms.Button();
            this.btnNacrtaj = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.dnevniBoravakDeceDataSet = new B27_28.DnevniBoravakDeceDataSet();
            this.comboBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxTableAdapter = new B27_28.DnevniBoravakDeceDataSetTableAdapters.ComboBoxTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnevniBoravakDeceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum rodjenja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Roditelj";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Beleske";
            // 
            // InputSifra
            // 
            this.InputSifra.Enabled = false;
            this.InputSifra.Location = new System.Drawing.Point(155, 29);
            this.InputSifra.Name = "InputSifra";
            this.InputSifra.Size = new System.Drawing.Size(157, 22);
            this.InputSifra.TabIndex = 6;
            // 
            // InputIme
            // 
            this.InputIme.Location = new System.Drawing.Point(155, 63);
            this.InputIme.Name = "InputIme";
            this.InputIme.Size = new System.Drawing.Size(157, 22);
            this.InputIme.TabIndex = 7;
            // 
            // InputPrezime
            // 
            this.InputPrezime.Location = new System.Drawing.Point(155, 98);
            this.InputPrezime.Name = "InputPrezime";
            this.InputPrezime.Size = new System.Drawing.Size(157, 22);
            this.InputPrezime.TabIndex = 8;
            // 
            // InputDatum
            // 
            this.InputDatum.Location = new System.Drawing.Point(155, 134);
            this.InputDatum.Mask = "00/00/0000";
            this.InputDatum.Name = "InputDatum";
            this.InputDatum.Size = new System.Drawing.Size(157, 22);
            this.InputDatum.TabIndex = 9;
            this.InputDatum.ValidatingType = typeof(System.DateTime);
            // 
            // InputRodID
            // 
            this.InputRodID.DataSource = this.comboBoxBindingSource;
            this.InputRodID.DisplayMember = "ImePrezime";
            this.InputRodID.FormattingEnabled = true;
            this.InputRodID.Location = new System.Drawing.Point(155, 171);
            this.InputRodID.Name = "InputRodID";
            this.InputRodID.Size = new System.Drawing.Size(157, 24);
            this.InputRodID.TabIndex = 10;
            this.InputRodID.ValueMember = "RoditeljID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PolZenski);
            this.groupBox1.Controls.Add(this.PolMuski);
            this.groupBox1.Location = new System.Drawing.Point(363, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 109);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pol";
            // 
            // PolMuski
            // 
            this.PolMuski.AutoSize = true;
            this.PolMuski.Location = new System.Drawing.Point(7, 29);
            this.PolMuski.Name = "PolMuski";
            this.PolMuski.Size = new System.Drawing.Size(66, 21);
            this.PolMuski.TabIndex = 0;
            this.PolMuski.Text = "Muski";
            this.PolMuski.UseVisualStyleBackColor = true;
            // 
            // PolZenski
            // 
            this.PolZenski.AutoSize = true;
            this.PolZenski.Location = new System.Drawing.Point(7, 68);
            this.PolZenski.Name = "PolZenski";
            this.PolZenski.Size = new System.Drawing.Size(72, 21);
            this.PolZenski.TabIndex = 1;
            this.PolZenski.Text = "Zenski";
            this.PolZenski.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(525, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 222);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // InputBeleske
            // 
            this.InputBeleske.Location = new System.Drawing.Point(349, 171);
            this.InputBeleske.Multiline = true;
            this.InputBeleske.Name = "InputBeleske";
            this.InputBeleske.Size = new System.Drawing.Size(152, 80);
            this.InputBeleske.TabIndex = 13;
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(164, 272);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(81, 39);
            this.btnNovi.TabIndex = 14;
            this.btnNovi.Text = "Novi";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(298, 272);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(81, 39);
            this.btnUpisi.TabIndex = 15;
            this.btnUpisi.Text = "Upisi";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // btnPrethodni
            // 
            this.btnPrethodni.Enabled = false;
            this.btnPrethodni.Location = new System.Drawing.Point(433, 275);
            this.btnPrethodni.Name = "btnPrethodni";
            this.btnPrethodni.Size = new System.Drawing.Size(81, 39);
            this.btnPrethodni.TabIndex = 16;
            this.btnPrethodni.Text = "Prethodni";
            this.btnPrethodni.UseVisualStyleBackColor = true;
            this.btnPrethodni.Click += new System.EventHandler(this.btnPrethodni_Click);
            // 
            // btnSledeci
            // 
            this.btnSledeci.Location = new System.Drawing.Point(557, 275);
            this.btnSledeci.Name = "btnSledeci";
            this.btnSledeci.Size = new System.Drawing.Size(81, 39);
            this.btnSledeci.TabIndex = 17;
            this.btnSledeci.Text = "Sledeci";
            this.btnSledeci.UseVisualStyleBackColor = true;
            this.btnSledeci.Click += new System.EventHandler(this.btnSledeci_Click);
            // 
            // btnNacrtaj
            // 
            this.btnNacrtaj.Location = new System.Drawing.Point(298, 329);
            this.btnNacrtaj.Name = "btnNacrtaj";
            this.btnNacrtaj.Size = new System.Drawing.Size(81, 45);
            this.btnNacrtaj.TabIndex = 18;
            this.btnNacrtaj.Text = "Nacrtaj";
            this.btnNacrtaj.UseVisualStyleBackColor = true;
            this.btnNacrtaj.Click += new System.EventHandler(this.btnNacrtaj_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(433, 329);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(81, 45);
            this.btnIzadji.TabIndex = 19;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // dnevniBoravakDeceDataSet
            // 
            this.dnevniBoravakDeceDataSet.DataSetName = "DnevniBoravakDeceDataSet";
            this.dnevniBoravakDeceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxBindingSource
            // 
            this.comboBoxBindingSource.DataMember = "ComboBox";
            this.comboBoxBindingSource.DataSource = this.dnevniBoravakDeceDataSet;
            // 
            // comboBoxTableAdapter
            // 
            this.comboBoxTableAdapter.ClearBeforeFill = true;
            // 
            // Deca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnNacrtaj);
            this.Controls.Add(this.btnSledeci);
            this.Controls.Add(this.btnPrethodni);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.InputBeleske);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InputRodID);
            this.Controls.Add(this.InputDatum);
            this.Controls.Add(this.InputPrezime);
            this.Controls.Add(this.InputIme);
            this.Controls.Add(this.InputSifra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Deca";
            this.Text = "Deca";
            this.Load += new System.EventHandler(this.Deca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnevniBoravakDeceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InputSifra;
        private System.Windows.Forms.TextBox InputIme;
        private System.Windows.Forms.TextBox InputPrezime;
        private System.Windows.Forms.MaskedTextBox InputDatum;
        private System.Windows.Forms.ComboBox InputRodID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox PolZenski;
        private System.Windows.Forms.CheckBox PolMuski;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox InputBeleske;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.Button btnPrethodni;
        private System.Windows.Forms.Button btnSledeci;
        private System.Windows.Forms.Button btnNacrtaj;
        private System.Windows.Forms.Button btnIzadji;
        private DnevniBoravakDeceDataSet dnevniBoravakDeceDataSet;
        private System.Windows.Forms.BindingSource comboBoxBindingSource;
        private DnevniBoravakDeceDataSetTableAdapters.ComboBoxTableAdapter comboBoxTableAdapter;
    }
}