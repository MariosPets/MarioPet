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
    class CrudFichaClinica
    {
        public void inserirFichaClinica(FichaClinica fichaclinica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into FICHA_CLINICA (ID, ID_ANIMAL, ID_VETERINARIO, DATA_FICHA_CLINICA, HISTORICO_CLINICO, SINTOMAS, SISTEMAS_ACOMETIDOS, EXAMES_COMPLEMENTARES, PRESCRICAO) values(?,?,?,?,?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", fichaclinica.id_ficha_clinica);
                command.Parameters.AddWithValue("@ID_ANIMAL", fichaclinica.id_animal);
                command.Parameters.AddWithValue("@ID_VETERINARIO", fichaclinica.id_veterinario);
                command.Parameters.AddWithValue("@DATA_FICHA_CLINICA", fichaclinica.data_ficha_clinica);
                command.Parameters.AddWithValue("@HISTORICO_CLINICO", fichaclinica.historico_clinico);
                command.Parameters.AddWithValue("@SINTOMAS", fichaclinica.sintomas);
                command.Parameters.AddWithValue("@SISTEMAS_ACOMETIDOS", fichaclinica.sistemas_acometidos);
                command.Parameters.AddWithValue("@EXAMES_COMPLEMENTARES", fichaclinica.exames_complementares);
                command.Parameters.AddWithValue("@PRESCRICAO", fichaclinica.prescricao);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaFichaClinica(string sql)
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

        public void alteraFichaClinica(FichaClinica fichaclinica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update FICHA_CLINICA set ID_ANIMAL = ?, ID_VETERINARIO = ?, DATA_FICHA_CLINICA = ?, HISTORICO_CLINICO = ?, SINTOMAS = ?, SISTEMAS_ACOMETIDOS = ?, EXAMES_COMPLEMENTARES = ?, PRESCRICAO = ?, where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", fichaclinica.id_animal);
                command.Parameters.AddWithValue("@ID_VETERINARIO", fichaclinica.id_veterinario);
                command.Parameters.AddWithValue("@DATA_FICHA_CLINICA", fichaclinica.data_ficha_clinica);
                command.Parameters.AddWithValue("@HISTORICO_CLINICO", fichaclinica.historico_clinico);
                command.Parameters.AddWithValue("@SINTORMAS", fichaclinica.sintomas);
                command.Parameters.AddWithValue("@SISTEMAS_ACOMETIDOS", fichaclinica.sistemas_acometidos);
                command.Parameters.AddWithValue("@EXAMES_COMPLEMENTARES", fichaclinica.exames_complementares);
                command.Parameters.AddWithValue("@PRESCRICAO", fichaclinica.prescricao);
                command.Parameters.AddWithValue("@ID", fichaclinica.id_ficha_clinica);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiFichaClinica(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete FICHA_CLINICA where ID_FICHA_CLINICA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_FICHA_CLINICA", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
