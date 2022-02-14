using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            AracEkleFrm aracekleform = new AracEkleFrm();
            aracekleform.Show();


        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkleFrm musteriekleform = new MusteriEkleFrm();
            musteriekleform.Show();

        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            musteriListeFrm musteriListeForm = new musteriListeFrm();
            musteriListeForm.Show();
            
           
        }

        private void btnArac_Click(object sender, EventArgs e)
        {
            AracListeleFrm aracListeleForm = new AracListeleFrm();
            aracListeleForm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            CikisYapFrm cikisYapForm = new CikisYapFrm();
            cikisYapForm.Show();

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        //private void label2_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
