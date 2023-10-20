namespace B27_28
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
            this.roditeljiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brojDeceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzrastDeceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.spiskoviToolStripMenuItem,
            this.krajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roditeljiToolStripMenuItem,
            this.decaToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.unosToolStripMenuItem.Text = "Unos";
            // 
            // spiskoviToolStripMenuItem
            // 
            this.spiskoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brojDeceToolStripMenuItem,
            this.uzrastDeceToolStripMenuItem});
            this.spiskoviToolStripMenuItem.Name = "spiskoviToolStripMenuItem";
            this.spiskoviToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.spiskoviToolStripMenuItem.Text = "Spiskovi";
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.krajToolStripMenuItem.Text = "Kraj";
            // 
            // roditeljiToolStripMenuItem
            // 
            this.roditeljiToolStripMenuItem.Name = "roditeljiToolStripMenuItem";
            this.roditeljiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.roditeljiToolStripMenuItem.Text = "Roditelji";
            this.roditeljiToolStripMenuItem.Click += new System.EventHandler(this.roditeljiToolStripMenuItem_Click);
            // 
            // decaToolStripMenuItem
            // 
            this.decaToolStripMenuItem.Name = "decaToolStripMenuItem";
            this.decaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.decaToolStripMenuItem.Text = "Deca";
            this.decaToolStripMenuItem.Click += new System.EventHandler(this.decaToolStripMenuItem_Click);
            // 
            // brojDeceToolStripMenuItem
            // 
            this.brojDeceToolStripMenuItem.Name = "brojDeceToolStripMenuItem";
            this.brojDeceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.brojDeceToolStripMenuItem.Text = "Broj dece";
            this.brojDeceToolStripMenuItem.Click += new System.EventHandler(this.brojDeceToolStripMenuItem_Click);
            // 
            // uzrastDeceToolStripMenuItem
            // 
            this.uzrastDeceToolStripMenuItem.Name = "uzrastDeceToolStripMenuItem";
            this.uzrastDeceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.uzrastDeceToolStripMenuItem.Text = "Uzrast dece";
            this.uzrastDeceToolStripMenuItem.Click += new System.EventHandler(this.uzrastDeceToolStripMenuItem_Click);
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
            this.Text = "Dnevni boravak";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roditeljiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spiskoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brojDeceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uzrastDeceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}

