using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01
{
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }

        private void frmSobre_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnFecharSobre_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
