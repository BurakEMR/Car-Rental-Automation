using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARAÇ_KİRALAMA_OTOMASYONU
{
    public partial class AdminAnaSayfa : Form
    {
        public AdminAnaSayfa()
        {
            InitializeComponent();
        }

        private void AdminAnaSayfa_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            Form MüşteriEkle = new MüşteriEkle();
            MüşteriEkle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MüşteriListesi MüsteriListele = new MüşteriListesi();
            MüsteriListele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AraçEkle AraçEkle = new AraçEkle();
            AraçEkle.ShowDialog();
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            AraçListeleme AraçListesi = new AraçListeleme();
            AraçListesi.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            AdminEkle AdminEkleme = new AdminEkle();
            AdminEkleme.ShowDialog();


        }

        private void btnkiratakip_Click(object sender, EventArgs e)
        {
            kiralamatakip kiratakip = new kiralamatakip();
            kiratakip.ShowDialog();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void btnkiratakip_MouseHover(object sender, EventArgs e)
        {
            btnkiratakip.BackColor = Color.Green;
        }

        private void btnkiratakip_MouseMove(object sender, MouseEventArgs e)
        {
            btnkiratakip.BackColor = Color.White;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Green;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.White;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Green;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.White;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = Color.Green;
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            button7.BackColor = Color.White;
        }
    }
}
