﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLaporanKegiatanEkstraKurikuler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Container());
        }

        public static string ConnString = "Data Source = AplikasiLaporanKegiatanEkstraKurikuler.db";
    }
}
