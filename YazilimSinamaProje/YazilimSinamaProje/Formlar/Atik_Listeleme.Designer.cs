namespace YazilimSinamaProje.Formlar
{
    partial class frmAtikListeleme
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
            this.yazilim_sinama_projesiDataSet4 = new YazilimSinamaProje.yazilim_sinama_projesiDataSet4();
            this.atikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atikTableAdapter = new YazilimSinamaProje.yazilim_sinama_projesiDataSet4TableAdapters.atikTableAdapter();
            this.atikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atikAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilim_sinama_projesiDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.atikIDDataGridViewTextBoxColumn,
            this.atikAdiDataGridViewTextBoxColumn,
            this.urunIDDataGridViewTextBoxColumn,
            this.kullaniciIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.atikBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(444, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // yazilim_sinama_projesiDataSet4
            // 
            this.yazilim_sinama_projesiDataSet4.DataSetName = "yazilim_sinama_projesiDataSet4";
            this.yazilim_sinama_projesiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atikBindingSource
            // 
            this.atikBindingSource.DataMember = "atik";
            this.atikBindingSource.DataSource = this.yazilim_sinama_projesiDataSet4;
            // 
            // atikTableAdapter
            // 
            this.atikTableAdapter.ClearBeforeFill = true;
            // 
            // atikIDDataGridViewTextBoxColumn
            // 
            this.atikIDDataGridViewTextBoxColumn.DataPropertyName = "atikID";
            this.atikIDDataGridViewTextBoxColumn.HeaderText = "atikID";
            this.atikIDDataGridViewTextBoxColumn.Name = "atikIDDataGridViewTextBoxColumn";
            this.atikIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // atikAdiDataGridViewTextBoxColumn
            // 
            this.atikAdiDataGridViewTextBoxColumn.DataPropertyName = "atikAdi";
            this.atikAdiDataGridViewTextBoxColumn.HeaderText = "atikAdi";
            this.atikAdiDataGridViewTextBoxColumn.Name = "atikAdiDataGridViewTextBoxColumn";
            // 
            // urunIDDataGridViewTextBoxColumn
            // 
            this.urunIDDataGridViewTextBoxColumn.DataPropertyName = "urunID";
            this.urunIDDataGridViewTextBoxColumn.HeaderText = "urunID";
            this.urunIDDataGridViewTextBoxColumn.Name = "urunIDDataGridViewTextBoxColumn";
            // 
            // kullaniciIDDataGridViewTextBoxColumn
            // 
            this.kullaniciIDDataGridViewTextBoxColumn.DataPropertyName = "kullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.HeaderText = "kullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.Name = "kullaniciIDDataGridViewTextBoxColumn";
            // 
            // frmAtikListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 281);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAtikListeleme";
            this.Text = "Atik_Listeleme";
            this.Load += new System.EventHandler(this.frmAtikListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilim_sinama_projesiDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private yazilim_sinama_projesiDataSet4 yazilim_sinama_projesiDataSet4;
        private System.Windows.Forms.BindingSource atikBindingSource;
        private yazilim_sinama_projesiDataSet4TableAdapters.atikTableAdapter atikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn atikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atikAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIDDataGridViewTextBoxColumn;
    }
}