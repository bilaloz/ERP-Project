namespace YazilimSinamaProje.View
{
    partial class frmYetkiliPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYetkiliPanel));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnZimmetEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnZimmetListeleme = new DevExpress.XtraBars.BarButtonItem();
            this.btnRaporListeleme = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.btnZimmetEkle,
            this.btnZimmetListeleme,
            this.btnRaporListeleme});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1051, 176);
            // 
            // btnZimmetEkle
            // 
            this.btnZimmetEkle.Caption = "Zimmet Ekle";
            this.btnZimmetEkle.Id = 1;
            this.btnZimmetEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnZimmetEkle.ImageOptions.Image")));
            this.btnZimmetEkle.Name = "btnZimmetEkle";
            this.btnZimmetEkle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnZimmetEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnZimmetEkle_ItemClick);
            // 
            // btnZimmetListeleme
            // 
            this.btnZimmetListeleme.Caption = "Zimmet Listeleme Ve Düzenleme";
            this.btnZimmetListeleme.Id = 2;
            this.btnZimmetListeleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnZimmetListeleme.ImageOptions.Image")));
            this.btnZimmetListeleme.Name = "btnZimmetListeleme";
            this.btnZimmetListeleme.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnZimmetListeleme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnZimmetListeleme_ItemClick);
            // 
            // btnRaporListeleme
            // 
            this.btnRaporListeleme.Caption = "Rapor Listeleme";
            this.btnRaporListeleme.Id = 3;
            this.btnRaporListeleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporListeleme.ImageOptions.Image")));
            this.btnRaporListeleme.Name = "btnRaporListeleme";
            this.btnRaporListeleme.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Zimmet İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnZimmetEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnZimmetListeleme);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Rapor İşlemeleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnRaporListeleme);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmYetkiliPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 566);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmYetkiliPanel";
            this.Text = "Yetkili_Panel";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnZimmetEkle;
        private DevExpress.XtraBars.BarButtonItem btnZimmetListeleme;
        private DevExpress.XtraBars.BarButtonItem btnRaporListeleme;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}