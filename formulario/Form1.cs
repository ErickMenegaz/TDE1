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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bntCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtEmail.Text = "";
            mskDataNasc.Text = "";
            mskCPF.Text = "";
            mskCelular.Text = "";
            cmbEstado.SelectedIndex = -1;
            txtCidade.Text = "";
            txtEndereco.Text = "";
            txtN.Text = "";
            txtBairro.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string genero;
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            string email = txtEmail.Text;
            string data = mskDataNasc.Text;
            string cpf = mskCPF.Text;
            string celular = mskCelular.Text;
            string estado = cmbEstado.GetItemText(cmbEstado.SelectedItem);
            string cidade = txtCidade.Text;
            string endereço = txtEndereco.Text;
            string n = txtN.Text;
            string bairro = txtBairro.Text;

            if (rdbMasc.Checked)
            {
                genero = "Masculino";
            }
            else
            {
                if (rdbFame.Checked)
                {
                    genero = "Femenino";
                }
                else
                {
                    genero = "Outros";
                }
            }

            MessageBox.Show("Nome: " + nome + 
                            ", Sobrenome: " + sobrenome +
                            ", E-mail: " + email +
                            ", Data: " + data +
                            ", CPF: " + cpf +
                            ", Celular: " + celular +
                            ", Sexo: " + genero + 
                            ", Estado: " + estado +
                            ", Cidade: " + cidade +
                            ", Endereço: " + endereço +
                            ", N°: " + n +
                            ", Bairro:" + bairro);

            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtEmail.Text = "";
            mskDataNasc.Text = "";
            mskCPF.Text = "";
            mskCelular.Text = "";
            cmbEstado.SelectedIndex = -1;
            txtCidade.Text = "";
            txtEndereco.Text = "";
            txtN.Text = "";
            txtBairro.Text = "";       
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtSobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
    }
}
