namespace B35_B36
{
    partial class Pretraga_Opisa
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
            this.boxRazlikovanje = new System.Windows.Forms.CheckBox();
            this.boxCeleReci = new System.Windows.Forms.CheckBox();
            this.InputOpis = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deo opisa";
            // 
            // boxRazlikovanje
            // 
            this.boxRazlikovanje.AutoSize = true;
            this.boxRazlikovanje.Location = new System.Drawing.Point(32, 65);
            this.boxRazlikovanje.Name = "boxRazlikovanje";
            this.boxRazlikovanje.Size = new System.Drawing.Size(158, 17);
            this.boxRazlikovanje.TabIndex = 3;
            this.boxRazlikovanje.Text = "Razlikuje velika i mala slova";
            this.boxRazlikovanje.UseVisualStyleBackColor = true;
            // 
            // boxCeleReci
            // 
            this.boxCeleReci.AutoSize = true;
            this.boxCeleReci.Location = new System.Drawing.Point(46, 101);
            this.boxCeleReci.Name = "boxCeleReci";
            this.boxCeleReci.Size = new System.Drawing.Size(144, 17);
            this.boxCeleReci.TabIndex = 4;
            this.boxCeleReci.Text = "Pronadji samo citave reci";
            this.boxCeleReci.UseVisualStyleBackColor = true;
            // 
            // InputOpis
            // 
            this.InputOpis.Location = new System.Drawing.Point(90, 28);
            this.InputOpis.Name = "InputOpis";
            this.InputOpis.Size = new System.Drawing.Size(100, 20);
            this.InputOpis.TabIndex = 5;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(67, 159);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(100, 37);
            this.btnPrikazi.TabIndex = 6;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(67, 229);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(100, 37);
            this.btnIzadji.TabIndex = 7;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(233, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 289);
            this.dataGridView1.TabIndex = 8;
            // 
            // Pretraga_Opisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 329);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.InputOpis);
            this.Controls.Add(this.boxCeleReci);
            this.Controls.Add(this.boxRazlikovanje);
            this.Controls.Add(this.label1);
            this.Name = "Pretraga_Opisa";
            this.Text = "Pretraga Opisa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox boxRazlikovanje;
        private System.Windows.Forms.CheckBox boxCeleReci;
        private System.Windows.Forms.TextBox InputOpis;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}