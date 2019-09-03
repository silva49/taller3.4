using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, nota5,total;

            nota1 = double.Parse(txtnota1.Text);
            nota2 = double.Parse(txtnota2.Text);
            nota3 = double.Parse(txtnota3.Text);
            nota4 = double.Parse(txtnota4.Text);
            nota5 = double.Parse(txtnota5.Text);

            total = ((nota1 + nota2 + nota3 + nota4 + nota5) / 5);
            lbltotal.Text = total.ToString();
            if (total >= 3.5)
            
            {

                MessageBox.Show("¡Has superado la materia!");
            }
            else
            {
                MessageBox.Show("No has superado la materia.");
            }
            
        }
    }
}
