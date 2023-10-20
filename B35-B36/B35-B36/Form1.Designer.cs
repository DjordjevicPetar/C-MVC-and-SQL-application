namespace B35_B36
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upitiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izadjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pecarosiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulovPecarosaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaOpisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.upitiToolStripMenuItem,
            this.izadjiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pecarosiToolStripMenuItem,
            this.ulovToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.unosToolStripMenuItem.Text = "Unos";
            // 
            // upitiToolStripMenuItem
            // 
            this.upitiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ulovPecarosaToolStripMenuItem,
            this.pretragaOpisaToolStripMenuItem});
            this.upitiToolStripMenuItem.Name = "upitiToolStripMenuItem";
            this.upitiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.upitiToolStripMenuItem.Text = "Upiti";
            // 
            // izadjiToolStripMenuItem
            // 
            this.izadjiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.izadjiToolStripMenuItem.Name = "izadjiToolStripMenuItem";
            this.izadjiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.izadjiToolStripMenuItem.Text = "Izadji";
            // 
            // pecarosiToolStripMenuItem
            // 
            this.pecarosiToolStripMenuItem.Name = "pecarosiToolStripMenuItem";
            this.pecarosiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pecarosiToolStripMenuItem.Text = "Pecarosi";
            this.pecarosiToolStripMenuItem.Click += new System.EventHandler(this.pecarosiToolStripMenuItem_Click);
            // 
            // ulovToolStripMenuItem
            // 
            this.ulovToolStripMenuItem.Name = "ulovToolStripMenuItem";
            this.ulovToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ulovToolStripMenuItem.Text = "Ulov";
            this.ulovToolStripMenuItem.Click += new System.EventHandler(this.ulovToolStripMenuItem_Click);
            // 
            // ulovPecarosaToolStripMenuItem
            // 
            this.ulovPecarosaToolStripMenuItem.Name = "ulovPecarosaToolStripMenuItem";
            this.ulovPecarosaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ulovPecarosaToolStripMenuItem.Text = "Ulov pecarosa";
            this.ulovPecarosaToolStripMenuItem.Click += new System.EventHandler(this.ulovPecarosaToolStripMenuItem_Click);
            // 
            // pretragaOpisaToolStripMenuItem
            // 
            this.pretragaOpisaToolStripMenuItem.Name = "pretragaOpisaToolStripMenuItem";
            this.pretragaOpisaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pretragaOpisaToolStripMenuItem.Text = "Pretraga opisa";
            this.pretragaOpisaToolStripMenuItem.Click += new System.EventHandler(this.pretragaOpisaToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 459);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Turisticka ponuda za pecarose";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upitiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izadjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pecarosiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ulovToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ulovPecarosaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaOpisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}

