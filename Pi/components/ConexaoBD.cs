
using System.Data;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Projeto_Interdisciplinar_III.components
{
    public class ConexaoBD
    {


        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        public void Conectar()

        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection("Persist Security Info=false;" +
                                        "server = localhost;" +
                                        "database = estacionamento;" +
                                        "uid = root; pwd = root; ");

            try
            {
                mConn.Open();
                MessageBox.Show("Conexão bem-sucedida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexão falhou ", ex.ToString());
            }

        }

        public MySqlConnection ObterConexao()
        {
            return mConn;
        }

        public void FecharConexao()
        {
            if (mConn != null && mConn.State == ConnectionState.Open)
            {
                mConn.Close();
            }
        }

    }
}
