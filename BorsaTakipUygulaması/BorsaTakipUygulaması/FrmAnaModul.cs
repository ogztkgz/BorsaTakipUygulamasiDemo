using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BorsaTakipUygulaması
{
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }

        FrmPersoneller frm1;
        FrmMusteriler frm2;
        FrmDanisman frm3;
        FrmHesaplar frm4;
        FrmAnaSayfa frm5;
        
        
        private void btnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frm1 == null || frm1.IsDisposed) {
                frm1 = new FrmPersoneller();
                frm1.MdiParent = this;
                frm1.Show();
                }
        }

        private void btnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new FrmMusteriler();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new FrmDanisman();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new FrmHesaplar();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }

        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new FrmAnaSayfa();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }

        private void FrmAnaModul_Load(object sender, EventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new FrmAnaSayfa();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }
    }
}
