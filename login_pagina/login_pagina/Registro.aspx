<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="login_pagina.Registo" %>

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
            <table>
                <tr>
                    <td><asp:Label ID="LabelNome" runat="server" name="labelNome" Text="Nome: "></asp:Label></td>
                    <td><asp:TextBox ID="TextoNome" runat="server" name="textoNome"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="LabelLogin" runat="server" name="labelLogin" Text="Login: "></asp:Label></td>
                    <td><asp:TextBox ID="TextoLogin" runat="server" name="textoLogin"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="LabelSenha" runat="server" name="textoSenha" Text="Senha: "></asp:Label></td>
                    <td><asp:TextBox ID="TextoSenha" runat="server" name="textoSenha" TextMode="password"></asp:TextBox></td>
                </tr>
                    <tr>
                    <td><asp:Label ID="LabelConfSenha" runat="server" name="labelConfSenha" Text="Confirmar Senha: "></asp:Label></td>
                    <td><asp:TextBox ID="TextoConfSenha" runat="server" name="textoConfSenha" TextMode="password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="BotaoCadastrar" runat="server" OnClick="Cadastrar" Text="Cadastrar" /></td>
                    <td><asp:Label ID="LabelStatus" runat="server" name="labelStatus" Text=""></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
