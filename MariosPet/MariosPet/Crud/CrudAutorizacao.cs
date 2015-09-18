using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudAutorizacao
    {
        public void inserirAutorizacao(Autorizacao autorizacao)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {

                string sql = "insert into AUTORIZACAO (ID_AUTORIZACAO, ID_ANIMAL, AUTORIZACAO) values(?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_AUTORIZACAO", autorizacao.id_autorizacao);
                command.Parameters.AddWithValue("@ID_ANIMAL", autorizacao.id_animal);
                command.Parameters.AddWithValue("@AUTORIZACAO", autorizacao.autorizacao);


                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaAutorizacao(string sql)
        {
            DataTable tabela = new DataTable();
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                conexao.Open();
                OdbcDataAdapter data = new OdbcDataAdapter(sql, conexao);
                OdbcCommand command = new OdbcCommand(sql, conexao);
                data.Fill(tabela);
                return tabela;
            }
        }

        public void alteraAutorizacao(Autorizacao autorizacao)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update AUTORIZACAO set ID_ANIMAL = ?, AUTORIZACAO = ? where ID_AUTORIZACAO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", autorizacao.id_animal);
                command.Parameters.AddWithValue("@AUTORIZACAO", autorizacao.autorizacao);
                command.Parameters.AddWithValue("@ID_AUTORIZACAO", autorizacao.id_autorizacao);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiAutorizacao(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete AUTORIZACAO where ID_AUTORIZACAO = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_AUTORIZACAO", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
