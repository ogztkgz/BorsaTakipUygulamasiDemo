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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select hisseKısaAd,hisseDeger from hisseler", bgl.baglanti());
            da1.Fill(dt1);
            gridControl1.DataSource = dt1;

        }
        

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            listele();
            
        }

        
    }
}
