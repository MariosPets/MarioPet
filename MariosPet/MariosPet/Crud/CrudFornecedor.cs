using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudFornecedor
    {
        public void inserirFornecedor(Fornecedor fornecedor)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {

                string sql = "insert into FORNECEDOR (ID_FORNECEDOR, ID_PESSOA_JURIDICA, RAMO_ATIVIDADE, CONTATO_FORNECEDOR) values(?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_FORNECEDOR", fornecedor.id_fornecedor);
                command.Parameters.AddWithValue("@ID_PESSOA_JURIDICA", fornecedor.id_pessoa_juridica);
                command.Parameters.AddWithValue("@RAMO_ATIVIDADE", fornecedor.ramo_atividade);
                command.Parameters.AddWithValue("@CONTATO_FORNECEDOR", fornecedor.contato_fornecedor);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaFornecedor(string sql)
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

        public void alteraFornecedor(Fornecedor fornecedor)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update FORNECEDOR set ID_PESSOA_JURIDICA = ?, RAMO_ATIVIDADE = ?, CONTATO_FORNECEDOR = ? where ID_FORNECEDOR = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA_JURIDICA", fornecedor.id_pessoa_juridica);
                command.Parameters.AddWithValue("@RAMO_ATIVIDADE", fornecedor.ramo_atividade);
                command.Parameters.AddWithValue("@CONTATO_FORNECEDOR", fornecedor.contato_fornecedor);
                command.Parameters.AddWithValue("@ID_FORNECEDOR", fornecedor.id_fornecedor);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiFornecedor(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete FORNECEDOR where ID_FORNECEDOR = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_FORNECEDOR", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
