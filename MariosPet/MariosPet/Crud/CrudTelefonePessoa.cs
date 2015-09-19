using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudTelefonePessoa
    {
        public void inserirTelefonePessoa(TelefonePessoa telefonepessoa)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {

                string sql = "insert into TELEFONE_PESSOA (ID_TELEFONE_PESSOA, ID_PESSOA, TELEFONE_PESSOA) values(?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_TELEFONE_PESSOA", telefonepessoa.id_telefone_pessoa);
                command.Parameters.AddWithValue("@ID_PESSOA", telefonepessoa.id_pessoa);
                command.Parameters.AddWithValue("@TELEFONE_PESSOA", telefonepessoa.telefone_pessoa);


                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaTelefonePessoa(string sql)
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

        public void alteraTelefonePessoa(TelefonePessoa telefonepessoa)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update TELEFONE_PESSOA set ID_PESSOA = ?, TELEFONE_PESSOA = ? where ID_TELEFONE_PESSOA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA", telefonepessoa.id_pessoa);
                command.Parameters.AddWithValue("@TELEFONE_PESSOA", telefonepessoa.telefone_pessoa);
                command.Parameters.AddWithValue("@ID_TELEFONE_PESSOA", telefonepessoa.id_telefone_pessoa);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiTelefonePessoa(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete TELEFONE_PESSOA where ID_TELEFONE_PESSOA = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_TELEFONE_PESSOA", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
