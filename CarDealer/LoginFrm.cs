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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }
        bool isThere;
        private string baglantiCumlesi = @"Data Source=DESKTOP-CEI400U\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {

            string username = txtGirisEmail.Text;
            string password = txtGirisSifre.Text;
            

            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * from kullanicikayit ", baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                if (username==reader["username"].ToString() && password==reader["password"].ToString())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;

                }
            }

            baglanti.Close();


            if (isThere)
            {
                MessageBox.Show("Giriş başarılı.", "Elia Car Gallery");
                
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre hatalı. Lütfen tekrar deneyiniz.","Elia Car Gallery");

            }

            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayitOlFrm kayitolforum = new KayitOlFrm();
            kayitolforum.Show();
            this.Hide();
            
        }
    }
}
