using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cli a = new Cli();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            qua a = new qua();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fin a = new Fin();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Func a = new Func();
            a.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Estoque a = new Estoque();
            a.ShowDialog();
        }
    }
}
