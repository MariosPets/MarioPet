using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudPessoaJuridica
    {
        public void inserirPessoaJuridica(PessoaJuridica pessoajuridica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {

                string sql = "insert into PESSOAJURIDICA (ID_PESSOA_JURIDICA, DENOMINACAO_SOCIAL, CNPJ, ID_ENDERECO) values(?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA_JURIDICA", pessoajuridica.id_pessoa_juridica);
                command.Parameters.AddWithValue("@DENOMINACAO_SOCIAL", pessoajuridica.denominacao_social);
                command.Parameters.AddWithValue("@CNPJ", pessoajuridica.cnpj);
                command.Parameters.AddWithValue("@ID_ENDERECO", pessoajuridica.id_endereco);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaPessoaJuridica(string sql)
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

        public void alteraPessoaJuridica(PessoaJuridica pessoajuridica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update PESSOA_JURIDICA set ID_PESSOA_JURIDICA = ?, DENOMINACAO_SOCIAL = ?, CNPJ = ?, where ID_ENDERECO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA_JURIDICA", pessoajuridica.id_pessoa_juridica);
                command.Parameters.AddWithValue("@DENOMINACAO_SOCIAL", pessoajuridica.denominacao_social);
                command.Parameters.AddWithValue("@CNPJ", pessoajuridica.cnpj);
                command.Parameters.AddWithValue("@ID_ENDERECO", pessoajuridica.id_endereco);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiCliente(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete PESSOA_JURIDICA where PESSOA_JURIDICA = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_PESSOA JURIDICA", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
