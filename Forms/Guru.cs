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
    public partial class Guru : Form
    {
        public Guru()
        {
            InitializeComponent();
        }

        private void Guru_Shown(object sender, EventArgs e)
        {
            btn_Refresh_Click(null, null);
        }

        private void btn_Simpan_Click(object sender, EventArgs e)
        {
            string
                _NIP = NIP.Text,
                _Nama = Nama.Text,
                _JenisKelamin = JenisKelamin.Items[JenisKelamin.SelectedIndex].ToString(),
                _Status = Status.Text,
                _Agama = Agama.Items[Agama.SelectedIndex].ToString(),
                _TempatLahir = TempatLahir.Text,
                _TanggalLahir = TanggalLahir.Value.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss"),
                _Telpon = Telpon.Text,
                _Alamat = Alamat.Text,
                _Password = Password.Text,
                QueryString =
                "INSERT INTO Guru VALUES ('" +
                _NIP + "', '" +
                _Nama + "', '" +
                _JenisKelamin + "', '" +
                _Status + "', '" +
                _Agama + "', '" +
                _TempatLahir + "', '" +
                _TanggalLahir + "', '" +
                _Telpon + "', '" +
                _Alamat + "', '" +
                _Password + "')";
            try
            {
                MessageBox.Show(SQLite.ExecuteNonQuery(QueryString, Program.ConnString).ToString() + " data telah tersimpan", "Informasi", MessageBoxButtons.OK); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informasi", MessageBoxButtons.OK);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgv_Guru.DataSource = null;
            dgv_Guru.DataSource = SQLite.Adapter("SELECT * FROM Guru", Program.ConnString).Tables[0];
        }
    }
}
