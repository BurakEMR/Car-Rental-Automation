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
    public partial class AracKiralama : Form
    {
        public AracKiralama()
        {
            InitializeComponent();
        }
        static string bagdize = ("Data Source=DESKTOP-ALJJK6S;Initial Catalog=VT_ARAÇ_KİRALAMA_OTOMASYONU;Integrated Security=True");
        SqlConnection sqlbaglantı = new SqlConnection(bagdize);
        SqlCommand kmt = new SqlCommand();


        private void AracKiralama_Load(object sender, EventArgs e)
        {
            cmbxmodelad.Items.Clear();
            SqlDataReader oku;
            sqlbaglantı.Open();
            kmt.Connection = sqlbaglantı;
            kmt.CommandText = "SELECT * FROM TblModeller";
            oku = kmt.ExecuteReader();

            while (oku.Read())
            {
                cmbxmodelad.Items.Add(oku[2].ToString());
            }
            sqlbaglantı.Close();
        }

        private void cmbxmodelad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            sqlbaglantı.Open();
            SqlCommand kmt = new SqlCommand("SELECT * FROM TblModeller WHERE Model_Ad LIKE  '" + cmbxmodelad.Text + "'", sqlbaglantı);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                txtmdlid.Text = read[1].ToString();
                txtyıl.Text = read[3].ToString();
                txtplaka.Text = read[4].ToString();
                txtgkücreti.Text = read[5].ToString();
            }
            sqlbaglantı.Close();
        }

        public void kiralama_Listele()
        {
            string listele = "SELECT* FROM TblAraçKiralama";

            SqlCommand kmt = new SqlCommand(listele, sqlbaglantı);

            SqlDataAdapter da = new SqlDataAdapter(kmt);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlbaglantı.Close();
        }



        private void btnKiralama_Click(object sender, EventArgs e)

        {
            try
            {
                if (sqlbaglantı.State == ConnectionState.Closed)
                {

                    sqlbaglantı.Open();

                    string sorgu = "INSERT INTO TblAraçKiralama (MüsteriİD, Müsteri_Tc, Müsteri_Ad, Müsteri_Soyad,ModelİD, Model_Ad, Model_Yılı, Plaka, Kira_Ücreti, Kira_Başlangıç, Kira_Bitiş, Kira_Gün_Sayısı, Genel_Ücret ) VALUES (@MüsteriİD, @Müsteri_Tc, @Müsteri_Ad, @Müsteri_Soyad, @ModelİD, @Model_Ad, @Model_Yılı, @Plaka, @Kira_Ücreti, @Kira_Başlangıç, @Kira_Bitiş, @Kira_Gün_Sayısı, @Genel_Ücret )";

                    SqlCommand kmt = new SqlCommand(sorgu, sqlbaglantı);
                    kmt.Parameters.AddWithValue("@MüsteriİD", txtid.Text);
                    kmt.Parameters.AddWithValue("@Müsteri_Tc", txtTc.Text);
                    kmt.Parameters.AddWithValue("@Müsteri_Ad", txtmüsteriad.Text);
                    kmt.Parameters.AddWithValue("@Müsteri_Soyad", txtmüsterisoyad.Text);
                    kmt.Parameters.AddWithValue("@ModelİD", txtmdlid.Text);
                    kmt.Parameters.AddWithValue("@Model_Ad", cmbxmodelad.Text);
                    kmt.Parameters.AddWithValue("@Model_Yılı", txtyıl.Text);
                    kmt.Parameters.AddWithValue("@Plaka", txtplaka.Text);
                    kmt.Parameters.AddWithValue("@Kira_Ücreti", txtgkücreti.Text);
                    kmt.Parameters.AddWithValue("Kira_Başlangıç", dateTimePicker1.Text);
                    kmt.Parameters.AddWithValue("@Kira_Bitiş", dateTimePicker2.Text);
                    kmt.Parameters.AddWithValue("@Kira_Gün_Sayısı", txtgün.Text);
                    kmt.Parameters.AddWithValue("@Genel_Ücret", txtgenelücret.Text);
                    kmt.ExecuteNonQuery();

                    sqlbaglantı.Close();
                    MessageBox.Show("ARAÇ KİRALAMA İŞLEMİ BAŞARILI");

                    foreach (Control txtclear in Controls) if (txtclear is TextBox) txtclear.Text = "";
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show("İŞLEM SIRASINDA BİR HATA OLUŞTU" + Hata.Message);
            }

            kiralama_Listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan kiragün = DateTime.Parse(dateTimePicker2.Text) - DateTime.Parse(dateTimePicker1.Text);
            int kiragun = kiragün.Days;
            txtgün.Text = kiragun.ToString();
            txtgenelücret.Text = (kiragun * int.Parse(txtgkücreti.Text)).ToString();

        }

        public void Tc_Getir(TextBox id, TextBox tc, TextBox müsteri_ad, TextBox müsterisoyad, string sorgu)
        {
            sqlbaglantı.Open();
            SqlCommand kmt = new SqlCommand(sorgu, sqlbaglantı);
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txtid.Text = oku[0].ToString();
                txtmüsteriad.Text = oku[1].ToString();
                txtmüsterisoyad.Text = oku[2].ToString();
            }
            sqlbaglantı.Close();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "SELECT *FROM TblMüsteriGirisi WHERE Müsteri_Tc LIKE '" + txtTc.Text + "'";
            Tc_Getir(txtid,txtTc, txtmüsteriad, txtmüsterisoyad, sorgu);
        }

        private void btnKiralama_MouseHover(object sender, EventArgs e)
        {
            btnKiralama.BackColor = Color.Green;
        }

        private void btnKiralama_MouseMove(object sender, MouseEventArgs e)
        {
            btnKiralama.BackColor = Color.White;
        }

        private void btnhesapla_MouseHover(object sender, EventArgs e)
        {
            btnhesapla.BackColor = Color.Orange;
        }

        private void btnhesapla_MouseMove(object sender, MouseEventArgs e)
        {
            btnhesapla.BackColor = Color.White;
        }

        
    }
}
