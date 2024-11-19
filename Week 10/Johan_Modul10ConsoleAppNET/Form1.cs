using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Johan_Modul10ConsoleAppNET
{
    public partial class Form1 : Form
    {
        List<string> listkota = new List<string>();
        public Form1()
        {
            InitializeComponent();
            listkota = Ongkir.GetKotaList();
            foreach (string kota in listkota)
            {
                tb_asal.AutoCompleteCustomSource.Add(kota);
                tb_asal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tb_asal.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tb_tujuan.AutoCompleteCustomSource.Add(kota);
                tb_tujuan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tb_tujuan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private int GetIdKota(string kota)
        {
            int idKota = -1;
            idKota = Ongkir.GetIdKotaList(kota);
            return idKota;
        }

        private void TampilkanDaftar(List<string> daftarLayanan)
        {
            gb_detailLayanan.Text = "Detail Layanan";
            foreach (string layanan in daftarLayanan)
            {
                gb_detailLayanan.Text += "\n" + layanan;
            }
        }

        private void bt_cekhargalayanan_Click(object sender, EventArgs e)
        {
            string kurir = "";
            if (rb_jne.Checked)
                kurir = "jne";
            else if (rb_pos.Checked)
                kurir = "pos";
            else if (rb_tiki.Checked)
                kurir = "tiki";
            List<string> daftarLayanan = Ongkir.GetLayananList
                (GetIdKota(tb_asal.Text), GetIdKota(tb_tujuan.Text), int.Parse(tb_berat.Text), kurir);
            TampilkanDaftar(daftarLayanan);
        }
    }
}
