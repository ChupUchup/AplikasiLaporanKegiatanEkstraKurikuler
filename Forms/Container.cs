using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLaporanKegiatanEkstraKurikuler.Forms
{
    public partial class Container : Form
    {
        Ekskul FormEkskul;
        Guru FormGuru;
        Siswa FormSiswa;

        public Container()
        {
            InitializeComponent();
        }

        private void Container_Shown(object sender, EventArgs e)
        {
            //var Login = new Login();
            //Login.Owner = this;
            //Login.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Print = new Print();
            Print.Owner = this;
            Print.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Login = new Login();
            Login.Owner = this;
            Login.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ekskulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormEkskul == null || FormEkskul.IsDisposed)
            {
                if (FormGuru != null) FormGuru.Close();
                if (FormSiswa != null) FormSiswa.Close();
                FormEkskul = new Ekskul();
                FormEkskul.MdiParent = this;
                FormEkskul.Show();
            }
        }

        private void guruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormGuru == null || FormGuru.IsDisposed)
            {
                if (FormEkskul != null) FormEkskul.Close();
                if (FormSiswa != null) FormSiswa.Close();
                FormGuru = new Guru();
                FormGuru.MdiParent = this;
                FormGuru.Show();
            }
        }

        private void siswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormSiswa == null || FormSiswa.IsDisposed)
            {
                if (FormEkskul != null) FormEkskul.Close();
                if (FormGuru != null) FormGuru.Close();
                FormSiswa = new Siswa();
                FormSiswa.MdiParent = this;
                FormSiswa.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var About = new About();
            About.Owner = this;
            About.ShowDialog();
        }

    }
}
