namespace B5
{
    partial class Spisak
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
            this.InputPoz = new System.Windows.Forms.TextBox();
            this.InputGrad = new System.Windows.Forms.ComboBox();
            this.fudbalski_KlubDataSet = new B5.Fudbalski_KlubDataSet();
            this.gradBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradTableAdapter = new B5.Fudbalski_KlubDataSetTableAdapters.GradTableAdapter();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fudbalski_KlubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pozicija";
            // 
            // InputPoz
            // 
            this.InputPoz.Location = new System.Drawing.Point(197, 77);
            this.InputPoz.Name = "InputPoz";
            this.InputPoz.Size = new System.Drawing.Size(121, 22);
            this.InputPoz.TabIndex = 2;
            // 
            // InputGrad
            // 
            this.InputGrad.DataSource = this.gradBindingSource;
            this.InputGrad.DisplayMember = "Grad";
            this.InputGrad.FormattingEnabled = true;
            this.InputGrad.Location = new System.Drawing.Point(197, 25);
            this.InputGrad.Name = "InputGrad";
            this.InputGrad.Size = new System.Drawing.Size(121, 24);
            this.InputGrad.TabIndex = 3;
            this.InputGrad.ValueMember = "GradID";
            // 
            // fudbalski_KlubDataSet
            // 
            this.fudbalski_KlubDataSet.DataSetName = "Fudbalski_KlubDataSet";
            this.fudbalski_KlubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradBindingSource
            // 
            this.gradBindingSource.DataMember = "Grad";
            this.gradBindingSource.DataSource = this.fudbalski_KlubDataSet;
            // 
            // gradTableAdapter
            // 
            this.gradTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(104, 121);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(81, 32);
            this.btnPrikazi.TabIndex = 4;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(240, 121);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(78, 32);
            this.btnIzadji.TabIndex = 5;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(347, 159);
            this.dataGridView1.TabIndex = 6;
            // 
            // Spisak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 374);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.InputGrad);
            this.Controls.Add(this.InputPoz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Spisak";
            this.Text = "Spisak";
            this.Load += new System.EventHandler(this.Spisak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fudbalski_KlubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputPoz;
        private System.Windows.Forms.ComboBox InputGrad;
        private Fudbalski_KlubDataSet fudbalski_KlubDataSet;
        private System.Windows.Forms.BindingSource gradBindingSource;
        private Fudbalski_KlubDataSetTableAdapters.GradTableAdapter gradTableAdapter;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}