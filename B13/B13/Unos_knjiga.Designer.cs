namespace B13
{
    partial class Unos_knjiga
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.InputSifra = new System.Windows.Forms.TextBox();
            this.InputBS = new System.Windows.Forms.TextBox();
            this.InputKom = new System.Windows.Forms.TextBox();
            this.InputNaziv = new System.Windows.Forms.ComboBox();
            this.InputKat = new System.Windows.Forms.ComboBox();
            this.kategorijaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.p_djordjevicE34DataSet1 = new B13.p_djordjevicE34DataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.p_djordjevicE34DataSet = new B13.p_djordjevicE34DataSet();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijaTableAdapter = new B13.p_djordjevicE34DataSetTableAdapters.KategorijaTableAdapter();
            this.kategorijaTableAdapter1 = new B13.p_djordjevicE34DataSet1TableAdapters.KategorijaTableAdapter();
            this.kolekcija_KnjigaDataSet = new B13.Kolekcija_KnjigaDataSet();
            this.kategorijaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijaTableAdapter2 = new B13.Kolekcija_KnjigaDataSetTableAdapters.KategorijaTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_djordjevicE34DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_djordjevicE34DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolekcija_KnjigaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(305, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktivnost";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(215, 23);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Brisanje";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 23);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Upis";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Broj strana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kategorija";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Komentar";
            // 
            // InputSifra
            // 
            this.InputSifra.Location = new System.Drawing.Point(136, 94);
            this.InputSifra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputSifra.Name = "InputSifra";
            this.InputSifra.Size = new System.Drawing.Size(176, 22);
            this.InputSifra.TabIndex = 6;
            this.InputSifra.TextChanged += new System.EventHandler(this.InputSifra_TextChanged);
            // 
            // InputBS
            // 
            this.InputBS.Location = new System.Drawing.Point(136, 160);
            this.InputBS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputBS.Name = "InputBS";
            this.InputBS.Size = new System.Drawing.Size(176, 22);
            this.InputBS.TabIndex = 7;
            // 
            // InputKom
            // 
            this.InputKom.Location = new System.Drawing.Point(136, 228);
            this.InputKom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputKom.Name = "InputKom";
            this.InputKom.Size = new System.Drawing.Size(176, 22);
            this.InputKom.TabIndex = 8;
            // 
            // InputNaziv
            // 
            this.InputNaziv.FormattingEnabled = true;
            this.InputNaziv.Location = new System.Drawing.Point(136, 127);
            this.InputNaziv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputNaziv.Name = "InputNaziv";
            this.InputNaziv.Size = new System.Drawing.Size(176, 24);
            this.InputNaziv.TabIndex = 9;
            // 
            // InputKat
            // 
            this.InputKat.DataSource = this.kategorijaBindingSource2;
            this.InputKat.DisplayMember = "Naziv";
            this.InputKat.FormattingEnabled = true;
            this.InputKat.Location = new System.Drawing.Point(136, 193);
            this.InputKat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputKat.Name = "InputKat";
            this.InputKat.Size = new System.Drawing.Size(176, 24);
            this.InputKat.TabIndex = 10;
            this.InputKat.ValueMember = "KategorijaID";
            // 
            // kategorijaBindingSource1
            // 
            this.kategorijaBindingSource1.DataMember = "Kategorija";
            this.kategorijaBindingSource1.DataSource = this.p_djordjevicE34DataSet1;
            // 
            // p_djordjevicE34DataSet1
            // 
            this.p_djordjevicE34DataSet1.DataSetName = "p_djordjevicE34DataSet1";
            this.p_djordjevicE34DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 283);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Upisi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(123, 283);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Obrisi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 283);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 28);
            this.button3.TabIndex = 13;
            this.button3.Text = "Izadji";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // p_djordjevicE34DataSet
            // 
            this.p_djordjevicE34DataSet.DataSetName = "p_djordjevicE34DataSet";
            this.p_djordjevicE34DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataMember = "Kategorija";
            this.kategorijaBindingSource.DataSource = this.p_djordjevicE34DataSet;
            // 
            // kategorijaTableAdapter
            // 
            this.kategorijaTableAdapter.ClearBeforeFill = true;
            // 
            // kategorijaTableAdapter1
            // 
            this.kategorijaTableAdapter1.ClearBeforeFill = true;
            // 
            // kolekcija_KnjigaDataSet
            // 
            this.kolekcija_KnjigaDataSet.DataSetName = "Kolekcija_KnjigaDataSet";
            this.kolekcija_KnjigaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorijaBindingSource2
            // 
            this.kategorijaBindingSource2.DataMember = "Kategorija";
            this.kategorijaBindingSource2.DataSource = this.kolekcija_KnjigaDataSet;
            // 
            // kategorijaTableAdapter2
            // 
            this.kategorijaTableAdapter2.ClearBeforeFill = true;
            // 
            // Unos_knjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 343);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputKat);
            this.Controls.Add(this.InputNaziv);
            this.Controls.Add(this.InputKom);
            this.Controls.Add(this.InputBS);
            this.Controls.Add(this.InputSifra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Unos_knjiga";
            this.Text = "Unos_knjiga";
            this.Load += new System.EventHandler(this.Unos_knjiga_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_djordjevicE34DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_djordjevicE34DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolekcija_KnjigaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox InputSifra;
        private System.Windows.Forms.TextBox InputBS;
        private System.Windows.Forms.TextBox InputKom;
        private System.Windows.Forms.ComboBox InputNaziv;
        private System.Windows.Forms.ComboBox InputKat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private p_djordjevicE34DataSet p_djordjevicE34DataSet;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private p_djordjevicE34DataSetTableAdapters.KategorijaTableAdapter kategorijaTableAdapter;
        private p_djordjevicE34DataSet1 p_djordjevicE34DataSet1;
        private System.Windows.Forms.BindingSource kategorijaBindingSource1;
        private p_djordjevicE34DataSet1TableAdapters.KategorijaTableAdapter kategorijaTableAdapter1;
        private Kolekcija_KnjigaDataSet kolekcija_KnjigaDataSet;
        private System.Windows.Forms.BindingSource kategorijaBindingSource2;
        private Kolekcija_KnjigaDataSetTableAdapters.KategorijaTableAdapter kategorijaTableAdapter2;
    }
}