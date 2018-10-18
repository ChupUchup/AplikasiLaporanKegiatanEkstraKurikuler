namespace AplikasiLaporanKegiatanEkstraKurikuler.Forms
{
    partial class Siswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Cari = new System.Windows.Forms.Button();
            this.txt_Cari = new System.Windows.Forms.TextBox();
            this.btn_Hapus = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Simpan = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Jurusan = new System.Windows.Forms.ComboBox();
            this.Kelas = new System.Windows.Forms.ComboBox();
            this.Ekstrakurikuler = new System.Windows.Forms.ComboBox();
            this.TanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.Alamat = new System.Windows.Forms.RichTextBox();
            this.JenisKelamin = new System.Windows.Forms.ComboBox();
            this.Agama = new System.Windows.Forms.ComboBox();
            this.TempatLahir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Telpon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NIS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Siswa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Siswa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cari
            // 
            this.btn_Cari.Image = global::AplikasiLaporanKegiatanEkstraKurikuler.Properties.Resources.search;
            this.btn_Cari.Location = new System.Drawing.Point(449, 323);
            this.btn_Cari.Name = "btn_Cari";
            this.btn_Cari.Size = new System.Drawing.Size(23, 23);
            this.btn_Cari.TabIndex = 78;
            this.btn_Cari.UseVisualStyleBackColor = true;
            // 
            // txt_Cari
            // 
            this.txt_Cari.Location = new System.Drawing.Point(96, 325);
            this.txt_Cari.Name = "txt_Cari";
            this.txt_Cari.Size = new System.Drawing.Size(347, 20);
            this.txt_Cari.TabIndex = 79;
            // 
            // btn_Hapus
            // 
            this.btn_Hapus.Location = new System.Drawing.Point(316, 296);
            this.btn_Hapus.Name = "btn_Hapus";
            this.btn_Hapus.Size = new System.Drawing.Size(75, 23);
            this.btn_Hapus.TabIndex = 75;
            this.btn_Hapus.Text = "Hapus";
            this.btn_Hapus.UseVisualStyleBackColor = true;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(397, 296);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 76;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_Simpan
            // 
            this.btn_Simpan.Location = new System.Drawing.Point(235, 296);
            this.btn_Simpan.Name = "btn_Simpan";
            this.btn_Simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_Simpan.TabIndex = 77;
            this.btn_Simpan.Text = "Simpan";
            this.btn_Simpan.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 74;
            this.label12.Text = "Cari";
            // 
            // Jurusan
            // 
            this.Jurusan.FormattingEnabled = true;
            this.Jurusan.Items.AddRange(new object[] {
            "Tk. Mesin",
            "Tk. Motor",
            "Tk. Elektro",
            "Tk. Jaringan",
            "Tk. Komputer"});
            this.Jurusan.Location = new System.Drawing.Point(287, 242);
            this.Jurusan.Name = "Jurusan";
            this.Jurusan.Size = new System.Drawing.Size(185, 21);
            this.Jurusan.TabIndex = 60;
            // 
            // Kelas
            // 
            this.Kelas.FormattingEnabled = true;
            this.Kelas.Items.AddRange(new object[] {
            "X",
            "XI",
            "XII"});
            this.Kelas.Location = new System.Drawing.Point(96, 242);
            this.Kelas.Name = "Kelas";
            this.Kelas.Size = new System.Drawing.Size(185, 21);
            this.Kelas.TabIndex = 59;
            // 
            // Ekstrakurikuler
            // 
            this.Ekstrakurikuler.FormattingEnabled = true;
            this.Ekstrakurikuler.Location = new System.Drawing.Point(96, 269);
            this.Ekstrakurikuler.Name = "Ekstrakurikuler";
            this.Ekstrakurikuler.Size = new System.Drawing.Size(376, 21);
            this.Ekstrakurikuler.TabIndex = 61;
            // 
            // TanggalLahir
            // 
            this.TanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TanggalLahir.Location = new System.Drawing.Point(96, 138);
            this.TanggalLahir.Name = "TanggalLahir";
            this.TanggalLahir.Size = new System.Drawing.Size(376, 20);
            this.TanggalLahir.TabIndex = 56;
            // 
            // Alamat
            // 
            this.Alamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Alamat.Location = new System.Drawing.Point(96, 190);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(376, 46);
            this.Alamat.TabIndex = 58;
            this.Alamat.Text = "";
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.FormattingEnabled = true;
            this.JenisKelamin.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.JenisKelamin.Location = new System.Drawing.Point(96, 58);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(376, 21);
            this.JenisKelamin.TabIndex = 54;
            // 
            // Agama
            // 
            this.Agama.FormattingEnabled = true;
            this.Agama.Items.AddRange(new object[] {
            "Islam",
            "Kristen Katolik",
            "Kristen Protestan",
            "Hindu",
            "Budha",
            "Konghucu",
            "Lainnya"});
            this.Agama.Location = new System.Drawing.Point(96, 85);
            this.Agama.Name = "Agama";
            this.Agama.Size = new System.Drawing.Size(376, 21);
            this.Agama.TabIndex = 53;
            // 
            // TempatLahir
            // 
            this.TempatLahir.Location = new System.Drawing.Point(96, 112);
            this.TempatLahir.Name = "TempatLahir";
            this.TempatLahir.Size = new System.Drawing.Size(376, 20);
            this.TempatLahir.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Tanggal Lahir";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "Jenis Kelamin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Tempat Lahir";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "Agama";
            // 
            // Telpon
            // 
            this.Telpon.Location = new System.Drawing.Point(96, 164);
            this.Telpon.Name = "Telpon";
            this.Telpon.Size = new System.Drawing.Size(376, 20);
            this.Telpon.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Kelas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Telp / HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Ekstrakurikuler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Alamat";
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(96, 32);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(376, 20);
            this.Nama.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Nama";
            // 
            // NIS
            // 
            this.NIS.Location = new System.Drawing.Point(96, 6);
            this.NIS.Name = "NIS";
            this.NIS.Size = new System.Drawing.Size(376, 20);
            this.NIS.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "NIS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "NIP";
            // 
            // dgv_Siswa
            // 
            this.dgv_Siswa.AllowUserToAddRows = false;
            this.dgv_Siswa.AllowUserToDeleteRows = false;
            this.dgv_Siswa.AllowUserToResizeRows = false;
            this.dgv_Siswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Siswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Siswa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Siswa.Location = new System.Drawing.Point(0, 351);
            this.dgv_Siswa.Name = "dgv_Siswa";
            this.dgv_Siswa.RowHeadersVisible = false;
            this.dgv_Siswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Siswa.ShowEditingIcon = false;
            this.dgv_Siswa.Size = new System.Drawing.Size(484, 160);
            this.dgv_Siswa.TabIndex = 80;
            // 
            // Siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.dgv_Siswa);
            this.Controls.Add(this.btn_Cari);
            this.Controls.Add(this.txt_Cari);
            this.Controls.Add(this.btn_Hapus);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Simpan);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Jurusan);
            this.Controls.Add(this.Kelas);
            this.Controls.Add(this.Ekstrakurikuler);
            this.Controls.Add(this.TanggalLahir);
            this.Controls.Add(this.Alamat);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.Agama);
            this.Controls.Add(this.TempatLahir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Telpon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NIS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Siswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Siswa";
            this.Shown += new System.EventHandler(this.Siswa_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Siswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cari;
        private System.Windows.Forms.TextBox txt_Cari;
        private System.Windows.Forms.Button btn_Hapus;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Simpan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Jurusan;
        private System.Windows.Forms.ComboBox Kelas;
        private System.Windows.Forms.ComboBox Ekstrakurikuler;
        private System.Windows.Forms.DateTimePicker TanggalLahir;
        private System.Windows.Forms.RichTextBox Alamat;
        private System.Windows.Forms.ComboBox JenisKelamin;
        private System.Windows.Forms.ComboBox Agama;
        private System.Windows.Forms.TextBox TempatLahir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Telpon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NIS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Siswa;
    }
}