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
    public partial class aluno : Form
    {
        public aluno()
        {
            InitializeComponent();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            if (nomet.Text == "" || emailt.Text == "")
            {
                MessageBox.Show("algum dado está vazio!");
            }
            else { 
            MessageBox.Show("aluno cadastrado: " + nomet.Text + "\n email cadastrado: " +emailt.Text);
            }
        }

        private void casat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fonet_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailt_TextChanged(object sender, EventArgs e)
        {

        }

        private void rgt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
