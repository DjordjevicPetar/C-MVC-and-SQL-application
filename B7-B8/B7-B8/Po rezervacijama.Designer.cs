namespace B7_B8
{
    partial class Po_rezervacijama
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
            this.InputKategorija = new System.Windows.Forms.ComboBox();
            this.InputDrzava = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InputOd = new System.Windows.Forms.MonthCalendar();
            this.InputDo = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drzava";
            // 
            // InputKategorija
            // 
            this.InputKategorija.FormattingEnabled = true;
            this.InputKategorija.Location = new System.Drawing.Point(100, 23);
            this.InputKategorija.Name = "InputKategorija";
            this.InputKategorija.Size = new System.Drawing.Size(121, 21);
            this.InputKategorija.TabIndex = 2;
            // 
            // InputDrzava
            // 
            this.InputDrzava.FormattingEnabled = true;
            this.InputDrzava.Location = new System.Drawing.Point(362, 23);
            this.InputDrzava.Name = "InputDrzava";
            this.InputDrzava.Size = new System.Drawing.Size(121, 21);
            this.InputDrzava.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Do";
            // 
            // InputOd
            // 
            this.InputOd.Location = new System.Drawing.Point(66, 106);
            this.InputOd.MaxSelectionCount = 1;
            this.InputOd.Name = "InputOd";
            this.InputOd.TabIndex = 6;
            // 
            // InputDo
            // 
            this.InputDo.Location = new System.Drawing.Point(338, 106);
            this.InputDo.MaxSelectionCount = 1;
            this.InputDo.Name = "InputDo";
            this.InputDo.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(628, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnPronadji
            // 
            this.btnPronadji.Location = new System.Drawing.Point(628, 238);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(95, 30);
            this.btnPronadji.TabIndex = 9;
            this.btnPronadji.Text = "Pronadji";
            this.btnPronadji.UseVisualStyleBackColor = true;
            this.btnPronadji.Click += new System.EventHandler(this.btnPronadji_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(773, 238);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(95, 30);
            this.btnIzadji.TabIndex = 10;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // Po_rezervacijama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 385);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnPronadji);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.InputDo);
            this.Controls.Add(this.InputOd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputDrzava);
            this.Controls.Add(this.InputKategorija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Po_rezervacijama";
            this.Text = "Po rezervacijama";
            this.Load += new System.EventHandler(this.Po_rezervacijama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox InputKategorija;
        private System.Windows.Forms.ComboBox InputDrzava;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar InputOd;
        private System.Windows.Forms.MonthCalendar InputDo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.Button btnIzadji;
    }
}