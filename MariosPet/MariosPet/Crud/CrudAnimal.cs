using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudAnimal
    {
        public void inserirAnimal(Animal animal)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {

                string sql = "insert into ANIMAL (ID_ANIMAL, NOME_ANIMAL, ID_CLIENTE, RACA_PORTE, SEXO, PELAGEM_COR, NASCIMENTO, ID_VETERINARIO ) values(?,?,?,?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", animal.id_animal);
                command.Parameters.AddWithValue("@NOME_ANIMAL", animal.nome_animal);
                command.Parameters.AddWithValue("@ID_CLIENTE", animal.id_cliente);
                command.Parameters.AddWithValue("@RACA_PORTE", animal.raca_porte);
                command.Parameters.AddWithValue("@SEXO", animal.sexo);
                command.Parameters.AddWithValue("@PELAGEM_COR", animal.pelagem_cor);
                command.Parameters.AddWithValue("@NASCIMENTO", animal.nascimento);
                command.Parameters.AddWithValue("@ID_VETERINARIO", animal.id_veterinario);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaAnimal(string sql)
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

        public void alteraAnimal(Animal animal)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update ANIMAL set NOME_ANIMAL = ?, ID_CLIENTE = ?, RACA_PORTE = ?, SEXO = ?, PELAGEM_COR = ?, NASCIMENTO = ?, ID_VETERINARIO = ?,  where ID_ANIMAL = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@NOME_ANIMAL", animal.nome_animal);
                command.Parameters.AddWithValue("@ID_CLIENTE", animal.id_cliente);
                command.Parameters.AddWithValue("@RACA_PORTE", animal.raca_porte);
                command.Parameters.AddWithValue("@SEXO", animal.sexo);
                command.Parameters.AddWithValue("@PELAGEM_COR", animal.pelagem_cor);
                command.Parameters.AddWithValue("@NASCIMENTO", animal.nascimento);
                command.Parameters.AddWithValue("@ID_VETERINARIO", animal.id_veterinario);
                command.Parameters.AddWithValue("@ID_ANIMAL", animal.id_animal);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiCliente(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete ANIMAL where ID_ANIMAL = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_ANIMAL", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
