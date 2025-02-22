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
    public partial class FrmDolar : Form
    {
        public FrmDolar()
        {
            InitializeComponent();
        }

        double dolarKuru = 36.50;
        private void txtMevcutDolar_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnHesapla1_Click(object sender, EventArgs e)
        {
            txtKazanılacakTL.Text = (Convert.ToDouble(txtMevcutDolar.Text) * dolarKuru).ToString();

        }

        private void btnHesapla2_Click(object sender, EventArgs e)
        {
            txtAlınacakDolar.Text = (Convert.ToDouble(txtMevcutTL.Text) / dolarKuru).ToString();
        }
    }
}
