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
    class CrudAnamnese
    {
        public void inserirAnamnese(Anamnese anamnese)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {



                string sql = "insert into ANAMNESE (ID, DESCRICAO) values(?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", anamnese.id);
                command.Parameters.AddWithValue("@DESCRICAO", anamnese.descricao);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaAnamnese(string sql)
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

        public void alteraAnamnese(Anamnese anamnese)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update ANAMNESE set DESCRICAO = ? where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@DESCRICAO", anamnese.descricao);
                command.Parameters.AddWithValue("@ID", anamnese.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiAnamnese(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete ANAMNESE where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
