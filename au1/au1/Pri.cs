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
    public partial class Pri : Form
    {
        public Pri()
        {
            InitializeComponent();
        }

        private void aluno_Click(object sender, EventArgs e)
        {
          aluno aluno = new aluno();
          aluno.ShowDialog();
        }

        private void prof_Click(object sender, EventArgs e)
        {
            prof prof = new prof();
            prof.ShowDialog();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            calculadora calc = new calculadora();
            calc.ShowDialog();
        }
    }
}
