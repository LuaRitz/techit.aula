using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace au1
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (v1t.Text != "" && v2t.Text != "")
            {
                double valor1;
                double valor2;
                double resultado;

                valor1 = Convert.ToDouble(v1t.Text);
                valor2 = Convert.ToDouble(v2t.Text);
                resultado = valor1 / valor2;
                resul.Text = "A divisão dos Valores resultará em " + resultado.ToString();
            }
            else
            {
                MessageBox.Show("Digite os valores!");
                v1t.Focus();
                v2t.Focus();
            }
        }

            private void soma_Click(object sender, EventArgs e)
            {
                if (v1t.Text != "" && v2t.Text != "")
                {
                    double valor1;
                    double valor2;
                    double resultado;

                    valor1 = Convert.ToDouble(v1t.Text);
                    valor2 = Convert.ToDouble(v2t.Text);
                    resultado = valor1 + valor2;
                    resul.Text = "A soma dos Valores resultará em " + resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Digite os valores!");
                    v1t.Focus();
                    v2t.Focus();
                }
            }
        

            private void sub_Click(object sender, EventArgs e)
            {
                if (v1t.Text != "" && v2t.Text != "")
                {
                    double valor1;
                    double valor2;
                    double resultado;

                    valor1 = Convert.ToDouble(v1t.Text);
                    valor2 = Convert.ToDouble(v2t.Text);
                    resultado = valor1 - valor2;
                    resul.Text = "A subtração dos Valores resultará em " + resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Digite os valores!");
                    v1t.Focus();
                    v2t.Focus();
                }
            }

            private void mult_Click(object sender, EventArgs e)
            {
                if (v1t.Text != "" && v2t.Text != "")
                {
                    double valor1;
                    double valor2;
                    double resultado;

                    valor1 = Convert.ToDouble(v1t.Text);
                    valor2 = Convert.ToDouble(v2t.Text);
                    resultado = valor1 * valor2;
                    resul.Text = "A multiplicação dos Valores resultará em " + resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Digite os valores!");
                    v1t.Focus();
                    v2t.Focus();
                }
            }
        
    }
}
