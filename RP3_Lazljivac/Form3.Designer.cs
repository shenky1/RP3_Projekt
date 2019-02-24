namespace RP3_Lazljivac
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.igraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lazljivacDataSet1 = new RP3_Lazljivac.LazljivacDataSet();
            this.lazljivacDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lazljivacDataSet = new RP3_Lazljivac.LazljivacDataSet();
            this.igraTableAdapter = new RP3_Lazljivac.LazljivacDataSetTableAdapters.IgraTableAdapter();
            this.trajanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pobjednikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lazljivacDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lazljivacDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lazljivacDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trajanjeDataGridViewTextBoxColumn,
            this.pobjednikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.igraBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(437, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // igraBindingSource
            // 
            this.igraBindingSource.DataMember = "Igra";
            this.igraBindingSource.DataSource = this.lazljivacDataSetBindingSource;
            // 
            // igraBindingSource1
            // 
            this.igraBindingSource1.DataMember = "Igra";
            this.igraBindingSource1.DataSource = this.lazljivacDataSet1;
            // 
            // lazljivacDataSet1
            // 
            this.lazljivacDataSet1.DataSetName = "LazljivacDataSet";
            this.lazljivacDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lazljivacDataSetBindingSource
            // 
            this.lazljivacDataSetBindingSource.DataSource = this.lazljivacDataSet;
            this.lazljivacDataSetBindingSource.Position = 0;
            // 
            // lazljivacDataSet
            // 
            this.lazljivacDataSet.DataSetName = "LazljivacDataSet";
            this.lazljivacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // igraTableAdapter
            // 
            this.igraTableAdapter.ClearBeforeFill = true;
            // 
            // trajanjeDataGridViewTextBoxColumn
            // 
            this.trajanjeDataGridViewTextBoxColumn.DataPropertyName = "Trajanje";
            this.trajanjeDataGridViewTextBoxColumn.HeaderText = "Trajanje";
            this.trajanjeDataGridViewTextBoxColumn.Name = "trajanjeDataGridViewTextBoxColumn";
            this.trajanjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pobjednikDataGridViewTextBoxColumn
            // 
            this.pobjednikDataGridViewTextBoxColumn.DataPropertyName = "Pobjednik";
            this.pobjednikDataGridViewTextBoxColumn.HeaderText = "Pobjednik";
            this.pobjednikDataGridViewTextBoxColumn.Name = "pobjednikDataGridViewTextBoxColumn";
            this.pobjednikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 291);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lazljivacDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lazljivacDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lazljivacDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lazljivacDataSetBindingSource;
        private LazljivacDataSet lazljivacDataSet;
        private System.Windows.Forms.BindingSource igraBindingSource;
        private LazljivacDataSetTableAdapters.IgraTableAdapter igraTableAdapter;
        private System.Windows.Forms.BindingSource igraBindingSource1;
        private LazljivacDataSet lazljivacDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pobjednikDataGridViewTextBoxColumn;
    }
}