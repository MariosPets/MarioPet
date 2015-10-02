using MariosPet.Classes;
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
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into FORNECEDOR (ID, ID_PESSOA_JURIDICA, RAMO_ATIVIDADE, NOME_CONTATO) values(?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", fornecedor.id_fornecedor);
                command.Parameters.AddWithValue("@ID_PESSOA_JURIDICA", fornecedor.id_pessoa_juridica);
                command.Parameters.AddWithValue("@RAMO_ATIVIDADE", fornecedor.ramo_atividade);
                command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.contato_fornecedor);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaFornecedor(string sql)
        {
            DataTable tabela = new DataTable();
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
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
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update FORNECEDOR set ID_PESSOA_JURIDICA = ?, RAMO_ATIVIDADE = ?, NOME_CONTATO = ? where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA_JURIDICA", fornecedor.id_pessoa_juridica);
                command.Parameters.AddWithValue("@RAMO_ATIVIDADE", fornecedor.ramo_atividade);
                command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.contato_fornecedor);
                command.Parameters.AddWithValue("@ID", fornecedor.id_fornecedor);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiFornecedor(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete FORNECEDOR where ID_FORNECEDOR = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_FORNECEDOR", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
