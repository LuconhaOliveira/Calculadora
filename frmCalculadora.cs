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
    public partial class frmCalculadora : Form
    {
        double num1;
        bool alreadyDot = false;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "") { }
            else
            {
                txtVisor.Text = $"{txtVisor.Text}{0}";
            }
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisor.Text = $"{txtVisor.Text}{1}";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisor.Text = $"{txtVisor.Text}{2}";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisor.Text = $"{txtVisor.Text}{3}";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisor.Text = $"{txtVisor.Text}{4}";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisor.Text = $"{txtVisor.Text}{5}";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisor.Text = $"{txtVisor.Text}{6}";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisor.Text = $"{txtVisor.Text}{7}";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisor.Text = $"{txtVisor.Text}{8}";
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            txtVisor.Text = $"{txtVisor.Text}{9}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.Length > 0)
            {
                txtVisor.Text = txtVisor.Text.Substring(0, txtVisor.Text.Length - 1);
            }
        }

        private void btnDot_Click_1(object sender, EventArgs e)
        {
            if (alreadyDot == false)
            {
                string dot = ".";
                txtVisor.Text = $"{txtVisor.Text}{dot}";
                alreadyDot = true;
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtVisor.Text);
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtVisor.Text);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtVisor.Text);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtVisor.Text);
        }
    }
}
