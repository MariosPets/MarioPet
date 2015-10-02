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
    class CrudTelefonePessoaJuridica
    {
        public void inserirTelefonePessoaJuridica(TelefonePessoa telefonepessoajuridica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into TELEFONE_PESSOA_JURIDICA (ID, ID_PESSOA_JURIDICA, TELEFONE) values(?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", telefonepessoajuridica.id_telefone_pessoa_juridica);
                command.Parameters.AddWithValue("@ID_PESSOA_JURIDICA", telefonepessoajuridica.id_pessoa_juridica);
                command.Parameters.AddWithValue("@TELEFONE", telefonepessoajuridica.telefone_pessoa_juridica);


                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaTelefonePessoaJuridica(string sql)
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

        public void alteraTelefonePessoaJuridica(TelefonePessoaJuridica telefonepessoajuridica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update TELEFONE_PESSOA_JURIDICA set ID_PESSOA_JURIDICA = ?, TELEFONE = ? where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA_JURIDICA", telefonepessoajuridica.id_pessoa_juridica);
                command.Parameters.AddWithValue("@TELEFONE", telefonepessoajuridica.telefone_pessoa_juridica);
                command.Parameters.AddWithValue("@ID", telefonepessoajuridica.id_telefone_pessoa_juridica);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiTelefonePessoaJuridica(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete TELEFONE_PESSOA_JURIDICA where ID_TELEFONE_PESSOA_JURIDICA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_TELEFONE_PESSOA_JURIDICA", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
