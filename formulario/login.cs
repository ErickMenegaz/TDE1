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
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Campos Obrigatórios");
            }
            else
            {
                if (txtUser.Text == "erick" && txtPass.Text == "menegaz")
                {
                    frmCadastro frm = new frmCadastro();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login falso");
                }
            }
        }
    }
}
