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
    public partial class AraçEkle : Form
    {
        public AraçEkle()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        static string bagdize = ("Data Source=DESKTOP-ALJJK6S;Initial Catalog=VT_ARAÇ_KİRALAMA_OTOMASYONU;Integrated Security=True");
        SqlConnection sqlbaglantı = new SqlConnection(bagdize);
        private void btnMrkEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlbaglantı.State == ConnectionState.Closed)
                {

                    sqlbaglantı.Open();
                    
                    string sorgu = "INSERT INTO TblMarkalar (Marka_Ad, Marka_Kategori)VALUES(@Marka_Ad, @Marka_Kategori)";

                    SqlCommand kmt = new SqlCommand(sorgu, sqlbaglantı);
                    kmt.Parameters.AddWithValue("@Marka_Ad", txtmarkaad.Text);
                    kmt.Parameters.AddWithValue("@Marka_Kategori", cmbbxktgr.Text);
                  
                    kmt.ExecuteNonQuery();

                    sqlbaglantı.Close();
                    MessageBox.Show("MARKA KAYIT İŞLEMİ BAŞARILI");

                    foreach (Control txtclear in Controls) if (txtclear is TextBox) txtclear.Text = "";
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show("İŞLEM SIRASINDA BİR HATA OLUŞTU" + Hata.Message);
            }


        }
        public void markaverileri_Listele()
        {
            string listele = "SELECT * FROM TblMarkalar";

            SqlCommand kmt = new SqlCommand(listele, sqlbaglantı);

            SqlDataAdapter da = new SqlDataAdapter(kmt);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlbaglantı.Close();
        }
        private void btnMrkListe_Click(object sender, EventArgs e)
        {
            markaverileri_Listele();
        }

        private void btnMdlEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlbaglantı.State == ConnectionState.Closed)
                {

                    sqlbaglantı.Open();

                    string sorgu = "INSERT INTO TblModeller (MrkİD,Model_Ad, Model_Yılı, Plaka_No, Günlük_Kira_Ücreti) VALUES (@MrkİD, @Model_Ad, @Model_Yılı, @Plaka_No, @Günlük_Kira_Ücreti)";

                    SqlCommand kmt = new SqlCommand(sorgu, sqlbaglantı);
                    kmt.Parameters.AddWithValue("@MrkİD", txtmarkaıd.Text);
                    kmt.Parameters.AddWithValue("@Model_Ad", txtmodelad.Text);
                    kmt.Parameters.AddWithValue("@Model_Yılı", txtmodelyıl.Text);
                    kmt.Parameters.AddWithValue("@Plaka_No", txtplaka.Text);
                    kmt.Parameters.AddWithValue("@Günlük_Kira_Ücreti", txtgünlükücret.Text);
                    kmt.ExecuteNonQuery();

                    sqlbaglantı.Close();
                    MessageBox.Show("MODEL KAYIT İŞLEMİ BAŞARILI");
                    foreach (Control txtclear in Controls) if (txtclear is TextBox) txtclear.Text = "";

                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show("İŞLEM SIRASINDA BİR HATA OLUŞTU" + Hata.Message);
            }

        }
        public void modelverileri_Listele()
        {
            string listele = "SELECT * FROM TblModeller";

            SqlCommand kmt = new SqlCommand(listele, sqlbaglantı);

            SqlDataAdapter da = new SqlDataAdapter(kmt);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlbaglantı.Close();
        }

        private void btnMdlListe_Click(object sender, EventArgs e)
        {
            modelverileri_Listele();
        }

        private void btnÖzlkEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlbaglantı.State == ConnectionState.Closed)
                {

                    sqlbaglantı.Open();

                    string sorgu = "INSERT INTO TblArabaÖzellikleri (MrkİD,ModelİD, Yakıt_Türü, Vites_Tipi, Km) VALUES(@MrkİD, @ModelİD, @Yakıt_Türü, @Vites_Tipi, @Km)";

                    SqlCommand kmt = new SqlCommand(sorgu, sqlbaglantı);
                    kmt.Parameters.AddWithValue("@MrkİD", txtmarkaid.Text);
                    kmt.Parameters.AddWithValue("@ModelİD", txtmodelıd.Text);
                    kmt.Parameters.AddWithValue("@Yakıt_Türü", cmbbxykt.Text);
                    kmt.Parameters.AddWithValue("@Vites_Tipi", cmbbxvts.Text);
                    kmt.Parameters.AddWithValue("@Km", txtkm.Text);

                    kmt.ExecuteNonQuery();

                    sqlbaglantı.Close();
                    MessageBox.Show("ARAÇ ÖZELLİKLERİ KAYIT İŞLEMİ BAŞARILI");
                    foreach (Control txtclear in Controls) if (txtclear is TextBox) txtclear.Text = "";

                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show("İŞLEM SIRASINDA BİR HATA OLUŞTU" + Hata.Message);
            }
        }


        public void özellikverileri_Listele()
        {
            string listele = "SELECT * FROM TblArabaÖzellikleri";

            SqlCommand kmt = new SqlCommand(listele, sqlbaglantı);

            SqlDataAdapter da = new SqlDataAdapter(kmt);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlbaglantı.Close();
        }

        private void btnÖzlkListe_Click(object sender, EventArgs e)
        {
            özellikverileri_Listele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtmarkaad.Clear();
            txtmarkaıd.Clear();
            txtmodelad.Clear();
            txtmodelyıl.Clear();
            txtplaka.Clear();
            txtgünlükücret.Clear();
            txtmarkaid.Clear();
            txtmodelıd.Clear();
            txtkm.Clear();
        }
    }
}
