namespace YazilimSinamaProje.Formlar
{
    partial class frmRaporListeleme
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
            this.yazilim_sinama_projesiDataSet5 = new YazilimSinamaProje.yazilim_sinama_projesiDataSet5();
            this.raporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raporTableAdapter = new YazilimSinamaProje.yazilim_sinama_projesiDataSet5TableAdapters.raporTableAdapter();
            this.raporIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilim_sinama_projesiDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raporIDDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.kullaniciIDDataGridViewTextBoxColumn,
            this.urunIDDataGridViewTextBoxColumn,
            this.bolumIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.raporBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(545, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // yazilim_sinama_projesiDataSet5
            // 
            this.yazilim_sinama_projesiDataSet5.DataSetName = "yazilim_sinama_projesiDataSet5";
            this.yazilim_sinama_projesiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raporBindingSource
            // 
            this.raporBindingSource.DataMember = "rapor";
            this.raporBindingSource.DataSource = this.yazilim_sinama_projesiDataSet5;
            // 
            // raporTableAdapter
            // 
            this.raporTableAdapter.ClearBeforeFill = true;
            // 
            // raporIDDataGridViewTextBoxColumn
            // 
            this.raporIDDataGridViewTextBoxColumn.DataPropertyName = "raporID";
            this.raporIDDataGridViewTextBoxColumn.HeaderText = "raporID";
            this.raporIDDataGridViewTextBoxColumn.Name = "raporIDDataGridViewTextBoxColumn";
            this.raporIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
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
            // bolumIDDataGridViewTextBoxColumn
            // 
            this.bolumIDDataGridViewTextBoxColumn.DataPropertyName = "bolumID";
            this.bolumIDDataGridViewTextBoxColumn.HeaderText = "bolumID";
            this.bolumIDDataGridViewTextBoxColumn.Name = "bolumIDDataGridViewTextBoxColumn";
            // 
            // frmRaporListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 300);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmRaporListeleme";
            this.Text = "RaporListeleme";
            this.Load += new System.EventHandler(this.RaporListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilim_sinama_projesiDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private yazilim_sinama_projesiDataSet5 yazilim_sinama_projesiDataSet5;
        private System.Windows.Forms.BindingSource raporBindingSource;
        private yazilim_sinama_projesiDataSet5TableAdapters.raporTableAdapter raporTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn raporIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIDDataGridViewTextBoxColumn;
    }
}