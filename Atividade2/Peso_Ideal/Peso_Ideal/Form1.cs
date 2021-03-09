using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peso_Ideal
{
    public partial class Form1 : Form
    {
        double altura, peso, peso_ideal;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {   

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(maskedTextBox1.Text, out altura);
            if (altura == null) return;

            peso_ideal = 0;

            if (radioButton1.Checked)
            {
                peso_ideal = (72.7 * altura) - 58;
            }
            else
            {
                peso_ideal = (62.7 * altura) - 44.7;
            }

            StringBuilder str = new StringBuilder("Peso ideal: " + peso_ideal.ToString("0.00") + "Kg.");

            if (maskedTextBox2.Text != "")
            {
                double.TryParse(maskedTextBox2.Text, out peso);
                if (peso != null)
                {
                    if (peso_ideal < peso)
                    {
                        str.Append(Environment.NewLine + (" Regime Obrigatório Já"));
                    }
                    else if (peso_ideal > peso)
                    {
                        str.Append(Environment.NewLine + (" Coma bastante massas e doces"));
                    }
                    else if (peso_ideal == peso)
                    {
                        str.Append(Environment.NewLine + (" Você está com o peso ideal"));
                    }
                }
            }
            textBox3.Text = peso_ideal.ToString();
            MessageBox.Show(str.ToString());
        }
    }
}


