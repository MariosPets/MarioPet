using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudAtendimento
    {
        public void inserirAtendimento(Atendimento atendimento)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {

                string sql = "insert into ATENDIMENTO (ID_ATENDIMENTO, ID_ANIMAL, ID_FUNCIONARIO, HORA_ENTRADA_ATENDIMENTO, HORA_SAIDA_ATENDIMENTO) values(?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ATENDIMENTO", atendimento.id_atendimento);
                command.Parameters.AddWithValue("@ID_ANIMAL", atendimento.id_animal);
                command.Parameters.AddWithValue("@ID_FUNCIONARIO", atendimento.id_funcionario);
                command.Parameters.AddWithValue("@HORA_ENTRADA_ATENDIMENTO", atendimento.hora_entrada_atendimento);
                command.Parameters.AddWithValue("@HORA_SAIDA_ATENDIMENTO", atendimento.hora_saida_atendimento);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaAtendimento(string sql)
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

        public void alteraAtendimento(Atendimento atendimento)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update ATENDIMENTO set ID_ANIMAL = ?, ID_FUNCIONARIO = ?, HORA_ENTRADA_ATENDIMENTO = ?, HORA_SAIDA_ATENDIMENTO = ? where ID_ATENDIMENTO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", atendimento.id_animal);
                command.Parameters.AddWithValue("@ID_FUNCIONARIO", atendimento.id_funcionario);
                command.Parameters.AddWithValue("@HORA_ENTRADA_ATENDIMENTO", atendimento.hora_entrada_atendimento);
                command.Parameters.AddWithValue("@HORA_SAIDA_ATENDIMENTO", atendimento.hora_saida_atendimento);
                command.Parameters.AddWithValue("@ID_ATENDIMENTO", atendimento.id_atendimento);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiAtendimento(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete ATENDIMENTO where ID_ATENDIMENTO = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_ATENDIMENTO", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
