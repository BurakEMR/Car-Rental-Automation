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
    public partial class Araclar : Form
    {
        public Araclar()
        {
            InitializeComponent();
        }

        private void Araclar_Load(object sender, EventArgs e)
        {

        }

        static string bagdize = ("Data Source=DESKTOP-ALJJK6S;Initial Catalog=VT_ARAÇ_KİRALAMA_OTOMASYONU;Integrated Security=True");
        SqlConnection sqlbaglantı = new SqlConnection(bagdize);

        public void markaverileri_Listele()
        {
            string listele = "SELECT Marka_Ad, Marka_Kategori FROM TblMarkalar";

            SqlCommand kmt = new SqlCommand(listele, sqlbaglantı);

            SqlDataAdapter da = new SqlDataAdapter(kmt);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlbaglantı.Close();
        }
        private void btnmarkaliste_Click(object sender, EventArgs e)
        {
            markaverileri_Listele();
        }


        public void modelverileri_Listele()
        {
            string listele = "SELECT TblMarkalar.Marka_Ad, TblModeller.Model_Ad, TblModeller.Model_Yılı, TblModeller.Plaka_No, TblModeller.Günlük_Kira_Ücreti FROM TblMarkalar INNER JOIN TblModeller ON TblMarkalar.MrkİD = TblModeller.MrkİD";

            SqlCommand kmt = new SqlCommand(listele, sqlbaglantı);

            SqlDataAdapter da = new SqlDataAdapter(kmt);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            sqlbaglantı.Close();
        }

        private void btnmodelliste_Click(object sender, EventArgs e)
        {
            modelverileri_Listele();
        }

        public void özellikverileri_Listele()
        {
            string listele = "SELECT TblModeller.Model_Ad, TblModeller.Model_Yılı, TblArabaÖzellikleri.Yakıt_Türü, TblArabaÖzellikleri.Vites_Tipi, TblArabaÖzellikleri.Km FROM TblModeller INNER JOIN TblArabaÖzellikleri ON TblModeller.MdlİD = TblArabaÖzellikleri.ModelİD";

            SqlCommand kmt = new SqlCommand(listele, sqlbaglantı);

            SqlDataAdapter da = new SqlDataAdapter(kmt);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;

            sqlbaglantı.Close();
        }

        private void btnözellikliste_Click(object sender, EventArgs e)
        {
            özellikverileri_Listele();
        }

        private void btnmarkaliste_MouseHover(object sender, EventArgs e)
        {
            btnmarkaliste.BackColor = Color.Green;
        }

        private void btnmarkaliste_MouseMove(object sender, MouseEventArgs e)
        {
            btnmarkaliste.BackColor = Color.White;
        }

        private void btnmodelliste_MouseHover(object sender, EventArgs e)
        {
            btnmodelliste.BackColor = Color.Green;
        }

        private void btnmodelliste_MouseMove(object sender, MouseEventArgs e)
        {
            btnmodelliste.BackColor = Color.White;
        }

        private void btnözellikliste_MouseHover(object sender, EventArgs e)
        {
            btnözellikliste.BackColor = Color.Green;
        }

        private void btnözellikliste_MouseMove(object sender, MouseEventArgs e)
        {
            btnözellikliste.BackColor = Color.White;
        }
    }
}
