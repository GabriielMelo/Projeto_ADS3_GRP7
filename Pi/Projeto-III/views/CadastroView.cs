using Projeto_Interdisciplinar_III.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Interdisciplinar_III
{
    public partial class CadastroView : Form
    {
        public CadastroView()
        {
            InitializeComponent();
        }
        private HomeView formHome;

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (formHome == null || formHome.IsDisposed)
            {
                formHome = new HomeView();
            }

            formHome.Show();
            this.Hide();
        }

        public bool confirmarSenha()
        {
            if (txtSenha.Text.Trim() == txtSenhaConfirm.Text.Trim())
            {
                return true;
            }
            else
            {
                MessageBox.Show("As senhas devem ser iguais!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtUsuario.Focus();
            }
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
                btnCadastrar.Focus();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.confirmarSenha();
            if (txtNome.Text == String.Empty || txtUsuario.Text == String.Empty || txtSenha.Text == String.Empty)
            {
                MessageBox.Show("Preencha todos os campos corretamente!", "Atenção!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string nome = txtNome.Text.Trim();
                string usuario = txtUsuario.Text.Trim();
                string senha = txtSenha.Text.Trim();
                CadastroBD cadastroFuncionario = new CadastroBD();
                cadastroFuncionario.CadastroFuncionario(nome, usuario, senha);

            }
        }
    }

}

