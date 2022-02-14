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
    public partial class AracListeleFrm : Form
    {
        public AracListeleFrm()
        {
            InitializeComponent();
        }

        private string baglantiCumlesi = @"Data Source=DESKTOP-CEI400U\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True";

        public void AracListele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From Araclar";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();
        }
        private void AracListeleFrm_Load(object sender, EventArgs e)
        {
            AracListele();
        }

        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMarka.SelectedIndex == 0)
            {
                comboBoxSeri.Text = "";
                comboBoxSeri.Items.Clear();
                comboBoxSeri.Items.Add("R8");
                comboBoxSeri.Items.Add("A4");
                comboBoxSeri.Items.Add("Q3");
                comboBoxSeri.Items.Add("A1");
                comboBoxSeri.Items.Add("Q2");
                comboBoxSeri.Items.Add("A3");
                comboBoxSeri.Items.Add("TT");
                comboBoxSeri.Items.Add("A8");
                comboBoxSeri.Items.Add("A6");
                comboBoxSeri.Items.Add("Q5");

            }

            else if (comboBoxMarka.SelectedIndex == 1)
            {
                comboBoxSeri.Text = "";
                comboBoxSeri.Items.Clear();
                comboBoxSeri.Items.Add("320i");
                comboBoxSeri.Items.Add("M4");
                comboBoxSeri.Items.Add("M5");
                comboBoxSeri.Items.Add("M6");
                comboBoxSeri.Items.Add("M8");
                comboBoxSeri.Items.Add("i8");


            }

            else if (comboBoxMarka.SelectedIndex == 2)
            {
                comboBoxSeri.Text = "";
                comboBoxSeri.Items.Clear();
                comboBoxSeri.Items.Add("C63");
                comboBoxSeri.Items.Add("C180");
                comboBoxSeri.Items.Add("E180");
                comboBoxSeri.Items.Add("E200");
                comboBoxSeri.Items.Add("S300");
                comboBoxSeri.Items.Add("C200");


            }

            else if (comboBoxMarka.SelectedIndex == 3)
            {
                comboBoxSeri.Text = "";
                comboBoxSeri.Items.Clear();
                comboBoxSeri.Items.Add("XC40");
                comboBoxSeri.Items.Add("XC90");
                comboBoxSeri.Items.Add("V40");
                comboBoxSeri.Items.Add("XC60");
                comboBoxSeri.Items.Add("S60");
                comboBoxSeri.Items.Add("S90");
                comboBoxSeri.Items.Add("S40");


            }

            else if (comboBoxMarka.SelectedIndex == 4)
            {
                comboBoxSeri.Text = "";
                comboBoxSeri.Items.Clear();
                comboBoxSeri.Items.Add("Passat");
                comboBoxSeri.Items.Add("Tiguan");
                comboBoxSeri.Items.Add("Polo");
                comboBoxSeri.Items.Add("Golf");
                comboBoxSeri.Items.Add("Caddy");
                comboBoxSeri.Items.Add("Jetta");
                comboBoxSeri.Items.Add("Beetle");
                comboBoxSeri.Items.Add("Atlas");

            }

            else if (comboBoxMarka.SelectedIndex == 5)
            {
                comboBoxSeri.Text = "";
                comboBoxSeri.Items.Clear();
                comboBoxSeri.Items.Add("208");
                comboBoxSeri.Items.Add("5008");
                comboBoxSeri.Items.Add("3008");
                comboBoxSeri.Items.Add("2008");
                comboBoxSeri.Items.Add("508");
                comboBoxSeri.Items.Add("Rifter");
                comboBoxSeri.Items.Add("Partner");
                comboBoxSeri.Items.Add("206");
                comboBoxSeri.Items.Add("301");
                comboBoxSeri.Items.Add("108");

            }

            else if (comboBoxMarka.SelectedIndex == 6)
            {
                comboBoxSeri.Text = "";
                comboBoxSeri.Items.Clear();
                comboBoxSeri.Items.Add("Expedition");
                comboBoxSeri.Items.Add("Explorer");
                comboBoxSeri.Items.Add("Focus");
                comboBoxSeri.Items.Add("Ranger");
                comboBoxSeri.Items.Add("Fiesta");
                comboBoxSeri.Items.Add("Puma");
                comboBoxSeri.Items.Add("Courier");
                comboBoxSeri.Items.Add("Kuga");
                comboBoxSeri.Items.Add("Connect");


            }

            else if (comboBoxMarka.SelectedIndex == 7)
            {
                comboBoxSeri.Text = "";
                comboBoxSeri.Items.Clear();
                comboBoxSeri.Items.Add("Doblo");
                comboBoxSeri.Items.Add("Fiorino");
                comboBoxSeri.Items.Add("Egea");
                comboBoxSeri.Items.Add("Linea");
                comboBoxSeri.Items.Add("Ducato");
                comboBoxSeri.Items.Add("Punto");
                comboBoxSeri.Items.Add("Talento");

            }

            else if (comboBoxMarka.SelectedIndex == 8)
            {
                comboBoxSeri.Text = "";
                comboBoxSeri.Items.Clear();
                comboBoxSeri.Items.Add("Duster");
                comboBoxSeri.Items.Add("Sandero");
                comboBoxSeri.Items.Add("Spring");
                comboBoxSeri.Items.Add("Logan");
                comboBoxSeri.Items.Add("Jogger");
                comboBoxSeri.Items.Add("Dokker");
                comboBoxSeri.Items.Add("Lodgy");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaka.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            comboBoxMarka.SelectedItem = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            comboBoxSeri.SelectedItem = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtModel.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txtRenk.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txtKm.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            comboBoxYakit.SelectedItem = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txtYil.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
            comboBoxVites.SelectedItem = dataGridView2.CurrentRow.Cells[9].Value.ToString();
            comboBoxDurum.SelectedItem = dataGridView2.CurrentRow.Cells[10].Value.ToString();
            comboBoxTakas.SelectedItem = dataGridView2.CurrentRow.Cells[11].Value.ToString();
            txtFiyat.Text = dataGridView2.CurrentRow.Cells[12].Value.ToString();
        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Update Araclar set marka=@Marka, seri=@Seri, model=@Model , renk=@Renk, km=@Km, yakit=@Yakit, yil=@Yil, vites=@Vites, durumu=@Durumu, takas=@Takas, fiyat=@Fiyat Where plaka=@Plaka";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@Marka", comboBoxMarka.SelectedItem);
            komut.Parameters.AddWithValue("@Seri", comboBoxSeri.SelectedItem);
            komut.Parameters.AddWithValue("@Model", txtModel.Text);
            komut.Parameters.AddWithValue("@Renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@Km",txtKm.Text);
            komut.Parameters.AddWithValue("@Yakit", comboBoxYakit.SelectedItem);
            komut.Parameters.AddWithValue("@Yil", txtYil.Text);
            komut.Parameters.AddWithValue("@Vites", comboBoxVites.SelectedItem);
            komut.Parameters.AddWithValue("@Durumu", comboBoxDurum.SelectedItem);
            komut.Parameters.AddWithValue("@Takas", comboBoxTakas.SelectedItem);
            komut.Parameters.AddWithValue("@Fiyat",txtFiyat.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            AracListele();
            MessageBox.Show("Araç Başarıyla Güncellendi.");

            txtPlaka.Text = "";
            comboBoxMarka.Text = "";
            comboBoxSeri.Text = "";
            txtModel.Text = "";
            txtRenk.Text = "";
            txtKm.Text = "";
            comboBoxYakit.Text = "";
            txtYil.Text = "";
            comboBoxVites.Text = "";
            comboBoxDurum.Text = "";
            comboBoxTakas.Text = "";
            txtFiyat.Text = "";
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Delete From Araclar where plaka='" + dataGridView2.CurrentRow.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            AracListele();
            MessageBox.Show("Araç Başarıyla Silindi.");

            txtPlaka.Text = "";
            comboBoxMarka.Text = "";
            comboBoxSeri.Text = "";
            txtModel.Text = "";
            txtRenk.Text = "";
            txtKm.Text = "";
            comboBoxYakit.Text = "";
            txtYil.Text = "";
            comboBoxVites.Text = "";
            comboBoxDurum.Text = "";
            comboBoxTakas.Text = "";
            txtFiyat.Text = "";
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
