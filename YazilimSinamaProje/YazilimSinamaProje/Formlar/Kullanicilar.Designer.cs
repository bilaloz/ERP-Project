namespace YazilimSinamaProje.Model.Formlar
{
    partial class frmKullanicilar
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
            this.yazilim_sinama_projesiDataSet = new YazilimSinamaProje.yazilim_sinama_projesiDataSet();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciTableAdapter = new YazilimSinamaProje.yazilim_sinama_projesiDataSetTableAdapters.kullaniciTableAdapter();
            this.kullaniciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilim_sinama_projesiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciIDDataGridViewTextBoxColumn,
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.kullaniciSifreDataGridViewTextBoxColumn,
            this.kullaniciTipiDataGridViewTextBoxColumn,
            this.bolumIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kullaniciBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(540, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yazilim_sinama_projesiDataSet
            // 
            this.yazilim_sinama_projesiDataSet.DataSetName = "yazilim_sinama_projesiDataSet";
            this.yazilim_sinama_projesiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "kullanici";
            this.kullaniciBindingSource.DataSource = this.yazilim_sinama_projesiDataSet;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // kullaniciIDDataGridViewTextBoxColumn
            // 
            this.kullaniciIDDataGridViewTextBoxColumn.DataPropertyName = "kullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.HeaderText = "kullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.Name = "kullaniciIDDataGridViewTextBoxColumn";
            this.kullaniciIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "kullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "kullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            // 
            // kullaniciSifreDataGridViewTextBoxColumn
            // 
            this.kullaniciSifreDataGridViewTextBoxColumn.DataPropertyName = "kullaniciSifre";
            this.kullaniciSifreDataGridViewTextBoxColumn.HeaderText = "kullaniciSifre";
            this.kullaniciSifreDataGridViewTextBoxColumn.Name = "kullaniciSifreDataGridViewTextBoxColumn";
            // 
            // kullaniciTipiDataGridViewTextBoxColumn
            // 
            this.kullaniciTipiDataGridViewTextBoxColumn.DataPropertyName = "kullaniciTipi";
            this.kullaniciTipiDataGridViewTextBoxColumn.HeaderText = "kullaniciTipi";
            this.kullaniciTipiDataGridViewTextBoxColumn.Name = "kullaniciTipiDataGridViewTextBoxColumn";
            // 
            // bolumIDDataGridViewTextBoxColumn
            // 
            this.bolumIDDataGridViewTextBoxColumn.DataPropertyName = "bolumID";
            this.bolumIDDataGridViewTextBoxColumn.HeaderText = "bolumID";
            this.bolumIDDataGridViewTextBoxColumn.Name = "bolumIDDataGridViewTextBoxColumn";
            // 
            // frmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKullanicilar";
            this.Text = "Kullanicilar";
            this.Load += new System.EventHandler(this.frmKullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilim_sinama_projesiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private yazilim_sinama_projesiDataSet yazilim_sinama_projesiDataSet;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private yazilim_sinama_projesiDataSetTableAdapters.kullaniciTableAdapter kullaniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIDDataGridViewTextBoxColumn;
    }
}