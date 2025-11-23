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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select hesapId,personelSıfre from personelHesap where hesapId=@p1 and personelSıfre=@p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciID.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaModul frm1 = new FrmAnaModul();
                frm1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı veya Şifre");
                txtKullaniciID.Text = "";
                txtSifre.Text = "";


            }
            bgl.baglanti().Close();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select hesapId,personelSıfre from personelHesap where hesapId=@p1 and personelSıfre=@p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciID.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmPersonelAnaModul frm2 = new FrmPersonelAnaModul();
                frm2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı veya Şifre");
                txtKullaniciID.Text = "";
                txtSifre.Text = "";


            }
            bgl.baglanti().Close();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select musteriHesapId,musteriSıfre from musteriHesap where musteriHesapId=@p1 and musteriSıfre=@p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciID.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmMusteriAnaModul frm3 = new FrmMusteriAnaModul();
                frm3.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı veya Şifre");
                txtKullaniciID.Text = "";
                txtSifre.Text = "";


            }
            bgl.baglanti().Close();
        }
    }
    }


  

