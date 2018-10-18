using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLWrapper;

namespace AplikasiLaporanKegiatanEkstraKurikuler.Forms
{
    public partial class Siswa : Form
    {
        public Siswa()
        {
            InitializeComponent();
        }

        private void Siswa_Shown(object sender, EventArgs e)
        {
            dgv_Siswa.DataSource = null;
            dgv_Siswa.DataSource = SQLite.Adapter("SELECT * FROM Siswa", Program.ConnString).Tables[0];
        }
    }
}
