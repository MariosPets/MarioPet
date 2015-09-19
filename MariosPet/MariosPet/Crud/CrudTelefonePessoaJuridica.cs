using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudTelefonePessoaJuridica
    {
        public void inserirTelefonePessoaJuridica(TelefonePessoa telefonepessoajuridica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {

                string sql = "insert into TELEFONE_PESSOA_JURIDICA (ID_TELEFONE_PESSOA_JURIDICA, ID_PESSOA_JURIDICA, TELEFONE_PESSOA_JURIDICA) values(?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_TELEFONE_PESSOA_JURIDICA", telefonepessoajuridica.id_telefone_pessoa_juridica);
                command.Parameters.AddWithValue("@ID_PESSOA_JURIDICA", telefonepessoajuridica.id_pessoa_juridica);
                command.Parameters.AddWithValue("@TELEFONE_PESSOA_JURIDICA", telefonepessoajuridica.telefone_pessoa_juridica);


                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaTelefonePessoaJuridica(string sql)
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

        public void alteraTelefonePessoaJuridica(TelefonePessoaJuridica telefonepessoajuridica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update TELEFONE_PESSOA_JURIDICA set ID_PESSOA_JURIDICA = ?, TELEFONE_PESSOA_JURIDICA = ? where ID_TELEFONE_PESSOA_JURIDICA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA_JURIDICA", telefonepessoajuridica.id_pessoa_juridica);
                command.Parameters.AddWithValue("@TELEFONE_PESSOA_JURIDICA", telefonepessoajuridica.telefone_pessoa_juridica);
                command.Parameters.AddWithValue("@ID_TELEFONE_PESSOA_JURIDICA", telefonepessoajuridica.id_telefone_pessoa_juridica);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiTelefonePessoaJuridica(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete TELEFONE_PESSOA_JURIDICA where ID_TELEFONE_PESSOA_JURIDICA = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_TELEFONE_PESSOA_JURIDICA", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
