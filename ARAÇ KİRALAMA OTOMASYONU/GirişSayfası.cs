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
    public partial class GirişSayfası : Form
    {
        public GirişSayfası()
        {
            InitializeComponent();
        }
     
        SqlConnection sqlbaglantı = new SqlConnection(("Data Source=DESKTOP-ALJJK6S;Initial Catalog=VT_ARAÇ_KİRALAMA_OTOMASYONU;Integrated Security=True"));
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullanıcıAd.Text == "" || txtŞifre.Text == "")
            {
                MessageBox.Show("LÜTFEN BOŞ ALANLARI DOLDURUNUZ");
            }
            else
            {
                sqlbaglantı.Open();
                string kullanıcı;
                string sifre;
                kullanıcı = txtKullanıcıAd.Text;
                sifre = txtŞifre.Text;

                SqlCommand kmt = new SqlCommand("select * from KullanıcıGiriş where Kullanıcı_Ad ='" + kullanıcı + "' and Kullanıcı_Sifre='" + sifre + "'", sqlbaglantı);
                SqlDataReader read = kmt.ExecuteReader();
                if (read.Read())
                {
                    MessageBox.Show("GİRİŞ BAŞARILI HOŞGELDİNİZ");
                    foreach (Control txtclear in Controls) if (txtclear is TextBox) txtclear.Text = "";
                    Form KullanıcıAnaSayfa = new KullanıcıAnaSayfa();
                    KullanıcıAnaSayfa.ShowDialog();
                }

                else
                {
                    MessageBox.Show("HATALI KULLANICI ADI VEYA ŞİFRE");
                }

                sqlbaglantı.Close();
                
            }
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtAdminAd.Text == "" || txtAdminŞifre.Text == "")
            {
                MessageBox.Show("LÜTFEN BOŞ ALANLARI DOLDURUNUZ");
            }
            else
            {
                sqlbaglantı.Open();
                string admin;
                string sifre;
                admin = txtAdminAd.Text;
                sifre = txtAdminŞifre.Text;

                SqlCommand kmt = new SqlCommand("select * from AdminGiriş where Admin_Ad ='" + admin + "' and Admin_Sifre='" + sifre + "'", sqlbaglantı);
                SqlDataReader read = kmt.ExecuteReader();
                if (read.Read())
                {
                    MessageBox.Show("ADMİN GİRİŞİ BAŞARILI HOŞGELDİNİZ");
                    foreach (Control txtclear in Controls) if (txtclear is TextBox) txtclear.Text = "";
                    Form AdminAnaSayfa = new AdminAnaSayfa();
                    AdminAnaSayfa.ShowDialog();
                }

                else
                {
                    MessageBox.Show("HATALI ADMİN ADI VEYA ŞİFRE");
                }

                sqlbaglantı.Close();
               

            }
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.White;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form KayıtOl = new KayıtOl ();
            KayıtOl.ShowDialog();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Green;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.White;
        }

        
    }
}
