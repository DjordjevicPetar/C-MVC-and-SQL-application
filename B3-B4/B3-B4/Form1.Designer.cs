namespace B3_B4
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
            this.podaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glumciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poZanrovimaIGlumcimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poZanrovimaIGlumcimaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.poTipuUlogeIProducentuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podaciToolStripMenuItem,
            this.poZanrovimaIGlumcimaToolStripMenuItem,
            this.krajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // podaciToolStripMenuItem
            // 
            this.podaciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.glumciToolStripMenuItem,
            this.producentiToolStripMenuItem});
            this.podaciToolStripMenuItem.Name = "podaciToolStripMenuItem";
            this.podaciToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.podaciToolStripMenuItem.Text = "Podaci";
            // 
            // glumciToolStripMenuItem
            // 
            this.glumciToolStripMenuItem.Name = "glumciToolStripMenuItem";
            this.glumciToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.glumciToolStripMenuItem.Text = "Glumci";
            this.glumciToolStripMenuItem.Click += new System.EventHandler(this.glumciToolStripMenuItem_Click);
            // 
            // producentiToolStripMenuItem
            // 
            this.producentiToolStripMenuItem.Name = "producentiToolStripMenuItem";
            this.producentiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.producentiToolStripMenuItem.Text = "Producenti";
            this.producentiToolStripMenuItem.Click += new System.EventHandler(this.producentiToolStripMenuItem_Click);
            // 
            // poZanrovimaIGlumcimaToolStripMenuItem
            // 
            this.poZanrovimaIGlumcimaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poZanrovimaIGlumcimaToolStripMenuItem1,
            this.poTipuUlogeIProducentuToolStripMenuItem});
            this.poZanrovimaIGlumcimaToolStripMenuItem.Name = "poZanrovimaIGlumcimaToolStripMenuItem";
            this.poZanrovimaIGlumcimaToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.poZanrovimaIGlumcimaToolStripMenuItem.Text = "Upiti";
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.krajToolStripMenuItem.Text = "Kraj";
            // 
            // poZanrovimaIGlumcimaToolStripMenuItem1
            // 
            this.poZanrovimaIGlumcimaToolStripMenuItem1.Name = "poZanrovimaIGlumcimaToolStripMenuItem1";
            this.poZanrovimaIGlumcimaToolStripMenuItem1.Size = new System.Drawing.Size(268, 26);
            this.poZanrovimaIGlumcimaToolStripMenuItem1.Text = "Po zanrovima i glumcima";
            this.poZanrovimaIGlumcimaToolStripMenuItem1.Click += new System.EventHandler(this.poZanrovimaIGlumcimaToolStripMenuItem1_Click);
            // 
            // poTipuUlogeIProducentuToolStripMenuItem
            // 
            this.poTipuUlogeIProducentuToolStripMenuItem.Name = "poTipuUlogeIProducentuToolStripMenuItem";
            this.poTipuUlogeIProducentuToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.poTipuUlogeIProducentuToolStripMenuItem.Text = "Po tipu uloge i producentu";
            this.poTipuUlogeIProducentuToolStripMenuItem.Click += new System.EventHandler(this.poTipuUlogeIProducentuToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DVD kolekcija";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem podaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glumciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poZanrovimaIGlumcimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poZanrovimaIGlumcimaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem poTipuUlogeIProducentuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}

