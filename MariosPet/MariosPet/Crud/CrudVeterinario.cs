using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudVeterinario
    {
        public void inserirVeterinario(Veterinario veterinario)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {

                string sql = "insert into VETERINARIO (ID_VETERINARIO, ID_FUNCIONARIO, CRMV_VETERINARIO) values(?,?, ?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_VETERINARIO", veterinario.id_veterinario);
                command.Parameters.AddWithValue("@ID_FUNCIONARIO", veterinario.id_funcionario);
                command.Parameters.AddWithValue("@CRMV_VETERINARIO", veterinario.crmv_veterinario);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaVeterinario(string sql)
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

        public void alteraVeterinario(Veterinario veterinario)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update VETERINARIO set ID_FUNCIONARIO = ?, CRMV_VETERINARIO = ? where ID_VETERINARIO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_FUNCIONARIO", veterinario.id_funcionario);
                command.Parameters.AddWithValue("@CRMV_VETERINARIO", veterinario.crmv_veterinario);
                command.Parameters.AddWithValue("@ID_VETERINARIO", veterinario.id_veterinario);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiVeterinario(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete VETERINARIO where ID_VETERINARIO = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_VETERINARIO", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
