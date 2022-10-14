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
    public partial class kiralamatakip : Form
    {
        public kiralamatakip()
        {
            InitializeComponent();
        }
        static string bagdize = ("Data Source=DESKTOP-ALJJK6S;Initial Catalog=VT_ARAÇ_KİRALAMA_OTOMASYONU;Integrated Security=True");
        SqlConnection sqlbaglantı = new SqlConnection(bagdize);
        SqlCommand kmt = new SqlCommand();


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

       

        private void kiralananlistele_Click(object sender, EventArgs e)
        {
            kiralama_Listele();
        }
    }
}
