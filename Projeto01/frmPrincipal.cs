namespace Projeto01
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void btnCad_Click(object sender, EventArgs e)
        {
            frmCadastro cadForm = new frmCadastro();
            cadForm.Show();
        }

        private void btnSobre_Click_1(object sender, EventArgs e)
        {
            frmSobre sobreForm = new frmSobre();
            sobreForm.ShowDialog();
        }
    }
}
