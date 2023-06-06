using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

//NAMA    : NADITYA PUTRI LESTARI
//NIM     : 222410103003
//KELAS   : PBO C
//TUGAS   : CREATE & READ

namespace TUGAS_PRAKTIKUM
{
    public partial class CreateData : Form
    {
        public CreateData()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            CRpg.CreateDataLaptop(tbNama.Text, tbHarga.Text, tbStock.Text);
            tbNama.Text = "";
            tbHarga.Text = "";
            tbStock.Text = "";
        }
    }

}
