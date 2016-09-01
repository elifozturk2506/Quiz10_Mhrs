using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz10Mhrs
{
    public partial class AdminSayfasi : Form
    {
        public AdminSayfasi()
        {
            InitializeComponent();
        }
        PersonelKayit personelkayit = new PersonelKayit();
        PersonelListele personellistele = new PersonelListele();
        IzinTalepleri izintalepleri = new IzinTalepleri();
        private void doktorKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personelKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            personelkayit.MdiParent = this;
            personelkayit.WindowState = FormWindowState.Maximized;
            personelkayit.Show();
        }

        private void personellListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            personellistele.MdiParent = this;
            personellistele.WindowState = FormWindowState.Maximized;
            personellistele.Show();
        }

        private void izinTalepleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            izintalepleri.MdiParent = this;
            izintalepleri.WindowState = FormWindowState.Maximized;
            izintalepleri.Show();
        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
