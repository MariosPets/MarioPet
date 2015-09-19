using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudFuncionario
    {
        public void inserirFornecedor(Funcionario funcionario)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {

                string sql = "insert into FUNCIONARIO (ID_FUNCIONARIO, ID_PESSOA, TIPO_FUNCIONARIO, LOGIN, SENHA) values(?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_FUNCIONARIO", funcionario.id_funcionario);
                command.Parameters.AddWithValue("@ID_PESSOA", funcionario.id_pessoa);
                command.Parameters.AddWithValue("@TIPO_FUNCIONARIO", funcionario.tipo_funcionario);
                command.Parameters.AddWithValue("@LOGIN", funcionario.login);
                command.Parameters.AddWithValue("@SENHA", funcionario.senha);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaFuncionario(string sql)
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

        public void alteraFuncionario(Funcionario funcionario)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update FUNCIONARIO set ID_PESSOA = ?, TIPO_FUNCIONARIO = ?, LOGIN = ?, SENHA = ? where ID_FUNCIONARIO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA", funcionario.id_pessoa);
                command.Parameters.AddWithValue("@TIPO_FUNCIONARIO", funcionario.tipo_funcionario);
                command.Parameters.AddWithValue("@LOGIN", funcionario.login);
                command.Parameters.AddWithValue("@SENHA", funcionario.senha);
                command.Parameters.AddWithValue("@ID_FUNCIONARIO", funcionario.id_funcionario);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiFuncionario(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete FUNCIONARIO where ID_FUNCIONARIO = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_FUNCIONARIO", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
