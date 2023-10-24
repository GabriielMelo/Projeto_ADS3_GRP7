using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Projeto_Interdisciplinar_III.components
{
    internal class CadastroBD
    {

        ConexaoBD conn = new ConexaoBD();


        public bool CadastroFuncionario(string nome, string usuario,string senha)
        {

            try
            {
                conn.Conectar();
                string sql = "INSERT INTO funcionario (nome,usuario,senha) VALUES (@nome,@usuario,@senha)";

                MySqlCommand command = new MySqlCommand(sql, conn.ObterConexao());

                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@senha", senha);

                int count = command.ExecuteNonQuery();

                if(count > 0 )
                {
                    MessageBox.Show("Funcionario Cadastrado com sucesso");
                    return true;

                } else
                {
                    MessageBox.Show("Erro ao cadastrar o funcionario");
                    return false;
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar",ex.Message);
                return false;

            }
            finally
            {
                conn.FecharConexao();

            }
            

        }


    }
}
