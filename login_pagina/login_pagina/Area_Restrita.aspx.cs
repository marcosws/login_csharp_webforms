using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace login_pagina
{
    public partial class Area_Restrita : System.Web.UI.Page
    {
        string codigo;
        string nome;
        protected void Page_Load(object sender, EventArgs e)
        {

            Response.CacheControl = "no-cache";
            Response.AddHeader("Pragma", "no-cache");
            Response.Expires = -1;


            if ((Session["codigo"] == null) || (Session["nome"] == null))
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                codigo = Session["codigo"].ToString();
                nome = Session["nome"].ToString();
                LabelStatus.Text = "Bem Vindo, " + nome;

                DataSet ds = new DataSet();
                Dados dados = new Dados();

                ds = dados.ConsultaSql("SELECT codigo, nome, login, dt_atualizacao FROM usuarios");
                GridUsuarios.DataSource = ds;
                GridUsuarios.DataBind();
            }
        }
    }
}