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
    public partial class MüşteriListesi : Form
    {
        public MüşteriListesi()
        {
            InitializeComponent();
        }

        private void MüşteriListesi_Load(object sender, EventArgs e)
        {

        }
        static string bagdize = ("Data Source=DESKTOP-ALJJK6S;Initial Catalog=VT_ARAÇ_KİRALAMA_OTOMASYONU;Integrated Security=True");
        SqlConnection sqlbaglantı = new SqlConnection(bagdize);

        public void müsteriverileri_listele()
        {
            string getir = "SELECT * FROM TblMüsteriGirisi";

            SqlCommand kmt = new SqlCommand(getir, sqlbaglantı);

            SqlDataAdapter da = new SqlDataAdapter(kmt);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlbaglantı.Close();
        }

        private void btnmüsteriliste_Click(object sender, EventArgs e)
        {
            müsteriverileri_listele();

        }

        public void seciliverisil(string ad)
        {
            string sil = "DELETE FROM TblMüsteriGirisi WHERE Müsteri_Adı = @Müsteri_Adı";
            SqlCommand kmt = new SqlCommand(sil, sqlbaglantı);

            sqlbaglantı.Open();

            kmt.Parameters.AddWithValue("@Müsteri_Adı", ad);

            kmt.ExecuteNonQuery();

            sqlbaglantı.Close();
        }

        private void btnmüsterisil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                string ad = Convert.ToString(drow.Cells["Müsteri_Adı"].Value.ToString());
                seciliverisil(ad);
                müsteriverileri_listele();

                MessageBox.Show("SEÇİLEN KAYIT BAŞARIYLA SİLİNDİ");
            }
        }
    }
}

