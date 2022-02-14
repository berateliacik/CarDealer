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
    public partial class KayitOlFrm : Form
    {
        public KayitOlFrm()
        {
            InitializeComponent();
        }

        bool isThere;
        private string baglantiCumlesi = @"Data Source=DESKTOP-CEI400U\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True";
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void KayitOlFrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Insert into kullanicikayit(username, password, re_password, giris_email,phone) values('"+txtKaydolUsername.Text+"','"+txtKaydolSifre.Text+ "','" + txtKaydolSifreYeniden.Text + "','" + txtKaydolMail.Text + "','" + txtKaydolTelefon.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt başarılı.", "Elia Car Gallery");
            LoginFrm loginforum = new LoginFrm();
            loginforum.Show();
            this.Hide();

        }
    }
}
