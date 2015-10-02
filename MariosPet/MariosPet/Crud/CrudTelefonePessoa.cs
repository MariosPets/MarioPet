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
    class CrudTelefonePessoa
    {
        public void inserirTelefonePessoa(TelefonePessoa telefonepessoa)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into TELEFONE_PESSOA (ID, ID_PESSOA, TELEFONE) values(?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", telefonepessoa.id_telefone_pessoa);
                command.Parameters.AddWithValue("@ID_PESSOA", telefonepessoa.id_pessoa);
                command.Parameters.AddWithValue("@TELEFONE", telefonepessoa.telefone_pessoa);


                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaTelefonePessoa(string sql)
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

        public void alteraTelefonePessoa(TelefonePessoa telefonepessoa)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update TELEFONE_PESSOA set ID_PESSOA = ?, TELEFONE = ? where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA", telefonepessoa.id_pessoa);
                command.Parameters.AddWithValue("@TELEFONE", telefonepessoa.telefone_pessoa);
                command.Parameters.AddWithValue("@ID", telefonepessoa.id_telefone_pessoa);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiTelefonePessoa(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete TELEFONE_PESSOA where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
