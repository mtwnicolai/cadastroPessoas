namespace Projeto01
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobreForm = new frmSobre();
            sobreForm.ShowDialog();
        }
    }
}
