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
    public partial class FrmEuro : Form
    {
        public FrmEuro()
        {
            InitializeComponent();
        }

        double euroKuru = 38.50;
        private void txtMevcutDolar_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnHesapla1_Click(object sender, EventArgs e)
        {
            txtKazanılacakTL.Text = (Convert.ToDouble(txtMevcutEuro.Text) * euroKuru).ToString();

        }

        private void btnHesapla2_Click_1(object sender, EventArgs e)
        {
            txtAlınacakEuro.Text = (Convert.ToDouble(txtMevcutTL.Text) / euroKuru).ToString();
        }

        
    }
}
