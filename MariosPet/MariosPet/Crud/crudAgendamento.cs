using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudAgendamento
    {
        public void inserirAgendamento(Agendamento agendamento)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {

                string sql = "insert into AGENDAMENTO (ID_AGENDAMENTO, ID_ANIMAL, HORA_AGENDAMENTO, ID_FUNCIONARIO, ATENDIDO) values(?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_AGENDAMENTO", agendamento.id_agendamento);
                command.Parameters.AddWithValue("@ID_ANIMAL", agendamento.id_animal);
                command.Parameters.AddWithValue("@HORA_AGENDAMENTO", agendamento.hora_agendamento);
                command.Parameters.AddWithValue("@ID_FUNCIONARIO", agendamento.id_funcionario);
                command.Parameters.AddWithValue("@ATENDIDO", agendamento.atendido);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaAgendamento(string sql)
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

        public void alteraAgendamento(Agendamento agendamento)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update AGENDAMENTO set ID_ANIMAL = ?, HORA_AGENDAMENTO = ?, ID_FUNCIONARIO = ?, ATENDIDO = ? where ID_AGENDAMENTO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", agendamento.id_animal);
                command.Parameters.AddWithValue("@HORA_AGENDAMENTO", agendamento.hora_agendamento);
                command.Parameters.AddWithValue("@ID_FUNCIONARIO", agendamento.id_funcionario);
                command.Parameters.AddWithValue("@ATENDIDO", agendamento.atendido);
                command.Parameters.AddWithValue("@ID_AGENDAMENTO", agendamento.id_agendamento);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiAgendamento(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete AGENDAMENTO where ID_AGENDAMENTO = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_AGENDAMENTO", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
