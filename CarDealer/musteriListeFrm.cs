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


namespace CarDealer
{
    public partial class musteriListeFrm : Form
    {
        public musteriListeFrm()
        {
            InitializeComponent();
        }

        private string baglantiCumlesi = @"Data Source=DESKTOP-CEI400U\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True";
        private void musteriListeFrm_Load(object sender, EventArgs e)
        {

            MusteriListele();

        }

        public void MusteriListele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From musteritablo";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Update musteritablo set ad_soyad=@AdSoyad, tel=@TelNo, e_mail=@Email, adres=@Adres Where tc_no=@TcNo";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@TcNo", txtTc.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@TelNo", txtTelNo.Text);
            komut.Parameters.AddWithValue("@Email", txtMail.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriListele();
            MessageBox.Show("Müşteri Başarıyla Güncellendi.");
            txtTc.Text = "";
            txtAdSoyad.Text = "";
            txtTelNo.Text = "";
            txtMail.Text = "";
            txtAdres.Text = "";

        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Delete From musteritablo where tc_no='" + dataGridView1.CurrentRow.Cells["tc_no"].Value.ToString()+"'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriListele();
            MessageBox.Show("Müşteri Başarıyla Silindi.");

            txtTc.Text = "";
            txtAdSoyad.Text = "";
            txtTelNo.Text = "";
            txtMail.Text = "";
            txtAdres.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
