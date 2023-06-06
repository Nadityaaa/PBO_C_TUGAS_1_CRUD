using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//NAMA    : NADITYA PUTRI LESTARI
//NIM     : 222410103003
//KELAS   : PBO C
//TUGAS   : CREATE & READ

namespace TUGAS_PRAKTIKUM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
