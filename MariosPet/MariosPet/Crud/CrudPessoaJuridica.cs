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
    class CrudPessoaJuridica
    {
        public void inserirPessoaJuridica(PessoaJuridica pessoajuridica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into PESSOAJURIDICA (ID, DENOMINACAO_SOCIAL, CNPJ, ID_ENDERECO) values(?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", pessoajuridica.id);
                command.Parameters.AddWithValue("@DENOMINACAO_SOCIAL", pessoajuridica.denominacaoSocial);
                command.Parameters.AddWithValue("@CNPJ", pessoajuridica.cnpj);
                command.Parameters.AddWithValue("@ID_ENDERECO", pessoajuridica.idEndereco);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaPessoaJuridica(string sql)
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

        public void alteraPessoaJuridica(PessoaJuridica pessoajuridica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update PESSOA_JURIDICA set DENOMINACAO_SOCIAL = ?, CNPJ = ?, ID_ENDERECO = ? where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                
                command.Parameters.AddWithValue("@DENOMINACAO_SOCIAL", pessoajuridica.denominacaoSocial);
                command.Parameters.AddWithValue("@CNPJ", pessoajuridica.cnpj);
                command.Parameters.AddWithValue("@ID_ENDERECO", pessoajuridica.idEndereco);
                command.Parameters.AddWithValue("@ID", pessoajuridica.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiPessoaJuridica(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete PESSOA_JURIDICA where ID = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
