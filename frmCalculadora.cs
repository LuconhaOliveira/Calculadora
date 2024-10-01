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
        string operador;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "0") 
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
                txtVisor.Text = $"{txtVisor.Text}{","}";
                alreadyDot = true;
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtVisor.Text);
            txtVisor.Text = "";
            operador = "+";
            alreadyDot = false;
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtVisor.Text);
            txtVisor.Text = "";
            operador = "-";
            alreadyDot = false;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtVisor.Text);
            txtVisor.Text = "";
            operador = "*";
            alreadyDot = false;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtVisor.Text);
            txtVisor.Text = "";
            operador = "/";
            alreadyDot = false;
        }


        private void btnEqual_Click_1(object sender, EventArgs e)
        {
            if (txtVisor.Text.Contains("%"))
            {
                if (operador == "+")
                {
                    txtVisor.Text = (num1 + (Convert.ToDouble(txtVisor.Text) / 100 * num1)).ToString();
                }
                if (operador == "-")
                {
                    txtVisor.Text = (num1 - (Convert.ToDouble(txtVisor.Text) / 100 * num1)).ToString();
                }
                if (operador == "*")
                {
                    txtVisor.Text = (num1 * (Convert.ToDouble(txtVisor.Text) / 100)).ToString();
                }
                if (operador == "/")
                {
                    txtVisor.Text = (num1 / (Convert.ToDouble(txtVisor.Text) / 100)).ToString();
                }
            }
            else
            {
                if (operador == "+")
                {
                    txtVisor.Text = (num1 + Convert.ToDouble(txtVisor.Text)).ToString();
                }
                if (operador == "-")
                {
                    txtVisor.Text = (num1 - Convert.ToDouble(txtVisor.Text)).ToString();
                }
                if (operador == "*")
                {
                    txtVisor.Text = (num1 * Convert.ToDouble(txtVisor.Text)).ToString();
                }
                if (operador == "/")
                {
                    txtVisor.Text = (num1 / Convert.ToDouble(txtVisor.Text)).ToString();
                }
            }
            num1 = Convert.ToDouble(txtVisor.Text);
            if (txtVisor.Text.Contains(","))
            {
                alreadyDot = true;
            }
            else
            {
                alreadyDot = false;
            }
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            txtVisor.Text = $"{txtVisor.Text}{"%"}";
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0" || txtVisor.Text == "")
            {
                txtVisor.Text = "-";
            }
            else if (txtVisor.Text == "-")
            {
                txtVisor.Text = "";
            }
            else
            {
                double negativo = Convert.ToDouble(txtVisor.Text);
                txtVisor.Text = (negativo - (negativo * 2)).ToString();
            }
        }

        private void btnTransforma_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMedidas().ShowDialog();
        }
    }
}
