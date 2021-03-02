using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class CALCULADORA : Form
    {
        double numero1, numero2, resultado;
        public CALCULADORA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBoxResult.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out numero1) &&
                 double.TryParse(textBox2.Text, out numero2))
            {
                resultado = numero1 + numero2;
                textBoxResult.Text = Convert.ToString(resultado);
            }
            else

                MessageBox.Show("Informação Inválida");
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out numero1) &&
                 double.TryParse(textBox2.Text, out numero2))
            {
                resultado = numero1 - numero2;
                textBoxResult.Text = Convert.ToString(resultado);
            }
            else

                MessageBox.Show("Informação Inválida");
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out numero1) &&
                double.TryParse(textBox2.Text, out numero2))
            {
                resultado = numero1 * numero2;
                textBoxResult.Text = Convert.ToString(resultado);
            }
            else

                MessageBox.Show("Informação Inválida");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CALCULADORA_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out numero1) &&
                double.TryParse(textBox2.Text, out numero2))
            {
                resultado = numero1 / numero2;
                textBoxResult.Text = Convert.ToString(resultado);
            }
            else

                MessageBox.Show("Informação Inválida");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
