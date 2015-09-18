using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudFichaClinica
    {
        public void inserirFichaClinica(FichaClinica fichaclinica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {

                string sql = "insert into FICHA_CLINICA (ID_FICHA_CLINICA, ID_ANIMAL, ID_VETERINARIO, DATA_FICHA_CLINICA) values(?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_FICHA_CLINICA", fichaclinica.id_ficha_clinica);
                command.Parameters.AddWithValue("@ID_ANIMAL", fichaclinica.id_animal);
                command.Parameters.AddWithValue("@ID_VETERINARIO", fichaclinica.id_veterinario);
                command.Parameters.AddWithValue("@DATA_FICHA_CLINICA", fichaclinica.data_ficha_clinica);


                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaFichaClinica(string sql)
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

        public void alteraFichaClinica(FichaClinica fichaclinica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update FICHA_CLINICA set ID_ANIMAL = ?, ID_VETERINARIO = ?, DATA_FICHA_CLINICA = ? where ID_FICHA_CLINICA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", fichaclinica.id_animal);
                command.Parameters.AddWithValue("@ID_VETERINARIO", fichaclinica.id_veterinario);
                command.Parameters.AddWithValue("@DATA_FICHA_CLINICA", fichaclinica.data_ficha_clinica);
                command.Parameters.AddWithValue("@ID_FICHA_CLINICA", fichaclinica.id_ficha_clinica);


                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiFichaClinica(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete FICHA_CLINICA where ID_FICHA_CLINICA = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_FICHA_CLINICA", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
