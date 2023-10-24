using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Interdisciplinar_III.components
{
    public class Autenticacao
    {
        ConexaoBD conn = new ConexaoBD();

        public bool validarUsuario(string usuario,string senha)
        {
            if (usuario == String.Empty || senha == String.Empty)
            {
                MessageBox.Show("Usuario ou senha não podem estar vazios","Atencao!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return false;
            } else {
            try
            {
                conn.Conectar();
                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM Funcionario WHERE usuario = " +
                    "@usuario AND senha = @senha",conn.ObterConexao());
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@senha", senha);
                
                int count = Convert.ToInt32(command.ExecuteScalar());

                if(count == 1)
                {
                    MessageBox.Show("Acesso Autorizado", "Credenciais Ok!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return count == 1;
                    } else
                    {
                        MessageBox.Show("Erro ao validar credenciais","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return false;
                    }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar credenciais", ex.Message);
                return false;
            }
            finally
            {
                conn.FecharConexao();
            }

            

        }
        }


    }
}
