using System;
using System.Windows.Forms;
using Projeto_Interdisciplinar_III.components;

namespace Projeto_Interdisciplinar_III


{
    public partial class HomeView : Form

    {

        ConexaoBD conn = new ConexaoBD();
        public HomeView()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }
        private CadastroView formCadastro;

        private void btnCadastro_Click(object sender, EventArgs e)
        {

            if (formCadastro == null || formCadastro.IsDisposed)
            {
                formCadastro = new CadastroView();
            }

            formCadastro.Show();
            this.Hide();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();
            Autenticacao autenticar = new Autenticacao();
            autenticar.validarUsuario(usuario, senha);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin.Focus();
            }
        }
    }
}