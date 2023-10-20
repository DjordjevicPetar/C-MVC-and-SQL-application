namespace B1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.prijavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prijavaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izlozbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prijavaPasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spisakPasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijavaToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(123, 28);
            // 
            // prijavaToolStripMenuItem
            // 
            this.prijavaToolStripMenuItem.Name = "prijavaToolStripMenuItem";
            this.prijavaToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.prijavaToolStripMenuItem.Text = "Prijava";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijavaToolStripMenuItem1,
            this.izlozbaToolStripMenuItem,
            this.krajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prijavaToolStripMenuItem1
            // 
            this.prijavaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijavaPasaToolStripMenuItem,
            this.spisakPasaToolStripMenuItem});
            this.prijavaToolStripMenuItem1.Name = "prijavaToolStripMenuItem1";
            this.prijavaToolStripMenuItem1.Size = new System.Drawing.Size(67, 24);
            this.prijavaToolStripMenuItem1.Text = "Prijava";
            // 
            // izlozbaToolStripMenuItem
            // 
            this.izlozbaToolStripMenuItem.Name = "izlozbaToolStripMenuItem";
            this.izlozbaToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.izlozbaToolStripMenuItem.Text = "Izlozba";
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.krajToolStripMenuItem.Text = "Kraj";
            // 
            // prijavaPasaToolStripMenuItem
            // 
            this.prijavaPasaToolStripMenuItem.Name = "prijavaPasaToolStripMenuItem";
            this.prijavaPasaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.prijavaPasaToolStripMenuItem.Text = "Prijava pasa";
            this.prijavaPasaToolStripMenuItem.Click += new System.EventHandler(this.prijavaPasaToolStripMenuItem_Click);
            // 
            // spisakPasaToolStripMenuItem
            // 
            this.spisakPasaToolStripMenuItem.Name = "spisakPasaToolStripMenuItem";
            this.spisakPasaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.spisakPasaToolStripMenuItem.Text = "Spisak pasa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 356);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem prijavaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prijavaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prijavaPasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spisakPasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlozbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
    }
}

