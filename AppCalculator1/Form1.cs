using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdunare_Click(object sender, EventArgs e)
        {
            int A;
            int B;
            int suma;

            if(int.TryParse(txtA.Text, out A) && int.TryParse(txtB.Text, out B))
            {
                suma = A + B;
                MessageBox.Show("Suma dintre " + A + " si " + B + " este " + suma);
            }
            else
            {
                MessageBox.Show("A si B trebuie sa fie nemere intregi");
            }
        }

        private void btnScadere_Click(object sender, EventArgs e)
        {
            int A;
            int B;
            int scadere;

            if (int.TryParse(txtA.Text, out A) && int.TryParse(txtB.Text, out B))
            {
                scadere = A - B;
                MessageBox.Show("Diferenta dintre " + A + " si " + B + " este " + scadere);
            }
            else
            {
                MessageBox.Show("A si B trebuie sa fie nemere intregi");
            }
        }

        private void btnInmultire_Click(object sender, EventArgs e)
        {
            int A;
            int B;
            int inmultire;

            if (int.TryParse(txtA.Text, out A) && int.TryParse(txtB.Text, out B))
            {
                inmultire = A * B;
                MessageBox.Show("Produsul dintre " + A + " si " + B + " este " + inmultire);
            }
            else
            {
                MessageBox.Show("A si B trebuie sa fie nemere intregi");
            }
        }

        private void btnImpartire_Click(object sender, EventArgs e)
        {
            double A;
            double B;
            double impartire;

            if (double.TryParse(txtA.Text, out A) && double.TryParse(txtB.Text, out B) && B != 0)
            {
                impartire = A / B;
                MessageBox.Show("Impartirea dintre " + A + " si " + B + " este " + impartire);
            }
            else
            {
                MessageBox.Show("A si B trebuie sa fie numere reale iar B mai mare decat 0");
            }
        }
    }
}
