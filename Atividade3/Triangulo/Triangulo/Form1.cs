using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        double A, B, C, resultado;
        bool triangulo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double.TryParse(textBox1.Text, out A);
            if (A == null) return;

            double.TryParse(textBox2.Text, out B);
            if (B == null) return;

            double.TryParse(textBox3.Text, out C);
            if (C == null) return;



            if ((A < B + C) && (B < A + C) && (C < A + B))
                    {

                        triangulo = true;
                    }

                    else if (triangulo == false)
                    {
                         Console.Write("As medidas usadas não formam um triângulo ");
                    }

                        if ((A == B) && (B == C))
                        {

                            textBox4.Text = resultado.ToString("Triângulo Equilátero");

                        }
                        else if ((A == B) || (B == C) || (A == C))
                        {

                            textBox4.Text = resultado.ToString("Triangulo Isoceles!");
                        }
                        else if ((A != B) && (B != C) && (C != B))
                        {

                            textBox4.Text = resultado.ToString("Triangulo Escaleno!");
                        }
                    }
                }
            }
        
    



