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
    public partial class MüşteriEkle : Form
    {

        public MüşteriEkle()
        {
            InitializeComponent();
        }

        static string bagdize = ("Data Source=DESKTOP-ALJJK6S;Initial Catalog=VT_ARAÇ_KİRALAMA_OTOMASYONU;Integrated Security=True");
        SqlConnection sqlbaglantı = new SqlConnection(bagdize);
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlbaglantı.State == ConnectionState.Closed)
                {

                    sqlbaglantı.Open();

                    string sorgu = "INSERT INTO TblMüsteriGirisi ( Müsteri_Adı, Müsteri_Soyadı, Müsteri_TC, Müsteri_Tel, Müsteri_Doğumtarihi, Müsteri_Email)VALUES(@Müsteri_Adı, @Müsteri_Soyadı, @Müsteri_TC, @Müsteri_Tel, @Müsteri_Doğumtarihi, @Müsteri_Email)";

                    SqlCommand kmt = new SqlCommand(sorgu, sqlbaglantı);
                    kmt.Parameters.AddWithValue("@Müsteri_Adı", txtmüsteriad.Text);
                    kmt.Parameters.AddWithValue("@Müsteri_Soyadı", txtmüsterisoyad.Text);
                    kmt.Parameters.AddWithValue("@Müsteri_TC", txtTc.Text);
                    kmt.Parameters.AddWithValue("@Müsteri_Tel", txttel.Text);
                    kmt.Parameters.AddWithValue("@Müsteri_Doğumtarihi", dttmrdoğumtrh.Text);
                    kmt.Parameters.AddWithValue("@Müsteri_Email", txteposta.Text);
                    kmt.ExecuteNonQuery();

                    sqlbaglantı.Close();
                    MessageBox.Show("MÜŞTERİ KAYIT İŞLEMİ BAŞARILI");

                    foreach (Control txtclear in Controls) if (txtclear is TextBox) txtclear.Text = "";
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show("İŞLEM SIRASINDA BİR HATA OLUŞTU" + Hata.Message);
            }

            
        }
                  
        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
    }
}

