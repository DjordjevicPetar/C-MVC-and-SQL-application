namespace B27_28
{
    partial class UzrastDece
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
            this.InputUzrast = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SvojstvoMuski = new System.Windows.Forms.CheckBox();
            this.SvojstvoZenski = new System.Windows.Forms.CheckBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.InputUzrast)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uzrast";
            // 
            // InputUzrast
            // 
            this.InputUzrast.Location = new System.Drawing.Point(95, 37);
            this.InputUzrast.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.InputUzrast.Name = "InputUzrast";
            this.InputUzrast.Size = new System.Drawing.Size(120, 22);
            this.InputUzrast.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SvojstvoZenski);
            this.groupBox1.Controls.Add(this.SvojstvoMuski);
            this.groupBox1.Location = new System.Drawing.Point(281, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pol";
            // 
            // SvojstvoMuski
            // 
            this.SvojstvoMuski.AutoSize = true;
            this.SvojstvoMuski.Location = new System.Drawing.Point(7, 32);
            this.SvojstvoMuski.Name = "SvojstvoMuski";
            this.SvojstvoMuski.Size = new System.Drawing.Size(66, 21);
            this.SvojstvoMuski.TabIndex = 0;
            this.SvojstvoMuski.Text = "Muski";
            this.SvojstvoMuski.UseVisualStyleBackColor = true;
            // 
            // SvojstvoZenski
            // 
            this.SvojstvoZenski.AutoSize = true;
            this.SvojstvoZenski.Location = new System.Drawing.Point(7, 70);
            this.SvojstvoZenski.Name = "SvojstvoZenski";
            this.SvojstvoZenski.Size = new System.Drawing.Size(72, 21);
            this.SvojstvoZenski.TabIndex = 1;
            this.SvojstvoZenski.Text = "Zenski";
            this.SvojstvoZenski.UseVisualStyleBackColor = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(464, 29);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(90, 37);
            this.btnPrikazi.TabIndex = 3;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(464, 75);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(90, 35);
            this.btnIzadji.TabIndex = 4;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(538, 270);
            this.dataGridView1.TabIndex = 5;
            // 
            // UzrastDece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InputUzrast);
            this.Controls.Add(this.label1);
            this.Name = "UzrastDece";
            this.Text = "UzrastDece";
            ((System.ComponentModel.ISupportInitialize)(this.InputUzrast)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown InputUzrast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox SvojstvoZenski;
        private System.Windows.Forms.CheckBox SvojstvoMuski;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}