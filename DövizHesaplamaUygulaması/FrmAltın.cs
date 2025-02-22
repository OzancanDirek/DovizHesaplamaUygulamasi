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
    public partial class FrmAltın : Form
    {
        public FrmAltın()
        {
            InitializeComponent();
        }

        double Gram = 3.428;
        double Ceyrek = 5.785;
        double Yarım = 11.242;
        double Tam = 23.154;
        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gram")
            {
                txtTLKarsiligi.Text = (Convert.ToDouble(Gram) * Convert.ToDouble(txtAdet.Text)).ToString();
            }
            else if (comboBox1.Text == "Çeyrek")
            {
                txtTLKarsiligi.Text = (Convert.ToDouble(Ceyrek) * Convert.ToDouble(txtAdet.Text)).ToString();
            }
            else if (comboBox1.Text == "Yarım")
            {
                txtTLKarsiligi.Text = (Convert.ToDouble(Yarım) * Convert.ToDouble(txtAdet.Text)).ToString();

            }
            else if (comboBox1.Text == "Tam")
            {
                txtTLKarsiligi.Text = (Convert.ToDouble(Tam) * Convert.ToDouble(txtAdet.Text)).ToString();

            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Miktar Seçiniz!");
            }
        }
    }
}
