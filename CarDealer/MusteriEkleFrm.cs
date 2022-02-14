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
    public partial class MusteriEkleFrm : Form
    {
        public MusteriEkleFrm()
        {
            InitializeComponent();
        }

        private string baglantiCumlesi = @"Data Source=DESKTOP-CEI400U\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True";
        private void MusteriEkleFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Insert into musteritablo Values (@TcNo, @AdSoyad, @TelNo, @Email, @Adres)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.Parameters.AddWithValue("@TcNo", txtTc.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@TelNo", txtTelNo.Text);
            komut.Parameters.AddWithValue("@Email", txtMail.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni müşteri başarıyla eklendi.");
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
