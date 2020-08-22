//////////////////////////////////////////////////////////////////
//    					     			                        //
//                	Coded by Faruk OKSUZ			            //
//                              				                //
//////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trigger
{
    public partial class btnRaporla : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=TriggerOrnek2;Integrated Security=True");
        SqlCommand komut;
        DataTable tablo;
        SqlDataAdapter adtr;
        string sorgu,
                sorgu2;
        DialogResult dialog;
        public btnRaporla()
        {
            InitializeComponent();
        }
        public DataTable VeriGetir(string sorgu)
        {
            if (baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
            }
            adtr = new SqlDataAdapter(sorgu, baglanti);
            tablo = new DataTable();
            adtr.Fill(tablo);
            return tablo;
        }
        public void SatisYinele()
        {
            sorgu = "SELECT * FROM satis";
            tablo = VeriGetir(sorgu);
            dataGridViewSatis.DataSource = tablo;
        }
        public void UrunYinele()
        {
            sorgu = "SELECT * FROM urun";
            tablo = new DataTable();
            tablo = VeriGetir(sorgu);
            dataGridViewUrun.DataSource = tablo;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnUrunGoster_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            UrunYinele();
            baglanti.Close();
        }
        private void btnSatisGoster_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SatisYinele();
            baglanti.Close();
        }
        private void btnSatisEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("SatisEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            //komut.Parameters.AddWithValue("@satisid", Convert.ToInt32(txtUrunId.Text));
            komut.Parameters.AddWithValue("@urunid", Convert.ToInt32(txtUrunId.Text));
            komut.Parameters.AddWithValue("@satisAdedi", Convert.ToInt32(txtSatisAdedi.Text));
            komut.ExecuteNonQuery();
            
            MessageBox.Show("Ürün başarıyla satıldı ve stoktan düşürüldü.İyi satışlar dileriz :)", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UrunYinele();
            SatisYinele();

            baglanti.Close();
        }
        private void dataGridViewSatis_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSatisId.Text = dataGridViewSatis.CurrentRow.Cells["satisid"].Value.ToString();
            txtUrunId.Text = dataGridViewSatis.CurrentRow.Cells["urunid"].Value.ToString();
            txtSatisAdedi.Text = dataGridViewSatis.CurrentRow.Cells["satisAdedi"].Value.ToString();
        }

        private void btnSatisGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("SatisGuncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@satisid", Convert.ToInt32(txtSatisId.Text));
            komut.Parameters.AddWithValue("@urunid", Convert.ToInt32(txtUrunId.Text));
            komut.Parameters.AddWithValue("@satisAdedi", Convert.ToInt32(txtSatisAdedi.Text));
            komut.ExecuteNonQuery();

            SatisYinele();
            baglanti.Close();
        }
        private void btnSatisRaporla_Click(object sender, EventArgs e)
        {
            frmRaporla raporFormu = new frmRaporla();
            this.Hide();
            raporFormu.Show();
        }
        private void btnSatisSil_Click(object sender, EventArgs e)
        {
            dialog = new DialogResult();
            dialog = MessageBox.Show("Seçili kaydı silmek istediğinize emin misiniz ?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                komut = new SqlCommand("SatisSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@satisid", dataGridViewSatis.CurrentRow.Cells["satisid"].Value);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Seçili kayıt başarıyla silindi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UrunYinele();
                SatisYinele();

                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Kayıt silmekten vazgeçildi !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
