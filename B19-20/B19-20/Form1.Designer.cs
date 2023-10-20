namespace B19_20 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajOBrojuLekovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekBolestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekPakovanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poProizvodjacuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poGrupiLekovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.izvestajOBrojuLekovaToolStripMenuItem,
            this.krajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lekBolestToolStripMenuItem,
            this.lekPakovanjeToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.unosToolStripMenuItem.Text = "Unos";
            // 
            // izvestajOBrojuLekovaToolStripMenuItem
            // 
            this.izvestajOBrojuLekovaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poProizvodjacuToolStripMenuItem,
            this.poGrupiLekovaToolStripMenuItem});
            this.izvestajOBrojuLekovaToolStripMenuItem.Name = "izvestajOBrojuLekovaToolStripMenuItem";
            this.izvestajOBrojuLekovaToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.izvestajOBrojuLekovaToolStripMenuItem.Text = "Izvestaj o broju lekova";
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.krajToolStripMenuItem.Text = "Kraj";
            // 
            // lekBolestToolStripMenuItem
            // 
            this.lekBolestToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.lekBolestToolStripMenuItem.Name = "lekBolestToolStripMenuItem";
            this.lekBolestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lekBolestToolStripMenuItem.Text = "Lek-Bolest";
            this.lekBolestToolStripMenuItem.Click += new System.EventHandler(this.lekBolestToolStripMenuItem_Click);
            // 
            // lekPakovanjeToolStripMenuItem
            // 
            this.lekPakovanjeToolStripMenuItem.Name = "lekPakovanjeToolStripMenuItem";
            this.lekPakovanjeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lekPakovanjeToolStripMenuItem.Text = "Lek-Pakovanje";
            // 
            // poProizvodjacuToolStripMenuItem
            // 
            this.poProizvodjacuToolStripMenuItem.Name = "poProizvodjacuToolStripMenuItem";
            this.poProizvodjacuToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.poProizvodjacuToolStripMenuItem.Text = "Po proizvodjacu";
            this.poProizvodjacuToolStripMenuItem.Click += new System.EventHandler(this.poProizvodjacuToolStripMenuItem_Click);
            // 
            // poGrupiLekovaToolStripMenuItem
            // 
            this.poGrupiLekovaToolStripMenuItem.Name = "poGrupiLekovaToolStripMenuItem";
            this.poGrupiLekovaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.poGrupiLekovaToolStripMenuItem.Text = "Po grupi lekova";
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
            this.ClientSize = new System.Drawing.Size(740, 459);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Apoteka";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lekBolestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lekPakovanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajOBrojuLekovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poProizvodjacuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poGrupiLekovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}

