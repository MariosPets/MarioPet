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
    class CrudVermifugo
    {
        public void inserirVermifugo(Vermifugo vermifugo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into VERMIFUGO (ID, ID_ANIMAL, DATA_INICIO, DATA_FIM, ID_MEDICAMENTO) values(?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", vermifugo.id);
                command.Parameters.AddWithValue("@ID_ANIMAL", vermifugo.id_animal);
                command.Parameters.AddWithValue("@DATA_INICIO", vermifugo.data_inicio_vermifugo);
                command.Parameters.AddWithValue("@DATA_FIM", vermifugo.data_fim_vermifugo);
                command.Parameters.AddWithValue("@ID_MEDICAMENTO", vermifugo.id_medicamento);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaVermifugo(string sql)
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

        public void alteraVermifugo(Vermifugo vermifugo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update VERMIFUGO set DATA_INICIO = ?, DATA_FIM = ?, ID_MEDICAMENTO = ?, ID_ANIMAL, where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", vermifugo.id);
                command.Parameters.AddWithValue("@DATA_INICIO", vermifugo.data_inicio);
                command.Parameters.AddWithValue("@DATA_FIM", vermifugo.data_fim);
                command.Parameters.AddWithValue("@ID_MEDICAMENTO", vermifugo.id_medicamento);
                command.Parameters.AddWithValue("@ID_ANIMAL", vermifugo.id_animal);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiVermifugo(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete VERMIFUGO where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
