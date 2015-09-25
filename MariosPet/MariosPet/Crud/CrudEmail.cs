using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudEmail
    {
        public void inserirEmail(Classes.Email email)
        {
            using (OdbcConnection conexao = Classes.ConexaoPadrao.createConnection())
            {

                string sql = "insert into EMAIL (ID_EMAIL, EMAIL, ID_PESSOA) values(?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_EMAIL", email.id_email);
                command.Parameters.AddWithValue("@EMAIL", email.email);
                command.Parameters.AddWithValue("@ID_PESSOA", email.id_pessoa);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaVermifugo(string sql)
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

        public void alteraEmail(Email email)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update EMAIL set EMAIL = ?, ID_PESSOA = ? where ID_EMAIL = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@EMAIL", email.email);
                command.Parameters.AddWithValue("@ID_PESSOA", email.id_pessoa);
                command.Parameters.AddWithValue("@ID_EMAIL", email.id_email);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiEmail(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete EMAIL where ID_EMAIL = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_EMAIL", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
