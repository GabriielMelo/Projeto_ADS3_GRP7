﻿using MySql.Data.MySqlClient;
using PrototipoProjetoInterdisciplinar.Controller;
using PrototipoProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoProjetoInterdisciplinar.Controllers
{
    public class CadastroClienteController
    {
        ConexaoBDModel conn = new();

        public bool CadastrarCliente(ClienteModel cliente)
        {
            try
            {
                conn.Conectar();
                string sql = "INSERT INTO clientes (nome,documento,endereco,modeloCarro,telefone,placaCarro) " +
                    "VALUES (@nome,@documento,@endereco,@modeloCarro,@telefone,@placaCarro)";

                MySqlCommand command = new(sql,conn.ObterConexao());

                command.Parameters.AddWithValue("@nome", cliente.Nome);
                command.Parameters.AddWithValue("@documento", cliente.Documento);
                command.Parameters.AddWithValue("@endereco", cliente.Endereco);
                command.Parameters.AddWithValue("@modeloCarro", cliente.ModeloCarro);
                command.Parameters.AddWithValue("telefone", cliente.Telefone);
                command.Parameters.AddWithValue("@placaCarro", cliente.PlacaCarro);

                int count = command.ExecuteNonQuery();

                if(count>0)
                {
                    
                    return true;

                } else
                {
                    
                    return false;
                }


            } catch (Exception ex) {
                MessageBox.Show("Erro ao cadastrar Cliente!", ex.Message);
                return false;
            } 
            finally
            {
                conn.FecharConexao();
            }

        }
        public bool BuscarCliente(string nome)
        {
            try
            {
                conn.Conectar();
                string sql = "SELECT * FROM clientes WHERE NOME LIKE @nome";

                MySqlCommand command = new(sql, conn.ObterConexao());
                command.Parameters.AddWithValue("@nome", "%" + nome + "%");
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int id_cliente = (int)reader["id"];

                    ClienteModel cdCliente = new()
                    {
                        Nome = reader["nome"].ToString(),
                        Documento = reader["documento"].ToString(),
                        Endereco = reader["endereco"].ToString(),
                        Telefone = reader["telefone"].ToString(),
                        ModeloCarro = reader["modeloCarro"].ToString(),
                        PlacaCarro = reader["placaCarro"].ToString()
                    };
                    DialogResult result = MessageBox.Show("Deseja Confirmar reserva?", "Confirmação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        TransacaoModel transacao = new()
                        {
                            Id_Cliente = id_cliente,
                            Data_Transacao = DateTime.Now.ToString("yyyy-MM-dd HH"),
                            Valor = 0,
                            Descricao = "Transacao OK, Ex: de transacao"
                        };
                        TransacaoController efetuaTransacao = new();

                        bool transacaoOk = efetuaTransacao.EfetuarTransacao(transacao);

                        return transacaoOk;
                    }
                    else
                    {
                        return false; 
                    }
                } else
                {
                    MessageBox.Show(" Cliente não Cadastrado!");
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Cliente não Cadastrado " + ex.Message);
                return false;
            }
            finally
            {
                conn.FecharConexao();
            }
        }
    }
}
