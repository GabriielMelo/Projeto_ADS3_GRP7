﻿using System.Data;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PrototipoProjetoInterdisciplinar.Controllers
{
    public class ConexaoBDModel
    {
        private MySqlConnection? mConn;
        private DataSet? mDataSet;
        // private MySqlDataAdapter mAdapter;
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
