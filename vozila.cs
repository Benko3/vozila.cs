using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vozila
{
    public partial class Form1 : Form
    {
        private int brojMotocikala = 0;
        private int brojAutomobila = 0;
        private int brojKamiona = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string model = txtModel.Text;
            int godina;
            int brojKotaca;

            if (!int.TryParse(txtGodinaProizvodnje.Text, out godina))
            {
                MessageBox.Show("Molimo unesite ispravnu godinu proizvodnje.");
                return;
            }

            if (!int.TryParse(txtBrojKotaca.Text, out brojKotaca) || brojKotaca < 2 || brojKotaca % 2 != 0)
            {
                MessageBox.Show("Molimo unesite ispravan broj kotača (samo parni broj veći ili jednak 2).");
                return;
            }
            if (brojKotaca == 2)
            {
                brojMotocikala++;
                txtIspis.AppendText($"{model} je motor.\n");
            }

            else if (brojKotaca == 4)
            {
                brojAutomobila++;
                txtIspis.AppendText($"{model} je automobil.\n");
            }
            else
            {
                brojKamiona++;
                txtIspis.AppendText($"{model} je kamion.\n");
            }



        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            txtIspis.AppendText($"Ukupan broj motocikala: {brojMotocikala}\n");
            txtIspis.AppendText($"Ukupan broj automobila: {brojAutomobila}\n");
            txtIspis.AppendText($"Ukupan broj kamiona: {brojKamiona}\n");
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            string model = txtModel.Text;
            int godina;
            int brojKotaca;

            if (!int.TryParse(textBox3.Text, out godina))
            {
                MessageBox.Show("Molimo unesite ispravnu godinu proizvodnje.");
                return;
            }

            if (!int.TryParse(textBox4.Text, out brojKotaca) || brojKotaca < 2 || brojKotaca % 2 != 0)
            {
                MessageBox.Show("Molimo unesite ispravan broj kotača (samo parni broj veći ili jednak 2).");
                return;
            }
            if (brojKotaca == 2)
            {
                brojMotocikala++;
                txtIspis.AppendText($"{model} je motor.\n");
            }

            else if (brojKotaca == 4)
            {
                brojAutomobila++;
                txtIspis.AppendText($"{model} je automobil.\n");
            }
            else
            {
                brojKamiona++;
                txtIspis.AppendText($"{model} je kamion.\n");
            }
        }
    }
}
