using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

//NAMA    : NADITYA PUTRI LESTARI
//NIM     : 222410103003
//KELAS   : PBO C
//TUGAS   : CREATE & READ

namespace TUGAS_PRAKTIKUM
{
    public partial class CreateTransaction : Form
    {
        public CreateTransaction()
        {
            InitializeComponent();
        }
        private void CreateTransaction_Load(object sender, EventArgs e)
        {
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string nama_pembeli = tbNama.Text;
            string alamat_pembeli = tbAlamat.Text;
            string no_hp = tbNoHP.Text;
            string tgl_transaksi = tbTglTransaksi.Text;
            string terjual = tbNamaLaptop.Text;
            string jumlah = tbJumlah.Text;

            CRpg.CreateDataTransaksi(nama_pembeli, alamat_pembeli, no_hp, tgl_transaksi, terjual, jumlah);

            tbNama.Text = "";
            tbAlamat.Text = "";
            tbNoHP.Text = "";
            tbTglTransaksi.Text = "";
            tbNamaLaptop.Text = "";
            tbJumlah.Text = "";

        }
    }
}
