namespace B5_6
{
    partial class Spisak
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.p_djordjevicE34DataSet = new B5_6.p_djordjevicE34DataSet();
            this.gradBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradTableAdapter = new B5_6.p_djordjevicE34DataSetTableAdapters.GradTableAdapter();
            this.p_djordjevicE34DataSet1 = new B5_6.p_djordjevicE34DataSet1();
            this.gradBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gradTableAdapter1 = new B5_6.p_djordjevicE34DataSet1TableAdapters.GradTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.p_djordjevicE34DataSet2 = new B5_6.p_djordjevicE34DataSet2();
            this.gradBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gradTableAdapter2 = new B5_6.p_djordjevicE34DataSet2TableAdapters.GradTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.p_djordjevicE34DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_djordjevicE34DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_djordjevicE34DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pozicija";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.gradBindingSource2;
            this.comboBox1.DisplayMember = "Grad";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "GradID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            // 
            // p_djordjevicE34DataSet
            // 
            this.p_djordjevicE34DataSet.DataSetName = "p_djordjevicE34DataSet";
            this.p_djordjevicE34DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradBindingSource
            // 
            this.gradBindingSource.DataMember = "Grad";
            this.gradBindingSource.DataSource = this.p_djordjevicE34DataSet;
            // 
            // gradTableAdapter
            // 
            this.gradTableAdapter.ClearBeforeFill = true;
            // 
            // p_djordjevicE34DataSet1
            // 
            this.p_djordjevicE34DataSet1.DataSetName = "p_djordjevicE34DataSet1";
            this.p_djordjevicE34DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradBindingSource1
            // 
            this.gradBindingSource1.DataMember = "Grad";
            this.gradBindingSource1.DataSource = this.p_djordjevicE34DataSet1;
            // 
            // gradTableAdapter1
            // 
            this.gradTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Prikazi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Izadji";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(326, 171);
            this.dataGridView1.TabIndex = 6;
            // 
            // p_djordjevicE34DataSet2
            // 
            this.p_djordjevicE34DataSet2.DataSetName = "p_djordjevicE34DataSet2";
            this.p_djordjevicE34DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradBindingSource2
            // 
            this.gradBindingSource2.DataMember = "Grad";
            this.gradBindingSource2.DataSource = this.p_djordjevicE34DataSet2;
            // 
            // gradTableAdapter2
            // 
            this.gradTableAdapter2.ClearBeforeFill = true;
            // 
            // Spisak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Spisak";
            this.Text = "Spisak";
            this.Load += new System.EventHandler(this.Spisak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_djordjevicE34DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_djordjevicE34DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_djordjevicE34DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private p_djordjevicE34DataSet p_djordjevicE34DataSet;
        private System.Windows.Forms.BindingSource gradBindingSource;
        private p_djordjevicE34DataSetTableAdapters.GradTableAdapter gradTableAdapter;
        private p_djordjevicE34DataSet1 p_djordjevicE34DataSet1;
        private System.Windows.Forms.BindingSource gradBindingSource1;
        private p_djordjevicE34DataSet1TableAdapters.GradTableAdapter gradTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private p_djordjevicE34DataSet2 p_djordjevicE34DataSet2;
        private System.Windows.Forms.BindingSource gradBindingSource2;
        private p_djordjevicE34DataSet2TableAdapters.GradTableAdapter gradTableAdapter2;
    }
}