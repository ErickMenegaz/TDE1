using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblCadastre_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastro frm = new frmCadastro();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
