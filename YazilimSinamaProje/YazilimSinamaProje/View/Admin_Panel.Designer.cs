namespace YazilimSinamaProje
{
    partial class frmAdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPanel));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullaniciEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullaniciListeleme = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunListeleme = new DevExpress.XtraBars.BarButtonItem();
            this.btnZimmetEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnZimmetListeleme = new DevExpress.XtraBars.BarButtonItem();
            this.btnAtikListeleme = new DevExpress.XtraBars.BarButtonItem();
            this.btnRaporListeleme = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.btnKullaniciEkle,
            this.btnKullaniciListeleme,
            this.btnUrunEkle,
            this.btnUrunListeleme,
            this.btnZimmetEkle,
            this.btnZimmetListeleme,
            this.btnAtikListeleme,
            this.btnRaporListeleme});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(1081, 176);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Kullanıcı Ekle";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Caption = "Kullanıcı Ekle";
            this.btnKullaniciEkle.Id = 2;
            this.btnKullaniciEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciEkle.ImageOptions.Image")));
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKullaniciEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullaniciEkle_ItemClick);
            // 
            // btnKullaniciListeleme
            // 
            this.btnKullaniciListeleme.Caption = "Kullanıcı Düzenleme Ve Listeleme";
            this.btnKullaniciListeleme.Id = 3;
            this.btnKullaniciListeleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciListeleme.ImageOptions.Image")));
            this.btnKullaniciListeleme.Name = "btnKullaniciListeleme";
            this.btnKullaniciListeleme.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKullaniciListeleme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullaniciListeleme_ItemClick);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Caption = "Ürün Ekle";
            this.btnUrunEkle.Id = 4;
            this.btnUrunEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.ImageOptions.Image")));
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnUrunEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunEkle_ItemClick);
            // 
            // btnUrunListeleme
            // 
            this.btnUrunListeleme.Caption = "Ürünleri Listeleme Ve Düzenleme";
            this.btnUrunListeleme.Id = 5;
            this.btnUrunListeleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunListeleme.ImageOptions.Image")));
            this.btnUrunListeleme.Name = "btnUrunListeleme";
            this.btnUrunListeleme.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnUrunListeleme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunListeleme_ItemClick);
            // 
            // btnZimmetEkle
            // 
            this.btnZimmetEkle.Caption = "Zimmet Ekle";
            this.btnZimmetEkle.Id = 6;
            this.btnZimmetEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnZimmetEkle.ImageOptions.Image")));
            this.btnZimmetEkle.Name = "btnZimmetEkle";
            this.btnZimmetEkle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnZimmetEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnZimmetEkle_ItemClick);
            // 
            // btnZimmetListeleme
            // 
            this.btnZimmetListeleme.Caption = "Zimmet Listeleme Ve Düzenleme";
            this.btnZimmetListeleme.Id = 7;
            this.btnZimmetListeleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnZimmetListeleme.ImageOptions.Image")));
            this.btnZimmetListeleme.Name = "btnZimmetListeleme";
            this.btnZimmetListeleme.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnZimmetListeleme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnZimmetListeleme_ItemClick);
            // 
            // btnAtikListeleme
            // 
            this.btnAtikListeleme.Caption = "Atık Listeleme";
            this.btnAtikListeleme.Id = 8;
            this.btnAtikListeleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtikListeleme.ImageOptions.Image")));
            this.btnAtikListeleme.Name = "btnAtikListeleme";
            this.btnAtikListeleme.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAtikListeleme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAtikListeleme_ItemClick);
            // 
            // btnRaporListeleme
            // 
            this.btnRaporListeleme.Caption = "Rapor Listeleme";
            this.btnRaporListeleme.Id = 9;
            this.btnRaporListeleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporListeleme.ImageOptions.Image")));
            this.btnRaporListeleme.Name = "btnRaporListeleme";
            this.btnRaporListeleme.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnRaporListeleme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRaporListeleme_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Kullanıcı İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKullaniciEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKullaniciListeleme);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Ürün İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUrunEkle);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUrunListeleme);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Zimmet İşlemleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnZimmetEkle);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnZimmetListeleme);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Atık-Rapor";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnAtikListeleme);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnRaporListeleme);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 573);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmAdminPanel";
            this.Text = "Admin_Panel";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciEkle;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciListeleme;
        private DevExpress.XtraBars.BarButtonItem btnUrunEkle;
        private DevExpress.XtraBars.BarButtonItem btnUrunListeleme;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnZimmetEkle;
        private DevExpress.XtraBars.BarButtonItem btnZimmetListeleme;
        private DevExpress.XtraBars.BarButtonItem btnAtikListeleme;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnRaporListeleme;
    }
}

