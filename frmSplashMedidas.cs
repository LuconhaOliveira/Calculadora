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
    public partial class frmSplashMedidas : Form
    {
        public frmSplashMedidas()
        {
            InitializeComponent();
        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            if (pgbLoading.Value >= 7)
            {
                tmrLoading.Enabled = false;
                this.Hide();
                new frmMedidas().ShowDialog();
            }
            else
            {
                pgbLoading.Value++;
            }
        }
    }
}
