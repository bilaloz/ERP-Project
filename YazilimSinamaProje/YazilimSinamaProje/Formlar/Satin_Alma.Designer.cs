namespace YazilimSinamaProje.Model.Formlar
{
    partial class frmSatinAlma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunAdedi = new DevExpress.XtraEditors.TextEdit();
            this.txtSatinAlinanFirma = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunFiyat = new DevExpress.XtraEditors.TextEdit();
            this.cmbUrunTipi = new System.Windows.Forms.ComboBox();
            this.dtSatinAlmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnSatinAl = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdedi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatinAlinanFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunFiyat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adedi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Satin Alınan Firma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün Tipi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Satın Alma Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ürün Fiyat:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(190, 38);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Properties.MaxLength = 10;
            this.txtUrunAdi.Size = new System.Drawing.Size(125, 22);
            this.txtUrunAdi.TabIndex = 0;
            this.txtUrunAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAdi_KeyPress);
            // 
            // txtUrunAdedi
            // 
            this.txtUrunAdedi.Location = new System.Drawing.Point(190, 66);
            this.txtUrunAdedi.Name = "txtUrunAdedi";
            this.txtUrunAdedi.Properties.MaxLength = 10;
            this.txtUrunAdedi.Size = new System.Drawing.Size(125, 22);
            this.txtUrunAdedi.TabIndex = 1;
            this.txtUrunAdedi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAdedi_KeyPress);
            // 
            // txtSatinAlinanFirma
            // 
            this.txtSatinAlinanFirma.Location = new System.Drawing.Point(190, 94);
            this.txtSatinAlinanFirma.Name = "txtSatinAlinanFirma";
            this.txtSatinAlinanFirma.Properties.MaxLength = 10;
            this.txtSatinAlinanFirma.Size = new System.Drawing.Size(125, 22);
            this.txtSatinAlinanFirma.TabIndex = 2;
            this.txtSatinAlinanFirma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatinAlinanFirma_KeyPress);
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(190, 189);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Properties.MaxLength = 10;
            this.txtUrunFiyat.Size = new System.Drawing.Size(125, 22);
            this.txtUrunFiyat.TabIndex = 5;
            this.txtUrunFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunFiyat_KeyPress);
            // 
            // cmbUrunTipi
            // 
            this.cmbUrunTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunTipi.FormattingEnabled = true;
            this.cmbUrunTipi.Items.AddRange(new object[] {
            "HAZIR PC",
            "PARÇA"});
            this.cmbUrunTipi.Location = new System.Drawing.Point(190, 126);
            this.cmbUrunTipi.Name = "cmbUrunTipi";
            this.cmbUrunTipi.Size = new System.Drawing.Size(121, 24);
            this.cmbUrunTipi.TabIndex = 3;
            // 
            // dtSatinAlmaTarihi
            // 
            this.dtSatinAlmaTarihi.Location = new System.Drawing.Point(190, 155);
            this.dtSatinAlmaTarihi.MaxDate = new System.DateTime(2018, 12, 27, 23, 59, 0, 0);
            this.dtSatinAlmaTarihi.Name = "dtSatinAlmaTarihi";
            this.dtSatinAlmaTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtSatinAlmaTarihi.TabIndex = 4;
            this.dtSatinAlmaTarihi.Value = new System.DateTime(2018, 12, 25, 23, 59, 59, 0);
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Location = new System.Drawing.Point(216, 235);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(94, 29);
            this.btnSatinAl.TabIndex = 6;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // frmSatinAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 276);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.dtSatinAlmaTarihi);
            this.Controls.Add(this.cmbUrunTipi);
            this.Controls.Add(this.txtUrunFiyat);
            this.Controls.Add(this.txtSatinAlinanFirma);
            this.Controls.Add(this.txtUrunAdedi);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSatinAlma";
            this.Text = "Satin_Alma";
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdedi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatinAlinanFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunFiyat.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraEditors.TextEdit txtUrunAdedi;
        private DevExpress.XtraEditors.TextEdit txtSatinAlinanFirma;
        private DevExpress.XtraEditors.TextEdit txtUrunFiyat;
        private System.Windows.Forms.ComboBox cmbUrunTipi;
        private System.Windows.Forms.DateTimePicker dtSatinAlmaTarihi;
        private DevExpress.XtraEditors.SimpleButton btnSatinAl;
    }
}