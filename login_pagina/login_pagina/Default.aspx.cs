using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace login_pagina
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Acessar(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            Dados dados = new Dados();
            ds = dados.ConsultaSql("SELECT codigo, nome, login, dt_atualizacao FROM usuarios WHERE login = '" + TextoNome.Text + "' AND senha = '" + TextoSenha.Text + "'");
            if (ds.Tables[0].Rows.Count == 0)
            {
                LabelStatus.Text = "Usuário e Senha Inválidos !";
            }
            else
            { 
                Session["codigo"] = ds.Tables[0].Rows[0][0].ToString();
                Session["nome"] = ds.Tables[0].Rows[0][1].ToString();
                Session["login"] = ds.Tables[0].Rows[0][2].ToString();
                Response.Redirect("Area_Restrita.aspx");
            }
        }
    }
}