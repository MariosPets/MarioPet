using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudCliente
    {
        public void inserirCliente(Cliente cliente)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {

                string sql = "insert into CLIENTE (ID_CLIENTE, ID_PESSOA) values(?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_CLIENTE", cliente.id_cliente);
                command.Parameters.AddWithValue("@ID_PESSOA", cliente.id_pessoa);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaCliente(string sql)
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

        public void alteraVeterinario(Cliente cliente)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update CLIENTE set ID_CLIENTE = ?, ID_PESSOA = ? where ID_CLIENTE = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_CLIENTE", cliente.id_cliente);
                command.Parameters.AddWithValue("@ID_PESSOA", cliente.id_pessoa);
                command.Parameters.AddWithValue("@ID_CLIENTE", cliente.id_cliente);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiCliente(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete CLIENTE where ID_CLIENTE = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_CLIENTE", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
