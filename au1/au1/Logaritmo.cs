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
    public partial class Logaritmo : Form
    {
        public Logaritmo()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Lua" & textBox2.Text == "123")
            {
                Pri pri = new Pri();
                pri.ShowDialog();
            }
            else
            {
                MessageBox.Show("Dados inválidos");
            }
        }
    }
}
