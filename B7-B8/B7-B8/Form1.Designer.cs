namespace B7_B8
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
            this.spiskoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poAranzmanimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poRezervaijamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.spiskoviToolStripMenuItem,
            this.krajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1061, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.destinacijaToolStripMenuItem,
            this.klijentiToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.unosToolStripMenuItem.Text = "Unos";
            // 
            // spiskoviToolStripMenuItem
            // 
            this.spiskoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poAranzmanimaToolStripMenuItem,
            this.poRezervaijamaToolStripMenuItem});
            this.spiskoviToolStripMenuItem.Name = "spiskoviToolStripMenuItem";
            this.spiskoviToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.spiskoviToolStripMenuItem.Text = "Spiskovi";
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.krajToolStripMenuItem.Text = "Kraj";
            // 
            // destinacijaToolStripMenuItem
            // 
            this.destinacijaToolStripMenuItem.Name = "destinacijaToolStripMenuItem";
            this.destinacijaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.destinacijaToolStripMenuItem.Text = "Destinacija";
            this.destinacijaToolStripMenuItem.Click += new System.EventHandler(this.destinacijaToolStripMenuItem_Click);
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.klijentiToolStripMenuItem.Text = "Klijenti";
            this.klijentiToolStripMenuItem.Click += new System.EventHandler(this.klijentiToolStripMenuItem_Click);
            // 
            // poAranzmanimaToolStripMenuItem
            // 
            this.poAranzmanimaToolStripMenuItem.Name = "poAranzmanimaToolStripMenuItem";
            this.poAranzmanimaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.poAranzmanimaToolStripMenuItem.Text = "Po aranzmanima";
            this.poAranzmanimaToolStripMenuItem.Click += new System.EventHandler(this.poAranzmanimaToolStripMenuItem_Click);
            // 
            // poRezervaijamaToolStripMenuItem
            // 
            this.poRezervaijamaToolStripMenuItem.Name = "poRezervaijamaToolStripMenuItem";
            this.poRezervaijamaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.poRezervaijamaToolStripMenuItem.Text = "Po rezervacijama";
            this.poRezervaijamaToolStripMenuItem.Click += new System.EventHandler(this.poRezervaijamaToolStripMenuItem_Click);
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
            this.ClientSize = new System.Drawing.Size(1061, 564);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Turisti";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spiskoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poAranzmanimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poRezervaijamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}

