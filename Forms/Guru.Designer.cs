namespace AplikasiLaporanKegiatanEkstraKurikuler.Forms
{
    partial class Guru
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
            this.Password = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Cari = new System.Windows.Forms.Button();
            this.txt_Cari = new System.Windows.Forms.TextBox();
            this.btn_Hapus = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Simpan = new System.Windows.Forms.Button();
            this.TanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.Alamat = new System.Windows.Forms.RichTextBox();
            this.Agama = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.ComboBox();
            this.JenisKelamin = new System.Windows.Forms.ComboBox();
            this.TempatLahir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Telpon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Guru = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Guru)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(92, 271);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(380, 20);
            this.Password.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Password";
            // 
            // btn_Cari
            // 
            this.btn_Cari.Image = global::AplikasiLaporanKegiatanEkstraKurikuler.Properties.Resources.search;
            this.btn_Cari.Location = new System.Drawing.Point(420, 324);
            this.btn_Cari.Name = "btn_Cari";
            this.btn_Cari.Size = new System.Drawing.Size(23, 23);
            this.btn_Cari.TabIndex = 37;
            this.btn_Cari.UseVisualStyleBackColor = true;
            // 
            // txt_Cari
            // 
            this.txt_Cari.Location = new System.Drawing.Point(92, 326);
            this.txt_Cari.Name = "txt_Cari";
            this.txt_Cari.Size = new System.Drawing.Size(329, 20);
            this.txt_Cari.TabIndex = 39;
            // 
            // btn_Hapus
            // 
            this.btn_Hapus.Location = new System.Drawing.Point(316, 297);
            this.btn_Hapus.Name = "btn_Hapus";
            this.btn_Hapus.Size = new System.Drawing.Size(75, 23);
            this.btn_Hapus.TabIndex = 34;
            this.btn_Hapus.Text = "Hapus";
            this.btn_Hapus.UseVisualStyleBackColor = true;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(397, 297);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 33;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_Simpan
            // 
            this.btn_Simpan.Location = new System.Drawing.Point(235, 297);
            this.btn_Simpan.Name = "btn_Simpan";
            this.btn_Simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_Simpan.TabIndex = 32;
            this.btn_Simpan.Text = "Simpan";
            this.btn_Simpan.UseVisualStyleBackColor = true;
            this.btn_Simpan.Click += new System.EventHandler(this.btn_Simpan_Click);
            // 
            // TanggalLahir
            // 
            this.TanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TanggalLahir.Location = new System.Drawing.Point(92, 166);
            this.TanggalLahir.Name = "TanggalLahir";
            this.TanggalLahir.Size = new System.Drawing.Size(380, 20);
            this.TanggalLahir.TabIndex = 35;
            // 
            // Alamat
            // 
            this.Alamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Alamat.Location = new System.Drawing.Point(92, 218);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(380, 46);
            this.Alamat.TabIndex = 38;
            this.Alamat.Text = "";
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
            this.Agama.Location = new System.Drawing.Point(92, 112);
            this.Agama.Name = "Agama";
            this.Agama.Size = new System.Drawing.Size(380, 21);
            this.Agama.TabIndex = 30;
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Lajang",
            "Sudah Menikah"});
            this.Status.Location = new System.Drawing.Point(92, 85);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(380, 21);
            this.Status.TabIndex = 29;
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.FormattingEnabled = true;
            this.JenisKelamin.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.JenisKelamin.Location = new System.Drawing.Point(92, 58);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(380, 21);
            this.JenisKelamin.TabIndex = 28;
            // 
            // TempatLahir
            // 
            this.TempatLahir.Location = new System.Drawing.Point(92, 140);
            this.TempatLahir.Name = "TempatLahir";
            this.TempatLahir.Size = new System.Drawing.Size(380, 20);
            this.TempatLahir.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tanggal Lahir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tempat Lahir";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Agama";
            // 
            // Telpon
            // 
            this.Telpon.Location = new System.Drawing.Point(92, 192);
            this.Telpon.Name = "Telpon";
            this.Telpon.Size = new System.Drawing.Size(380, 20);
            this.Telpon.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Telp / HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Alamat";
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(92, 32);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(380, 20);
            this.Nama.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nama";
            // 
            // NIP
            // 
            this.NIP.Location = new System.Drawing.Point(92, 6);
            this.NIP.Name = "NIP";
            this.NIP.Size = new System.Drawing.Size(380, 20);
            this.NIP.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cari";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "NIP";
            // 
            // dgv_Guru
            // 
            this.dgv_Guru.AllowUserToAddRows = false;
            this.dgv_Guru.AllowUserToDeleteRows = false;
            this.dgv_Guru.AllowUserToResizeRows = false;
            this.dgv_Guru.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Guru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Guru.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Guru.Location = new System.Drawing.Point(0, 353);
            this.dgv_Guru.Name = "dgv_Guru";
            this.dgv_Guru.RowHeadersVisible = false;
            this.dgv_Guru.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Guru.ShowEditingIcon = false;
            this.dgv_Guru.Size = new System.Drawing.Size(484, 158);
            this.dgv_Guru.TabIndex = 81;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = global::AplikasiLaporanKegiatanEkstraKurikuler.Properties.Resources.reset;
            this.btn_Refresh.Location = new System.Drawing.Point(449, 324);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(23, 23);
            this.btn_Refresh.TabIndex = 82;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Guru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_Guru);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_Cari);
            this.Controls.Add(this.txt_Cari);
            this.Controls.Add(this.btn_Hapus);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Simpan);
            this.Controls.Add(this.TanggalLahir);
            this.Controls.Add(this.Alamat);
            this.Controls.Add(this.Agama);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.TempatLahir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Telpon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Guru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Guru";
            this.Shown += new System.EventHandler(this.Guru_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Guru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Cari;
        private System.Windows.Forms.TextBox txt_Cari;
        private System.Windows.Forms.Button btn_Hapus;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Simpan;
        private System.Windows.Forms.DateTimePicker TanggalLahir;
        private System.Windows.Forms.RichTextBox Alamat;
        private System.Windows.Forms.ComboBox Agama;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.ComboBox JenisKelamin;
        private System.Windows.Forms.TextBox TempatLahir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Telpon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Guru;
        private System.Windows.Forms.Button btn_Refresh;
    }
}