using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARAÇ_KİRALAMA_OTOMASYONU
{
    public partial class KayıtOl : Form
    {
       

        public KayıtOl()
        {
            InitializeComponent();
        }

        SqlConnection sqlbaglantı = new SqlConnection("Data Source=DESKTOP-ALJJK6S;Initial Catalog=VT_ARAÇ_KİRALAMA_OTOMASYONU;Integrated Security=True");
        private void btnkayıt_Click_1(object sender, EventArgs e)
        {
            if(txtKullanıcıAdı.Text==""|| txtŞifre.Text=="")
            {
                MessageBox.Show("LÜTFEN BOŞ ALANLARI DOLDURUNUZ");
            }   
            else
            {

            sqlbaglantı.Open();
            string kullanıcı;
            string sifre;
            kullanıcı = txtKullanıcıAdı.Text;
            sifre = txtŞifre.Text;

            SqlCommand kmt = new SqlCommand("select * from KullanıcıGiriş where Kullanıcı_Ad ='" + kullanıcı+ "'", sqlbaglantı);
            SqlDataReader read = kmt.ExecuteReader();
                if (read.Read())
                {
                    MessageBox.Show("LÜTFEN BAŞKA BİR KULLANICI ADI SEÇİN");
                }
                else
                {
                    read.Close();
                    SqlCommand ekle = new SqlCommand("insert into KullanıcıGiriş (Kullanıcı_Ad,Kullanıcı_Sifre) values ('"+kullanıcı+"','"+sifre+"')",sqlbaglantı);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("KAYIT İŞLEMİ BAŞARILI");
                    foreach (Control txtclear in Controls) if (txtclear is TextBox) txtclear.Text = "";
                }
                sqlbaglantı.Close();
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
