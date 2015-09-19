using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudProntuario
    {
        public void inserirProntuario(Prontuario prontuario)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {

                string sql = "insert into PRONTUARIO (ID_PRONTUARIO, ID_ANIMAL, PRONTUARIO) values(?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PRONTUARIO", prontuario.id_prontuario);
                command.Parameters.AddWithValue("@ID_ANIMAL", prontuario.id_animal);
                command.Parameters.AddWithValue("@PRONTUARIO", prontuario.prontuario);


                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaProntuario(string sql)
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

        public void alteraProntuario(TelefonePessoa telefonepessoa)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update PRONTUARIO set ID_ANIMAL = ?, PRONTUARIO = ? where ID_PRONTUARIO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", prontuario.id_animal);
                command.Parameters.AddWithValue("@PRONTUARIO", prontuario.prontuario);
                command.Parameters.AddWithValue("@ID_PRONTUARIO", prontuario.id_prontuario);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiProntuario(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete PRONTUARIO where ID_PRONTUARIO = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_PRONTUARIO", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
