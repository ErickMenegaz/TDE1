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

            MessageBox.Show("Nome: " + nome + 
                            ", Sobrenome: " + sobrenome +
                            ", E-mail: " + email +
                            ", Data: " + data +
                            ", CPF: " + cpf +
                            ", Celular: " + celular +
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
    }
}
