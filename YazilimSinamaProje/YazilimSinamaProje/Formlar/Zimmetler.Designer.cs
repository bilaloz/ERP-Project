namespace YazilimSinamaProje.Formlar
{
    partial class frmZimmetler
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
            this.yazilim_sinama_projesiDataSet3 = new YazilimSinamaProje.yazilim_sinama_projesiDataSet3();
            this.zimmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zimmetTableAdapter = new YazilimSinamaProje.yazilim_sinama_projesiDataSet3TableAdapters.zimmetTableAdapter();
            this.zimmetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zimmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilim_sinama_projesiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zimmetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zimmetIDDataGridViewTextBoxColumn,
            this.zimmetDataGridViewTextBoxColumn,
            this.kullaniciIDDataGridViewTextBoxColumn,
            this.urunIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zimmetBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(442, 307);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yazilim_sinama_projesiDataSet3
            // 
            this.yazilim_sinama_projesiDataSet3.DataSetName = "yazilim_sinama_projesiDataSet3";
            this.yazilim_sinama_projesiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zimmetBindingSource
            // 
            this.zimmetBindingSource.DataMember = "zimmet";
            this.zimmetBindingSource.DataSource = this.yazilim_sinama_projesiDataSet3;
            // 
            // zimmetTableAdapter
            // 
            this.zimmetTableAdapter.ClearBeforeFill = true;
            // 
            // zimmetIDDataGridViewTextBoxColumn
            // 
            this.zimmetIDDataGridViewTextBoxColumn.DataPropertyName = "zimmetID";
            this.zimmetIDDataGridViewTextBoxColumn.HeaderText = "zimmetID";
            this.zimmetIDDataGridViewTextBoxColumn.Name = "zimmetIDDataGridViewTextBoxColumn";
            this.zimmetIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zimmetDataGridViewTextBoxColumn
            // 
            this.zimmetDataGridViewTextBoxColumn.DataPropertyName = "zimmet";
            this.zimmetDataGridViewTextBoxColumn.HeaderText = "zimmet";
            this.zimmetDataGridViewTextBoxColumn.Name = "zimmetDataGridViewTextBoxColumn";
            // 
            // kullaniciIDDataGridViewTextBoxColumn
            // 
            this.kullaniciIDDataGridViewTextBoxColumn.DataPropertyName = "kullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.HeaderText = "kullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.Name = "kullaniciIDDataGridViewTextBoxColumn";
            // 
            // urunIDDataGridViewTextBoxColumn
            // 
            this.urunIDDataGridViewTextBoxColumn.DataPropertyName = "urunID";
            this.urunIDDataGridViewTextBoxColumn.HeaderText = "urunID";
            this.urunIDDataGridViewTextBoxColumn.Name = "urunIDDataGridViewTextBoxColumn";
            // 
            // frmZimmetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 307);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmZimmetler";
            this.Text = "Zimmetler";
            this.Load += new System.EventHandler(this.Zimmetler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilim_sinama_projesiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zimmetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private yazilim_sinama_projesiDataSet3 yazilim_sinama_projesiDataSet3;
        private System.Windows.Forms.BindingSource zimmetBindingSource;
        private yazilim_sinama_projesiDataSet3TableAdapters.zimmetTableAdapter zimmetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn zimmetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zimmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
    }
}