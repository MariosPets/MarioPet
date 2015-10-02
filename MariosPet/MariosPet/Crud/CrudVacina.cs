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
    class CrudVacina
    {
        public void inserirVacina(Vacina vacina)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into VACINA (ID, DATA, ID_ANIMAL, ID_MEDICAMENTO) values(?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", vacina.id);
                command.Parameters.AddWithValue("@DATA", vacina.data_vacina);
                command.Parameters.AddWithValue("@ID_ANIMAL", vacina.id_animal);
                command.Parameters.AddWithValue("@ID_MEDICAMENTO", vacina.id_medicamento);


                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaVacina(string sql)
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

        public void alteraVacina(Vacina vacina)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update VACINA set ID_ANIMAL = ?, ID_MEDICAMENTO = ?, DATA = ?, where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", vacina.id);
                command.Parameters.AddWithValue("@ID_ANIMAL", vacina.id_animal);
                command.Parameters.AddWithValue("@ID_MEDICAMENTO", vacina.id_medicamento);
                command.Parameters.AddWithValue("@DATA_VACINA", vacina.data_vacina);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiVacina(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete VACINA where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
