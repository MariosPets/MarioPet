﻿using MariosPet.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudFichaClinica
    {
        public void inserirFichaClinica(FichaClinica fichaclinica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "insert into FICHA_CLINICA (ID_FICHA_CLINICA, ID_ANIMAL, ID_VETERINARIO, DATA, HISTORICO_CLINICO, QUEIXA_PRINCIPAL, SUSPEITA, PRESCRICAO, SINTOMAS, EXAMES_COMPLEMENTARES, OBSERVACAO) values(?,?,?,?,?,?,?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_FICHA_CLINICA", fichaclinica.id_ficha_clinica);
                command.Parameters.AddWithValue("@ID_ANIMAL", fichaclinica.id_animal);
                command.Parameters.AddWithValue("@ID_VETERINARIO", fichaclinica.id_veterinario);
                command.Parameters.AddWithValue("@DATA", fichaclinica.data_ficha_clinica);
                command.Parameters.AddWithValue("@HISTORICO_CLINICO", fichaclinica.historico_clinico);
                command.Parameters.AddWithValue("@QUEIXA_PRINCIPAL", fichaclinica.sintomas);
                command.Parameters.AddWithValue("@SUSPEITA", fichaclinica.sistemas_acometidos);
                command.Parameters.AddWithValue("@PRESCRICAO", fichaclinica.exames_complementares);
                command.Parameters.AddWithValue("@SINTOMAS", fichaclinica.prescricao);
                command.Parameters.AddWithValue("@EXAMES_COMPLEMENTARES", fichaclinica.prescricao);
                command.Parameters.AddWithValue("@OBSERVACAO", fichaclinica.prescricao);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaFichaClinica(string sql)
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

        public void alteraFichaClinica(FichaClinica fichaclinica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update FICHA_CLINICA set ID_ANIMAL = ?, ID_VETERINARIO = ?, DATA = ?, HISTORICO_CLINICO = ?, QUEIXA_PRINCIPAL = ?, SUSPEITA = ?, PRESCRICAO = ?, SINTOMAS = ?, EXAMES_COMPLEMENTARES = ?, OBSERVACAO = ? where ID_FICHA_CLINICA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", fichaclinica.id_animal);
                command.Parameters.AddWithValue("@ID_VETERINARIO", fichaclinica.id_veterinario);
                command.Parameters.AddWithValue("@DATA", fichaclinica.data_ficha_clinica);
                command.Parameters.AddWithValue("@HISTORICO_CLINICO", fichaclinica.historico_clinico);
                command.Parameters.AddWithValue("@QUEIXA_PRINCIPAL", fichaclinica.sintomas);
                command.Parameters.AddWithValue("@SUSPEITA", fichaclinica.sistemas_acometidos);
                command.Parameters.AddWithValue("@PRESCRICAO", fichaclinica.exames_complementares);
                command.Parameters.AddWithValue("@SINTOMAS", fichaclinica.prescricao);
                command.Parameters.AddWithValue("@EXAMES_COMPLEMENTARES", fichaclinica.prescricao);
                command.Parameters.AddWithValue("@OBSERVACAO", fichaclinica.prescricao);
                command.Parameters.AddWithValue("@ID_FICHA_CLINICA", fichaclinica.id_ficha_clinica);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiFichaClinica(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete FICHA_CLINICA where ID_FICHA_CLINICA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_FICHA_CLINICA", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
