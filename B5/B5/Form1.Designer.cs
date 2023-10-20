namespace B5
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
            this.gradoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stadioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spisakIgracaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kapacitetStadionaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajRadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradoviToolStripMenuItem,
            this.stadioniToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gradoviToolStripMenuItem
            // 
            this.gradoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.spisakIgracaToolStripMenuItem});
            this.gradoviToolStripMenuItem.Name = "gradoviToolStripMenuItem";
            this.gradoviToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.gradoviToolStripMenuItem.Text = "Gradovi";
            // 
            // stadioniToolStripMenuItem
            // 
            this.stadioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem1,
            this.kapacitetStadionaToolStripMenuItem});
            this.stadioniToolStripMenuItem.Name = "stadioniToolStripMenuItem";
            this.stadioniToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.stadioniToolStripMenuItem.Text = "Stadioni";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.krajRadaToolStripMenuItem});
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.unosToolStripMenuItem.Text = "Unos";
            this.unosToolStripMenuItem.Click += new System.EventHandler(this.unosToolStripMenuItem_Click);
            // 
            // spisakIgracaToolStripMenuItem
            // 
            this.spisakIgracaToolStripMenuItem.Name = "spisakIgracaToolStripMenuItem";
            this.spisakIgracaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.spisakIgracaToolStripMenuItem.Text = "Spisak igraca";
            this.spisakIgracaToolStripMenuItem.Click += new System.EventHandler(this.spisakIgracaToolStripMenuItem_Click);
            // 
            // unosToolStripMenuItem1
            // 
            this.unosToolStripMenuItem1.Name = "unosToolStripMenuItem1";
            this.unosToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.unosToolStripMenuItem1.Text = "Unos";
            // 
            // kapacitetStadionaToolStripMenuItem
            // 
            this.kapacitetStadionaToolStripMenuItem.Name = "kapacitetStadionaToolStripMenuItem";
            this.kapacitetStadionaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kapacitetStadionaToolStripMenuItem.Text = "Kapacitet stadiona";
            // 
            // krajRadaToolStripMenuItem
            // 
            this.krajRadaToolStripMenuItem.Name = "krajRadaToolStripMenuItem";
            this.krajRadaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.krajRadaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.krajRadaToolStripMenuItem.Text = "Kraj rada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Fudbalski klubovi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gradoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spisakIgracaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stadioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kapacitetStadionaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajRadaToolStripMenuItem;
    }
}

