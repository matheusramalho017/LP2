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
        int A, B, C, resultado;

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

              void checkTriangle(int A, int B, int C)
                {

                    if ((A < B + C) && (B < A + C) && (C < A + B))
                    {

                        Console.Write("Formam triângulo!");

                        if ((A == B) && (B == C))
                        {

                            textBox4.Text = ("Triângulo Equilátero");

                        }
                        else if ((A == B) || (B == C) || (A == C))
                        {

                            textBox4.Text = resultado.ToString("Triangulo Isoceles!");
                        }
                        else if ((A != B) && (B != C) && (C != A))
                        {

                            textBox4.Text = resultado.ToString("Triangulo Escaleno!");
                        }
                    }
                    else
                    {
                        
                        textBox4.Text = resultado.ToString("Os valores não formam um triângulo!");
                    }
                }
                checkTriangle(A, B, C);
            }
        }
    } 
}


