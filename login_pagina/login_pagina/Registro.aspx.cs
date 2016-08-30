using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login_pagina
{
    public partial class Registo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Cadastrar(object sender, EventArgs e)
        {
            Dados dados = new Dados();
            if (TextoSenha.Text != TextoConfSenha.Text)
            {
                LabelStatus.Text = "Senha está Diferente !";
            }
            else if (TextoNome.Text == "")
            {
                LabelStatus.Text = "Nome de ser preenchido !";
            }
            else if (TextoLogin.Text == "")
            {
                LabelStatus.Text = "Login de ser preenchido !";
            }
            else if (TextoSenha.Text == "")
            {
                LabelStatus.Text = "Senha de ser preenchida !";
            }
            else
            {
                dados.ExecutaSql("INSERT INTO usuarios(nome,login,senha) VALUES('" + TextoNome.Text + "','" + TextoLogin.Text + "','" + TextoSenha.Text + "')");
                if(dados.erroGenMensagem() != null)
                {
                    LabelStatus.Text = "Erro: " + dados.erroGenMensagem();
                }
                else if (dados.erroSqlMensagem() != null)
                {
                    LabelStatus.Text = "Erro de SQL: " + dados.erroSqlMensagem();
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }
    }
}