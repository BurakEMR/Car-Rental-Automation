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
    public partial class AraçListeleme : Form
    {
        public AraçListeleme()
        {
            InitializeComponent();
        }
        static string bagdize = ("Data Source=DESKTOP-ALJJK6S;Initial Catalog=VT_ARAÇ_KİRALAMA_OTOMASYONU;Integrated Security=True");
        SqlConnection sqlbaglantı = new SqlConnection(bagdize);

        public void araçverileri_Listele()
        {
            string listele = "SELECT TblMarkalar.MrkİD, TblMarkalar.Marka_Ad, TblMarkalar.Marka_Kategori, TblModeller.MdlİD,TblModeller.Model_Ad,TblModeller.Model_Yılı,TblModeller.Plaka_No,TblArabaÖzellikleri.Yakıt_Türü,TblArabaÖzellikleri.Vites_Tipi,TblArabaÖzellikleri.Km FROM(TblMarkalar INNER JOIN TblModeller ON TblMarkalar.MrkİD = TblModeller.MrkİD INNER JOIN TblArabaÖzellikleri ON TblMarkalar.MrkİD = TblArabaÖzellikleri.MrkİD);";

            SqlCommand kmt = new SqlCommand(listele, sqlbaglantı);

            SqlDataAdapter da = new SqlDataAdapter(kmt);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlbaglantı.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            araçverileri_Listele();
        }

        public void seciliverisil(string km)
        {
            string sil = "DELETE FROM TblArabaÖzellikleri WHERE Km = @Km";
            SqlCommand kmt = new SqlCommand(sil, sqlbaglantı);

            sqlbaglantı.Open();

            kmt.Parameters.AddWithValue("@Km", km);

            kmt.ExecuteNonQuery();

            sqlbaglantı.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow drow in dataGridView1.SelectedRows )
            {
                string km = Convert.ToString(drow.Cells["km"].Value.ToString()); 
                seciliverisil(km);
                araçverileri_Listele();

                MessageBox.Show("SEÇİLEN KAYIT BAŞARIYLA SİLİNDİ");
            }
        }
   
    }
}
