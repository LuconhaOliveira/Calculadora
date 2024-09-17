namespace Calculadora
{
    public partial class frmLoading : Form
    {
        int load = 0;
        public frmLoading()
        {
            InitializeComponent();
        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            if (pgbLoading.Value >= 7)
            {
                tmrLoading.Enabled = false;
                this.Hide();
                new frmCalculadora().ShowDialog();
            }
            else
            {
                pgbLoading.Value++;
            }
        }
    }
}
