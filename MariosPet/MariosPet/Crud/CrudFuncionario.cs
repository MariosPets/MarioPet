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
    class CrudFuncionario: CrudPessoa
    {
        public void inserirFornecedor(Funcionario funcionario)
        {
            inserirPessoa(funcionario);
            funcionario.id = Convert.ToInt32(consultaPessoa("select top 1 ID from PESSOA order by ID desc").Rows[0][0].ToString());

            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into FUNCIONARIO (ID_PESSOA, TIPO_FUNCIONARIO, APELIDO, SENHA) values(?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA", funcionario.id);
                command.Parameters.AddWithValue("@TIPO_FUNCIONARIO", funcionario.tipo);
                command.Parameters.AddWithValue("@APELIDO", funcionario.apelido);
                command.Parameters.AddWithValue("@SENHA", funcionario.senha);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaFuncionario(string sql)
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

        public void alteraFuncionario(Funcionario funcionario)
        {
            alteraPessoa(funcionario);

            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update FUNCIONARIO set TIPO = ?, LOGIN = ?, SENHA = ? where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                
                command.Parameters.AddWithValue("@TIPO_FUNCIONARIO", funcionario.tipo);
                command.Parameters.AddWithValue("@LOGIN", funcionario.login);
                command.Parameters.AddWithValue("@SENHA", funcionario.senha);
                command.Parameters.AddWithValue("@ID", funcionario.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiFuncionario(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete FUNCIONARIO where ID_FUNCIONARIO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_FUNCIONARIO", codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
