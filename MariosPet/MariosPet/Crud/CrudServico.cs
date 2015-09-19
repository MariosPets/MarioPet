using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudServico
    {
        public void inserirServico(Servico servico)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {

                string sql = "insert into SERVICO (ID_SERVICO, ID_ANIMAL, ID_FUNCIONARIO, TIPO_SERVICO, HORA_ENTRADA_SERVICO, HORA_SAIDA_SERVICO) values(?,?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_SERVICO", servico.id_servico);
                command.Parameters.AddWithValue("@ID_ANIMAL", servico.id_animal);
                command.Parameters.AddWithValue("@ID_FUNCIONARIO", servico.id_funcionario);
                command.Parameters.AddWithValue("@TIPO_SERVICO", servico.tipo_servico);
                command.Parameters.AddWithValue("@HORA_ENTRADA_SERVICO", servico.hora_entrada_servico);
                command.Parameters.AddWithValue("@HORA_SAIDA_SERVICO", servico.hora_saida_servico);


                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaServico(string sql)
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

        public void alteraServico(Servico servico)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update SERVICO set ID_ANIMAL = ?, ID_FUNCIONARIO = ?, TIPO_SERVICO = ?, HORA_ENTRADA_SERVICO = ?, HORA_SAIDA_SERVICO = ? where ID_SERVICO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", servico.id_animal);
                command.Parameters.AddWithValue("@ID_FUNCIONARIO", servico.id_funcionario);
                command.Parameters.AddWithValue("@TIPO_SERVICO", servico.tipo_servico);
                command.Parameters.AddWithValue("@HORA_ENTRADA_SERVICO", servico.hora_entrada_servico);
                command.Parameters.AddWithValue("@HORA_SAIDA_SERVICO", servico.hora_saida_servico);
                command.Parameters.AddWithValue("@ID_SERVICO", servico.id_servico);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiServico(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete SERVICO where ID_SERVICO = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_SERVICO", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
