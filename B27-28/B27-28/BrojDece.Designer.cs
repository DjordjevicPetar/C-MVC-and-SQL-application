namespace B27_28
{
    partial class BrojDece
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SvojstvoMajka = new System.Windows.Forms.CheckBox();
            this.SvojstvoOtac = new System.Windows.Forms.CheckBox();
            this.SvojstvoStaratelj = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SvojstvoMuski = new System.Windows.Forms.CheckBox();
            this.SvojstvoZenski = new System.Windows.Forms.CheckBox();
            this.InputBrDece = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.brnIzadji = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputBrDece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SvojstvoStaratelj);
            this.groupBox1.Controls.Add(this.SvojstvoOtac);
            this.groupBox1.Controls.Add(this.SvojstvoMajka);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Svojstvo";
            // 
            // SvojstvoMajka
            // 
            this.SvojstvoMajka.AutoSize = true;
            this.SvojstvoMajka.Location = new System.Drawing.Point(16, 36);
            this.SvojstvoMajka.Name = "SvojstvoMajka";
            this.SvojstvoMajka.Size = new System.Drawing.Size(67, 21);
            this.SvojstvoMajka.TabIndex = 0;
            this.SvojstvoMajka.Text = "Majka";
            this.SvojstvoMajka.UseVisualStyleBackColor = true;
            // 
            // SvojstvoOtac
            // 
            this.SvojstvoOtac.AutoSize = true;
            this.SvojstvoOtac.Location = new System.Drawing.Point(16, 74);
            this.SvojstvoOtac.Name = "SvojstvoOtac";
            this.SvojstvoOtac.Size = new System.Drawing.Size(60, 21);
            this.SvojstvoOtac.TabIndex = 1;
            this.SvojstvoOtac.Text = "Otac";
            this.SvojstvoOtac.UseVisualStyleBackColor = true;
            // 
            // SvojstvoStaratelj
            // 
            this.SvojstvoStaratelj.AutoSize = true;
            this.SvojstvoStaratelj.Location = new System.Drawing.Point(16, 112);
            this.SvojstvoStaratelj.Name = "SvojstvoStaratelj";
            this.SvojstvoStaratelj.Size = new System.Drawing.Size(82, 21);
            this.SvojstvoStaratelj.TabIndex = 2;
            this.SvojstvoStaratelj.Text = "Staratelj";
            this.SvojstvoStaratelj.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SvojstvoZenski);
            this.groupBox2.Controls.Add(this.SvojstvoMuski);
            this.groupBox2.Location = new System.Drawing.Point(176, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 116);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pol";
            // 
            // SvojstvoMuski
            // 
            this.SvojstvoMuski.AutoSize = true;
            this.SvojstvoMuski.Location = new System.Drawing.Point(23, 36);
            this.SvojstvoMuski.Name = "SvojstvoMuski";
            this.SvojstvoMuski.Size = new System.Drawing.Size(66, 21);
            this.SvojstvoMuski.TabIndex = 0;
            this.SvojstvoMuski.Text = "Muski";
            this.SvojstvoMuski.UseVisualStyleBackColor = true;
            // 
            // SvojstvoZenski
            // 
            this.SvojstvoZenski.AutoSize = true;
            this.SvojstvoZenski.Location = new System.Drawing.Point(23, 73);
            this.SvojstvoZenski.Name = "SvojstvoZenski";
            this.SvojstvoZenski.Size = new System.Drawing.Size(72, 21);
            this.SvojstvoZenski.TabIndex = 1;
            this.SvojstvoZenski.Text = "Zenski";
            this.SvojstvoZenski.UseVisualStyleBackColor = true;
            // 
            // InputBrDece
            // 
            this.InputBrDece.Location = new System.Drawing.Point(410, 33);
            this.InputBrDece.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.InputBrDece.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InputBrDece.Name = "InputBrDece";
            this.InputBrDece.Size = new System.Drawing.Size(120, 22);
            this.InputBrDece.TabIndex = 2;
            this.InputBrDece.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Broj dece";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(592, 25);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(91, 37);
            this.btnPrikazi.TabIndex = 4;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // brnIzadji
            // 
            this.brnIzadji.Location = new System.Drawing.Point(592, 78);
            this.brnIzadji.Name = "brnIzadji";
            this.brnIzadji.Size = new System.Drawing.Size(91, 37);
            this.brnIzadji.TabIndex = 5;
            this.brnIzadji.Text = "Izadji";
            this.brnIzadji.UseVisualStyleBackColor = true;
            this.brnIzadji.Click += new System.EventHandler(this.brnIzadji_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 226);
            this.dataGridView1.TabIndex = 6;
            // 
            // BrojDece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 437);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.brnIzadji);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputBrDece);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BrojDece";
            this.Text = "Broj dece";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputBrDece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox SvojstvoStaratelj;
        private System.Windows.Forms.CheckBox SvojstvoOtac;
        private System.Windows.Forms.CheckBox SvojstvoMajka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox SvojstvoZenski;
        private System.Windows.Forms.CheckBox SvojstvoMuski;
        private System.Windows.Forms.NumericUpDown InputBrDece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button brnIzadji;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}