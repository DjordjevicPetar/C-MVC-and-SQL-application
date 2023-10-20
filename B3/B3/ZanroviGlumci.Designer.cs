namespace B3
{
    partial class ZanroviGlumci
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
            this.InputIme = new System.Windows.Forms.TextBox();
            this.InputPrezime = new System.Windows.Forms.TextBox();
            this.InputZanr = new System.Windows.Forms.ComboBox();
            this.dVD_KolekcijaDataSet = new B3.DVD_KolekcijaDataSet();
            this.zanrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zanrTableAdapter = new B3.DVD_KolekcijaDataSetTableAdapters.ZanrTableAdapter();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dVD_KolekcijaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanrBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv zanra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime glumca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime glumca";
            // 
            // InputIme
            // 
            this.InputIme.Location = new System.Drawing.Point(175, 88);
            this.InputIme.Name = "InputIme";
            this.InputIme.Size = new System.Drawing.Size(121, 22);
            this.InputIme.TabIndex = 4;
            // 
            // InputPrezime
            // 
            this.InputPrezime.Location = new System.Drawing.Point(175, 136);
            this.InputPrezime.Name = "InputPrezime";
            this.InputPrezime.Size = new System.Drawing.Size(121, 22);
            this.InputPrezime.TabIndex = 5;
            // 
            // InputZanr
            // 
            this.InputZanr.DataSource = this.zanrBindingSource;
            this.InputZanr.DisplayMember = "NazivZanra";
            this.InputZanr.FormattingEnabled = true;
            this.InputZanr.Location = new System.Drawing.Point(175, 40);
            this.InputZanr.Name = "InputZanr";
            this.InputZanr.Size = new System.Drawing.Size(121, 24);
            this.InputZanr.TabIndex = 6;
            this.InputZanr.ValueMember = "ZanrID";
            // 
            // dVD_KolekcijaDataSet
            // 
            this.dVD_KolekcijaDataSet.DataSetName = "DVD_KolekcijaDataSet";
            this.dVD_KolekcijaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zanrBindingSource
            // 
            this.zanrBindingSource.DataMember = "Zanr";
            this.zanrBindingSource.DataSource = this.dVD_KolekcijaDataSet;
            // 
            // zanrTableAdapter
            // 
            this.zanrTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Location = new System.Drawing.Point(348, 33);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(75, 31);
            this.btnPrikaz.TabIndex = 7;
            this.btnPrikaz.Text = "Prikazi";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(348, 122);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 30);
            this.btnIzadji.TabIndex = 8;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 189);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(411, 216);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ZanroviGlumci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 421);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.InputZanr);
            this.Controls.Add(this.InputPrezime);
            this.Controls.Add(this.InputIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ZanroviGlumci";
            this.Text = "ZanroviGlumci";
            this.Load += new System.EventHandler(this.ZanroviGlumci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dVD_KolekcijaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanrBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputIme;
        private System.Windows.Forms.TextBox InputPrezime;
        private System.Windows.Forms.ComboBox InputZanr;
        private DVD_KolekcijaDataSet dVD_KolekcijaDataSet;
        private System.Windows.Forms.BindingSource zanrBindingSource;
        private DVD_KolekcijaDataSetTableAdapters.ZanrTableAdapter zanrTableAdapter;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.ListView listView1;
    }
}