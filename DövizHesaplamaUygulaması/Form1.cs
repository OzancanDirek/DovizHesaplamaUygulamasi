using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DövizHesaplamaUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            FrmDolar fr = new FrmDolar();
            fr.Show();
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            FrmEuro fr = new FrmEuro();
            fr.Show();
        }

        private void btnAltın_Click(object sender, EventArgs e)
        {
            FrmAltın fr = new FrmAltın();
            fr.Show();
        }
    }
}
