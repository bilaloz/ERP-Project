namespace YazilimSinamaProje.Model.Formlar
{
    partial class frmUrunler
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
            this.yazilim_sinama_projesiDataSet1 = new YazilimSinamaProje.yazilim_sinama_projesiDataSet1();
            this.urunSatinAlmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunSatinAlmaTableAdapter = new YazilimSinamaProje.yazilim_sinama_projesiDataSet1TableAdapters.urunSatinAlmaTableAdapter();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satinAlinanFirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satinAlmaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunToptanFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilim_sinama_projesiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunSatinAlmaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIDDataGridViewTextBoxColumn,
            this.urunAdDataGridViewTextBoxColumn,
            this.urunAdediDataGridViewTextBoxColumn,
            this.satinAlinanFirmaDataGridViewTextBoxColumn,
            this.urunTipiDataGridViewTextBoxColumn,
            this.satinAlmaTarihiDataGridViewTextBoxColumn,
            this.urunFiyatDataGridViewTextBoxColumn,
            this.urunToptanFiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunSatinAlmaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(844, 357);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yazilim_sinama_projesiDataSet1
            // 
            this.yazilim_sinama_projesiDataSet1.DataSetName = "yazilim_sinama_projesiDataSet1";
            this.yazilim_sinama_projesiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunSatinAlmaBindingSource
            // 
            this.urunSatinAlmaBindingSource.DataMember = "urunSatinAlma";
            this.urunSatinAlmaBindingSource.DataSource = this.yazilim_sinama_projesiDataSet1;
            // 
            // urunSatinAlmaTableAdapter
            // 
            this.urunSatinAlmaTableAdapter.ClearBeforeFill = true;
            // 
            // urunIDDataGridViewTextBoxColumn
            // 
            this.urunIDDataGridViewTextBoxColumn.DataPropertyName = "urunID";
            this.urunIDDataGridViewTextBoxColumn.HeaderText = "urunID";
            this.urunIDDataGridViewTextBoxColumn.Name = "urunIDDataGridViewTextBoxColumn";
            this.urunIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunAdDataGridViewTextBoxColumn
            // 
            this.urunAdDataGridViewTextBoxColumn.DataPropertyName = "urunAd";
            this.urunAdDataGridViewTextBoxColumn.HeaderText = "urunAd";
            this.urunAdDataGridViewTextBoxColumn.Name = "urunAdDataGridViewTextBoxColumn";
            // 
            // urunAdediDataGridViewTextBoxColumn
            // 
            this.urunAdediDataGridViewTextBoxColumn.DataPropertyName = "urunAdedi";
            this.urunAdediDataGridViewTextBoxColumn.HeaderText = "urunAdedi";
            this.urunAdediDataGridViewTextBoxColumn.Name = "urunAdediDataGridViewTextBoxColumn";
            // 
            // satinAlinanFirmaDataGridViewTextBoxColumn
            // 
            this.satinAlinanFirmaDataGridViewTextBoxColumn.DataPropertyName = "satinAlinanFirma";
            this.satinAlinanFirmaDataGridViewTextBoxColumn.HeaderText = "satinAlinanFirma";
            this.satinAlinanFirmaDataGridViewTextBoxColumn.Name = "satinAlinanFirmaDataGridViewTextBoxColumn";
            // 
            // urunTipiDataGridViewTextBoxColumn
            // 
            this.urunTipiDataGridViewTextBoxColumn.DataPropertyName = "urunTipi";
            this.urunTipiDataGridViewTextBoxColumn.HeaderText = "urunTipi";
            this.urunTipiDataGridViewTextBoxColumn.Name = "urunTipiDataGridViewTextBoxColumn";
            // 
            // satinAlmaTarihiDataGridViewTextBoxColumn
            // 
            this.satinAlmaTarihiDataGridViewTextBoxColumn.DataPropertyName = "satinAlmaTarihi";
            this.satinAlmaTarihiDataGridViewTextBoxColumn.HeaderText = "satinAlmaTarihi";
            this.satinAlmaTarihiDataGridViewTextBoxColumn.Name = "satinAlmaTarihiDataGridViewTextBoxColumn";
            // 
            // urunFiyatDataGridViewTextBoxColumn
            // 
            this.urunFiyatDataGridViewTextBoxColumn.DataPropertyName = "urunFiyat";
            this.urunFiyatDataGridViewTextBoxColumn.HeaderText = "urunFiyat";
            this.urunFiyatDataGridViewTextBoxColumn.Name = "urunFiyatDataGridViewTextBoxColumn";
            // 
            // urunToptanFiyatDataGridViewTextBoxColumn
            // 
            this.urunToptanFiyatDataGridViewTextBoxColumn.DataPropertyName = "urunToptanFiyat";
            this.urunToptanFiyatDataGridViewTextBoxColumn.HeaderText = "urunToptanFiyat";
            this.urunToptanFiyatDataGridViewTextBoxColumn.Name = "urunToptanFiyatDataGridViewTextBoxColumn";
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 357);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUrunler";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.frmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilim_sinama_projesiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunSatinAlmaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private yazilim_sinama_projesiDataSet1 yazilim_sinama_projesiDataSet1;
        private System.Windows.Forms.BindingSource urunSatinAlmaBindingSource;
        private yazilim_sinama_projesiDataSet1TableAdapters.urunSatinAlmaTableAdapter urunSatinAlmaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satinAlinanFirmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satinAlmaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunToptanFiyatDataGridViewTextBoxColumn;
    }
}