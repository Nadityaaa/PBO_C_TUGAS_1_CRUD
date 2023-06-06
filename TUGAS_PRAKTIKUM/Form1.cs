using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//NAMA    : NADITYA PUTRI LESTARI
//NIM     : 222410103003
//KELAS   : PBO C
//TUGAS   : CREATE & READ

namespace TUGAS_PRAKTIKUM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void loadgrid1()
        {
            dataGridView1.DataSource = CRpg.ReadDataLaptop();
        }
        void loadgrid2()
        {
            dataGridView1.DataSource = CRpg.ReadDataTransaksi();
        }
        private void btnCreateNewData_Click(object sender, EventArgs e)
        {
            using (CreateData crtData = new CreateData())
            {
                DialogResult dr = crtData.ShowDialog();
            }

        }

        private void btnCreateTransaction_Click(object sender, EventArgs e)
        {
            using (CreateTransaction createTransaction = new CreateTransaction())
            {
                DialogResult dr = createTransaction.ShowDialog();
            }
        }

        private void btnReadDataLaptop_Click(object sender, EventArgs e)
        {
            loadgrid1();
        }

        private void btnReadDataTransaction_Click(object sender, EventArgs e)
        {
            loadgrid2();
        }
    }
}
