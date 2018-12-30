namespace YazilimSinamaProje.Model.Formlar
{
    partial class frmUrunDuzenle
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
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.dtSatinAlmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbUrunTipi = new System.Windows.Forms.ComboBox();
            this.txtUrunFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtSatinAlinanFirma = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunAdedi = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUrunID = new System.Windows.Forms.Label();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatinAlinanFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdedi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(197, 263);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(94, 29);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dtSatinAlmaTarihi
            // 
            this.dtSatinAlmaTarihi.Location = new System.Drawing.Point(197, 182);
            this.dtSatinAlmaTarihi.MaxDate = new System.DateTime(2018, 12, 27, 0, 0, 0, 0);
            this.dtSatinAlmaTarihi.Name = "dtSatinAlmaTarihi";
            this.dtSatinAlmaTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtSatinAlmaTarihi.TabIndex = 4;
            this.dtSatinAlmaTarihi.Value = new System.DateTime(2018, 12, 27, 0, 0, 0, 0);
            // 
            // cmbUrunTipi
            // 
            this.cmbUrunTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunTipi.FormattingEnabled = true;
            this.cmbUrunTipi.Items.AddRange(new object[] {
            "HAZIR PC",
            "PARÇA"});
            this.cmbUrunTipi.Location = new System.Drawing.Point(197, 153);
            this.cmbUrunTipi.Name = "cmbUrunTipi";
            this.cmbUrunTipi.Size = new System.Drawing.Size(121, 24);
            this.cmbUrunTipi.TabIndex = 3;
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(197, 216);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Properties.MaxLength = 10;
            this.txtUrunFiyat.Size = new System.Drawing.Size(125, 22);
            this.txtUrunFiyat.TabIndex = 5;
            this.txtUrunFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunFiyat_KeyPress);
            // 
            // txtSatinAlinanFirma
            // 
            this.txtSatinAlinanFirma.Location = new System.Drawing.Point(197, 121);
            this.txtSatinAlinanFirma.Name = "txtSatinAlinanFirma";
            this.txtSatinAlinanFirma.Properties.MaxLength = 10;
            this.txtSatinAlinanFirma.Size = new System.Drawing.Size(125, 22);
            this.txtSatinAlinanFirma.TabIndex = 2;
            this.txtSatinAlinanFirma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatinAlinanFirma_KeyPress);
            // 
            // txtUrunAdedi
            // 
            this.txtUrunAdedi.Location = new System.Drawing.Point(197, 93);
            this.txtUrunAdedi.Name = "txtUrunAdedi";
            this.txtUrunAdedi.Properties.MaxLength = 10;
            this.txtUrunAdedi.Size = new System.Drawing.Size(125, 22);
            this.txtUrunAdedi.TabIndex = 1;
            this.txtUrunAdedi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAdedi_KeyPress);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(197, 65);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Properties.MaxLength = 10;
            this.txtUrunAdi.Size = new System.Drawing.Size(125, 22);
            this.txtUrunAdi.TabIndex = 0;
            this.txtUrunAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAdi_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ürün Fiyat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Satın Alma Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün Tipi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Satin Alınan Firma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adedi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ürün ID:";
            // 
            // lblUrunID
            // 
            this.lblUrunID.AutoSize = true;
            this.lblUrunID.Location = new System.Drawing.Point(194, 36);
            this.lblUrunID.Name = "lblUrunID";
            this.lblUrunID.Size = new System.Drawing.Size(68, 17);
            this.lblUrunID.TabIndex = 0;
            this.lblUrunID.Text = "Bilinmiyor";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(303, 263);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 29);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmUrunDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 304);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
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
            this.Controls.Add(this.lblUrunID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "frmUrunDuzenle";
            this.Text = "UrunDuzenle";
            this.Load += new System.EventHandler(this.frmUrunDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatinAlinanFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdedi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private System.Windows.Forms.DateTimePicker dtSatinAlmaTarihi;
        private System.Windows.Forms.ComboBox cmbUrunTipi;
        private DevExpress.XtraEditors.TextEdit txtUrunFiyat;
        private DevExpress.XtraEditors.TextEdit txtSatinAlinanFirma;
        private DevExpress.XtraEditors.TextEdit txtUrunAdedi;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUrunID;
        private DevExpress.XtraEditors.SimpleButton btnSil;
    }
}