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
    public partial class CikisYapFrm : Form
    {
        public CikisYapFrm()
        {
            InitializeComponent();
        }

        private void CikisYapFrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }
    }
}
