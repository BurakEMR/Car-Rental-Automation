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
    public partial class KullanıcıAnaSayfa : Form
    {
        public KullanıcıAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnaraclar_Click(object sender, EventArgs e)
        {
            Araclar araclar = new Araclar();
            araclar.ShowDialog();
        }

        private void btnAracKiralama_Click(object sender, EventArgs e)
        {
            AracKiralama kiralama = new AracKiralama();
            kiralama.ShowDialog();
        }

        private void btnaraclar_MouseHover(object sender, EventArgs e)
        {
            btnaraclar.BackColor = Color.Green;
        }

        private void btnaraclar_MouseMove(object sender, MouseEventArgs e)
        {
            btnaraclar.BackColor = Color.White;
        }

        private void btnAracKiralama_MouseHover(object sender, EventArgs e)
        {
            btnAracKiralama.BackColor = Color.Green;
        }

        private void btnAracKiralama_MouseMove(object sender, MouseEventArgs e)
        {
            btnAracKiralama.BackColor = Color.White;
        }
    }
}
