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
    public partial class FrmHesaplar : Form
    {
        public FrmHesaplar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Execute personelsifrebilgi", bgl.baglanti());
            da1.Fill(dt1);
            gridControl1.DataSource = dt1;

        }
        void listele2()
        {
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Execute musterisifrebilgi", bgl.baglanti());
            da3.Fill(dt3);
            gridControl2.DataSource = dt3;

        }

        void personellistesi()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select personelId,(personelAd+' '+personelSoyad) as 'personelAdSoyad' , personelUnvan from personel ", bgl.baglanti());
            
            da2.Fill(dt2);
            lookUpEdit1.Properties.ValueMember = "personelId";
            lookUpEdit1.Properties.DisplayMember = "personelAdSoyad";
            lookUpEdit1.Properties.NullText = "Personel Seçiniz";
            lookUpEdit1.Properties.DataSource = dt2;


        }
        void musterilistesi()
        {
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Select musteriId,(musteriAd+' '+musteriSoyad) as 'musteriAdSoyad'  from musteriler ", bgl.baglanti());

            da4.Fill(dt4);
            lookUpEdit2.Properties.ValueMember = "musteriId";
            lookUpEdit2.Properties.DisplayMember = "musteriAdSoyad";
            lookUpEdit2.Properties.NullText = "Musteri Seçiniz";
            lookUpEdit2.Properties.DataSource = dt4;


        }




        private void FrmHesaplar_Load(object sender, EventArgs e)
        {
            listele();
            listele2(); 
            personellistesi();
            musterilistesi();
            temizle();
        }

        void temizle()
        {
            txtPersonelID.Text = "";
            lookUpEdit1.Text = "Personel Seçiniz";
            txtUnvan.Text = "";
            txtPersonelSifre.Text = "";
           
           
        }
        void temizle2()
        {
            txtMusteriID.Text = "";
            lookUpEdit2.Text = "Musteri Seçiniz";
            txtMusteriSifre.Text = "";


        }


        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {

                txtPersonelID.Text = dr["hesapId"].ToString();
                lookUpEdit1.Text = dr["personelAdSoyad"].ToString();
                txtUnvan.Text = dr["personelUnvan"].ToString();
                txtPersonelSifre.Text = dr["personelSıfre"].ToString();
                

            }
        }

        private void lookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            txtPersonelSifre.Text = "";
            SqlCommand komut = new SqlCommand("select * from personel where personelId=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lookUpEdit1.ItemIndex +1);
            SqlDataReader dr3 = komut.ExecuteReader();
            while (dr3.Read())
            {
                txtPersonelID.Text = dr3["personelId"].ToString();
                
                txtUnvan.Text = dr3["personelUnvan"].ToString();
                


            }
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into personelHesap (hesapId,personelSıfre) values (@p1,@p2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtPersonelID.Text);
            komut2.Parameters.AddWithValue("@p2", txtPersonelSifre.Text);
            
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Şifre Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Update personelHesap set personelSıfre=@p1 where hesapId=@p2", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", txtPersonelSifre.Text);
            komut3.Parameters.AddWithValue("@p2", txtPersonelID.Text);
            
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifre Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {

                txtMusteriID.Text = dr["musteriHesapId"].ToString();
                lookUpEdit2.Text = dr["musteriAdSoyad"].ToString();
                txtMusteriSifre.Text = dr["musteriSıfre"].ToString();


            }
        }

        private void lookUpEdit2_Properties_EditValueChanged(object sender, EventArgs e)
        {
            txtMusteriSifre.Text = "";
            SqlCommand komut = new SqlCommand("select * from musteriler where musteriId=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lookUpEdit2.ItemIndex + 1);
            SqlDataReader dr4 = komut.ExecuteReader();
            while (dr4.Read())
            {
                txtMusteriID.Text = dr4["musteriId"].ToString();

                
            }
            bgl.baglanti().Close();
        }

        private void btnKaydetMusteri_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("insert into musteriHesap (musteriHesapId,musteriSıfre) values (@p1,@p2)", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", txtMusteriID.Text);
            komut4.Parameters.AddWithValue("@p2", txtMusteriSifre.Text);

            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Şifre Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele2();
            temizle2();
        }

        private void btnGüncelleMusteri_Click(object sender, EventArgs e)
        {
            SqlCommand komut5 = new SqlCommand("Update musteriHesap set musteriSıfre=@p1 where musteriHesapId=@p2", bgl.baglanti());
            komut5.Parameters.AddWithValue("@p1", txtMusteriSifre.Text);
            komut5.Parameters.AddWithValue("@p2", txtMusteriID.Text);

            komut5.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifre Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele2();
            temizle2();
        }

        private void btnTemizleMusteri_Click(object sender, EventArgs e)
        {
            temizle2();
        }
    }
}
