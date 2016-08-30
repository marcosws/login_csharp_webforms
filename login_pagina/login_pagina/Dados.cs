using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace login_pagina
{
    public class Dados
    {
        private string strConexao = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\LOGIN_CSHARP\login_pagina\login_pagina\App_Data\logpagina.mdf;Integrated Security=True;User Instance=True";
        private string erroGen;
        private string erroSql;

        public void ExecutaSql(string sql)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(strConexao);
                SqlCommand comando = new SqlCommand(sql,conexao);
                conexao.Open();
                try
                {
                    comando.ExecuteNonQuery();
                }
                catch(SqlException ex)
                {
                    erroSql = ex.Message;
                }
                conexao.Close();
            }
            catch(Exception ex)
            {
                erroGen = ex.Message;
            }
        }
        public DataSet ConsultaSql(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection conexao = new SqlConnection(strConexao);
                SqlCommand comando = new SqlCommand(sql, conexao);
                SqlDataAdapter da = new SqlDataAdapter();
                conexao.Open();
                try
                {
                    comando.ExecuteNonQuery();
                }
                catch(SqlException ex)
                {
                    erroSql = ex.Message;
                }
                da.SelectCommand = comando;
                da.Fill(ds);
                conexao.Close();
            }
            catch(Exception ex)
            {
                erroGen = ex.Message;
            }
            return ds;
        }
        public string erroSqlMensagem()
        {
            return erroSql;
        }
        public string erroGenMensagem()
        {
            return erroGen;
        }
    }
}