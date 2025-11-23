namespace BorsaTakipUygulaması
{
    partial class FrmPersonelAnaModul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelAnaModul));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAnaSayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.btnPortfoyler = new DevExpress.XtraBars.BarButtonItem();
            this.btnPiyasalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnHaberler = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.xtraTabbedMdiManager2 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnAnaSayfa,
            this.btnMusteriler,
            this.btnPortfoyler,
            this.btnPiyasalar,
            this.btnHaberler,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(984, 150);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Caption = "Ana Sayfa";
            this.btnAnaSayfa.Id = 1;
            this.btnAnaSayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.Image")));
            this.btnAnaSayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.LargeImage")));
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Caption = "Müşteriler";
            this.btnMusteriler.Id = 3;
            this.btnMusteriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriler.ImageOptions.Image")));
            this.btnMusteriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriler.ImageOptions.LargeImage")));
            this.btnMusteriler.Name = "btnMusteriler";
            // 
            // btnPortfoyler
            // 
            this.btnPortfoyler.Caption = "Portföyler";
            this.btnPortfoyler.Id = 4;
            this.btnPortfoyler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPortfoyler.ImageOptions.Image")));
            this.btnPortfoyler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPortfoyler.ImageOptions.LargeImage")));
            this.btnPortfoyler.Name = "btnPortfoyler";
            // 
            // btnPiyasalar
            // 
            this.btnPiyasalar.Caption = "Piyasalar";
            this.btnPiyasalar.Id = 5;
            this.btnPiyasalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPiyasalar.ImageOptions.Image")));
            this.btnPiyasalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPiyasalar.ImageOptions.LargeImage")));
            this.btnPiyasalar.Name = "btnPiyasalar";
            // 
            // btnHaberler
            // 
            this.btnHaberler.Caption = "Haberler";
            this.btnHaberler.Id = 7;
            this.btnHaberler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHaberler.ImageOptions.Image")));
            this.btnHaberler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHaberler.ImageOptions.LargeImage")));
            this.btnHaberler.Name = "btnHaberler";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Danışman";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Borsa Yönetim Sistemi";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAnaSayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteriler);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPortfoyler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPiyasalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHaberler);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = null;
            // 
            // xtraTabbedMdiManager2
            // 
            this.xtraTabbedMdiManager2.MdiParent = this;
            // 
            // FrmPersonelAnaModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmPersonelAnaModul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonelAnaModul";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnAnaSayfa;
        private DevExpress.XtraBars.BarButtonItem btnMusteriler;
        private DevExpress.XtraBars.BarButtonItem btnPortfoyler;
        private DevExpress.XtraBars.BarButtonItem btnPiyasalar;
        private DevExpress.XtraBars.BarButtonItem btnHaberler;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager2;
    }
}