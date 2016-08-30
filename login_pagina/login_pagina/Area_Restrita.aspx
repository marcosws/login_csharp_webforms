<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Area_Restrita.aspx.cs" Inherits="login_pagina.Area_Restrita" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Login ASP.NET</h1>
    <br /><br />
    <asp:Label ID="LabelStatus" runat="server" name="labelStatus" Text=""></asp:Label>
    <% Response.Write(" | "); %>
    <a href="Logout.aspx">Sair</a>
    <br /><br />
    <asp:GridView ID="GridUsuarios" runat="server" AutoGenerateColumns = "false">
        <Columns>
            <asp:BoundField DataField="codigo" HeaderText="Código" />
            <asp:BoundField DataField="nome" HeaderText="Nome" />
            <asp:BoundField DataField="login" HeaderText="login" />
            <asp:BoundField DataField="dt_atualizacao" HeaderText="Atualização" />
        </Columns>
    </asp:GridView>
    </div>
    </form>
</body>
</html>
