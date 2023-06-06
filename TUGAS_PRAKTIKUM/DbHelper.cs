using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Npgsql;

//NAMA    : NADITYA PUTRI LESTARI
//NIM     : 222410103003
//KELAS   : PBO C
//TUGAS   : CREATE & READ

namespace TUGAS_PRAKTIKUM
{
    class CRpg
    {
        public static void CreateDataLaptop(string nama, string harga, string stok)
        {
            ConnectPg koneksidb = new ConnectPg();
            string querycreate = $"insert into sell.laptop (nama, harga, stok) values ('{nama}', '{harga}', '{stok}');";
            koneksidb.EksekusiSQL(querycreate);
        }
        public static DataTable ReadDataLaptop()
        {
            ConnectPg koneksidb = new ConnectPg();
            DataTable dt = koneksidb.EksekusiSQL("select nama, harga, stok from sell.laptop");

            return dt;
        }
        public static void CreateDataTransaksi(string nama_pembeli, string alamat_pembeli, string no_hp, string tgl_tansaksi, string terjual, string jumlah)
        {
            ConnectPg koneksidb = new ConnectPg();
            string querycreate = $"insert into sell.transaksi (nama_pembeli, alamat_pembeli, no_hp, tgl_transaksi, terjual, jumlah) values ('{nama_pembeli}', '{alamat_pembeli}', '{no_hp}', '{tgl_tansaksi}', '{terjual}', '{jumlah}');";
            koneksidb.EksekusiSQL(querycreate);
        }
        public static DataTable ReadDataTransaksi()
        {
            ConnectPg koneksidb = new ConnectPg();
            DataTable dt = koneksidb.EksekusiSQL("select nama_pembeli, alamat_pembeli, no_hp, tgl_transaksi, terjual, jumlah from sell.transaksi");

            return dt;
        }
    }

    class ConnectPg
    {
        public NpgsqlConnection koneksi;

        public ConnectPg()
        {
            NpgsqlConnection koneksi = new NpgsqlConnection();
            koneksi.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=tya;Database=penjualan";
        }

        public DataTable EksekusiSQL(string sintaks)
        {
            NpgsqlConnection koneksi = new NpgsqlConnection();
            koneksi.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=tya;Database=penjualan";

            DataTable dt = new DataTable();
            try
            {
                koneksi.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = koneksi;
                cmd.CommandText = sintaks;
                cmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                cmd.Dispose();
                koneksi.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return dt;
        }
    }
}
