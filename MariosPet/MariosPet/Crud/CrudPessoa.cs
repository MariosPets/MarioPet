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
    class CrudPessoa
    {
        public void inserirVermifugo(Pessoa pessoa)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into PESSOA (ID_PESSOA, NOME, CPF, RG, NASCIMENTO, ID_ENDERECO) values(?,?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA", pessoa.id);
                command.Parameters.AddWithValue("@NOME", pessoa.nome);
                command.Parameters.AddWithValue("@CPF", pessoa.cpf);
                command.Parameters.AddWithValue("@RG", pessoa.rg);
                command.Parameters.AddWithValue("@NASCIMENTO", pessoa.nascimento);
                command.Parameters.AddWithValue("@ID_ENDERECO", pessoa.id_endereco);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaPessoa(string sql)
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

        public void alteraPessoa(Pessoa pessoa)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "update PESSOA set NOME = ?, CPF = ?, RG = ?, NASCIMENTO = ?, ID_ENDERECO, where ID_PESSOA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@NOME", pessoa.nome);
                command.Parameters.AddWithValue("@CPF", pessoa.cpf);
                command.Parameters.AddWithValue("@RG", pessoa.rg);
                command.Parameters.AddWithValue("@NASCIMENTO", pessoa.nascimento);
                command.Parameters.AddWithValue("@ID_ENDERECO", pessoa.id_endereco);
                command.Parameters.AddWithValue("@ID_PESSOA", pessoa.id_pessoa);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiPessoa(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.criarConexao())
            {
                string sql = "delete PESSOA where ID_PESSOA = ?";
                OdbcCommand command = new OdbcCommand(sql, connection);

                command.Parameters.AddWithValue("@ID_PESSOA", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
