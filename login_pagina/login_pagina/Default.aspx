﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="login_pagina.Default" %>

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
            <asp:Label ID="LabelNome" runat="server"  Text="Nome: "></asp:Label>
            <asp:TextBox ID="TextoNome" runat="server" ></asp:TextBox>
            <asp:Label ID="LabelSenha" runat="server"  Text="Senha: "></asp:Label>
            <asp:TextBox ID="TextoSenha" runat="server"  TextMode="password"></asp:TextBox>
            <asp:Button ID="BotaoAcessar" runat="server" OnClick="Acessar" Text="Acessar" />
            <br /><br />
            <asp:Label ID="LabelStatus" runat="server" Text=""></asp:Label>
            <br /><br />
            <a href="Registro.aspx">Registrar-Se</a>
        </div>
    </form>
</body>
</html>