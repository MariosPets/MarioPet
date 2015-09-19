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
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {

                string sql = "insert into VERMIFUGO (ID_ANIMAL, DATA_INICIO_FERMIFUGO, DATA_FIM_FERMIFUGO, ID_MEDICAMENTO) values(?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", vermifugo.id_animal);
                command.Parameters.AddWithValue("@DATA_INICIO_FERMIFUGO", vermifugo.data_inicio_fermifugo);
                command.Parameters.AddWithValue("@DATA_FIM_FERMIFUGO", vermifugo.data_fim_fermifugo);
                command.Parameters.AddWithValue("@ID_MEDICAMENTO", vermifugo.id_medicamento);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaVermifugo(string sql)
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

        public void alteraVermifugo(Vermifugo vermifugo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update VERMIFUGO set DATA_INICIO_FERMIFUGO = ?, DATA_FIM_FERMIFUGO = ?, ID_MEDICAMENTO = ? where ID_ANIMAL = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@DATA_INICIO_FERMIFUGO", vermifugo.data_inicio_fermifugo);
                command.Parameters.AddWithValue("@DATA_FIM_FERMIFUGO", vermifugo.data_fim_fermifugo);
                command.Parameters.AddWithValue("@ID_MEDICAMENTO", vermifugo.id_medicamento);
                command.Parameters.AddWithValue("@ID_ANIMAL", vermifugo.id_animal);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiVermifugo(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete VERMIFUGO where ID_ANIMAL = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_ANIMAL", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
