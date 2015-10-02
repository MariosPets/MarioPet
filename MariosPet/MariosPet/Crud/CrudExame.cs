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
    class CrudExame
    {
        public void inserirExame(Exame exame)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {



                string sql = "insert into EXAME (ID, ID_ANIMAL, DATA, EXAME, ID_VETERINARIO, ID_LABORATORIO) values(?,?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", exame.id_exame);
                command.Parameters.AddWithValue("@ID_ANIMAL", exame.id_animal);
                command.Parameters.AddWithValue("@DATA", exame.data_exame);
                command.Parameters.AddWithValue("@EXAME", exame.exame);
                command.Parameters.AddWithValue("@ID_VETERINARIO", exame.id_veterinario);
                command.Parameters.AddWithValue("@ID_LABORATORIO", exame.id_laboratorio);


                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaExame(string sql)
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

        public void alteraExame(Exame exame)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update EXAME set ID_ANIMAL = ?, DATA = ?, EXAME = ?, ID_VETERINARIO = ?, ID_LABORATORIO = ? where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", exame.id_animal);
                command.Parameters.AddWithValue("@DATA", exame.data_exame);
                command.Parameters.AddWithValue("@EXAME", exame.exame);
                command.Parameters.AddWithValue("@ID_VETERINARIO", exame.id_veterinario);
                command.Parameters.AddWithValue("@ID_LABORATORIO", exame.id_laboratorio);
                command.Parameters.AddWithValue("@ID", exame.id_exame);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiExame(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete EXAME where ID_EXAME = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_EXAME", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
