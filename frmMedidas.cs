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
    public partial class frmMedidas : Form
    {
        public frmMedidas()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtCtoF.Text != "")
            {
                txtFtoC.Text = Convert.ToString(Convert.ToDouble(txtCtoF.Text)*1.8 +32);
            }
            else if (txtFtoC.Text != "")
            {
                txtCtoF.Text = Convert.ToString((Convert.ToDouble(txtFtoC.Text)-32) * 5 / 9);
            }
            if (txtCtoK.Text != "")
            {
                txtKtoC.Text = Convert.ToString(Convert.ToDouble(txtCtoK.Text)+273.15);
            }
            else if (txtKtoC.Text != "")
            {
                txtCtoK.Text = Convert.ToString(Convert.ToDouble(txtKtoC.Text) - 273.15);
            }
            if (txtFtoK.Text != "")
            {
                txtKtoF.Text = Convert.ToString(((Convert.ToDouble(txtFtoK.Text) - 32) * 5 / 9) +273.15);
            }
            else if (txtKtoF.Text != "")
            {
                txtFtoK.Text = Convert.ToString((Convert.ToDouble(txtKtoF.Text) - 273.15) * 1.8 +32);
            }
            if (txtMetoPe.Text != "")
            {
                txtPetoMe.Text = Convert.ToString(Convert.ToDouble(txtMetoPe.Text)/0.304);
            }
            else if (txtPetoMe.Text != "")
            {
                txtMetoPe.Text = Convert.ToString(Convert.ToDouble(txtPetoMe.Text)*0.304);
            }
            if (txtKmtoMi.Text != "")
            {
                txtMitoKm.Text = Convert.ToString(Convert.ToDouble(txtKmtoMi.Text) /1.609);
            }
            else if (txtMitoKm.Text != "")
            {
                txtKmtoMi.Text = Convert.ToString(Convert.ToDouble(txtMitoKm.Text) *1.609);
            }
            if (txtCmtoPo.Text != "")
            {
                txtPotoCm.Text = Convert.ToString(Convert.ToDouble(txtCmtoPo.Text)/2.54);
            }
            else if (txtPotoCm.Text != "")
            {
                txtCmtoPo.Text = Convert.ToString(Convert.ToDouble(txtPotoCm.Text)*2.54);
            }
        }
    }
}
