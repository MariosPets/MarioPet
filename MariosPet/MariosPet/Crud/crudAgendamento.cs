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
    class CrudAgendamento
    {
        public void inserirAgendamento(Agendamento agendamento)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into AGENDAMENTO (ID, ID_CLIENTE, ID_FUNCIONARIO, HORA, ATENDIDO) values(?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", agendamento.id);
                command.Parameters.AddWithValue("@ID_CLIENTE", agendamento.idCliente);                
                command.Parameters.AddWithValue("@ID_FUNCIONARIO", agendamento.idFuncionario);
                command.Parameters.AddWithValue("@HORA", agendamento.hora);
                command.Parameters.AddWithValue("@ATENDIDO", agendamento.atendido);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaAgendamento(string sql)
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

        public void alteraAgendamento(Agendamento agendamento)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update AGENDAMENTO set ID_CLIENTE = ?, ID_FUNCIONARIO = ?, HORA = ?, ATENDIDO = ? where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_CLIENTE", agendamento.idCliente);                
                command.Parameters.AddWithValue("@ID_FUNCIONARIO", agendamento.idFuncionario);
                command.Parameters.AddWithValue("@HORA", agendamento.hora);
                command.Parameters.AddWithValue("@ATENDIDO", agendamento.atendido);
                command.Parameters.AddWithValue("@ID", agendamento.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiAgendamento(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete AGENDAMENTO where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
