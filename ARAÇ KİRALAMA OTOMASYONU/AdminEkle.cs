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

namespace ARAÇ_KİRALAMA_OTOMASYONU
{
    public partial class AdminEkle : Form
    {
        public AdminEkle()
        {
            InitializeComponent();
        }

        SqlConnection sqlbaglantı = new SqlConnection("Data Source=DESKTOP-ALJJK6S;Initial Catalog=VT_ARAÇ_KİRALAMA_OTOMASYONU;Integrated Security=True");
        private void btnadminkayıt_Click_1(object sender, EventArgs e)
        {
            {
                if (txtAdminAd.Text == "" || txtŞifre.Text == "")
                {
                    MessageBox.Show("LÜTFEN BOŞ ALANLARI DOLDURUNUZ");
                }
                else
                {

                    sqlbaglantı.Open();
                    string admin;
                    string sifre;
                    admin = txtAdminAd.Text;
                    sifre = txtŞifre.Text;

                    SqlCommand kmt = new SqlCommand("select * from AdminGiriş where Admin_Ad ='" + admin + "'", sqlbaglantı);
                    SqlDataReader read = kmt.ExecuteReader();
                    if (read.Read())
                    {
                        MessageBox.Show("LÜTFEN BAŞKA BİR ADMİN ADI SEÇİNİZ");
                    }
                    else
                    {
                        read.Close();
                        SqlCommand ekle = new SqlCommand("insert into AdminGiriş (Admin_Ad,Admin_Sifre) values ('" + admin + "','" + sifre + "')", sqlbaglantı);
                        ekle.ExecuteNonQuery();
                        MessageBox.Show("KAYIT İŞLEMİ BAŞARILI");
                        foreach (Control txtclear in Controls) if (txtclear is TextBox) txtclear.Text = "";
                    }
                    sqlbaglantı.Close();
                }
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

