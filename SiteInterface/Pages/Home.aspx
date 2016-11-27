<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SiteInterface.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link type ="text/css" rel = "stylesheet" href ="../Content/bootstrap.css" />
</head>
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Content/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div class="jumbotron">
    <h1>Controle de Pessoas</h1>
        Selecione a operção desejada: 
        <asp:DropDownList ID="ddMenu" runat="server">
        <asp:ListItem value="1" Text="Cadastrar Pessoa"/>
        <asp:ListItem value="2" Text="Consultar Pessoa"/>
        <asp:ListItem value="3" Text="Obter dados de Pessoa"/>
        </asp:DropDownList>
        <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-success btn-lg" OnClick="btnAcessar"/>
    </div>
    </form>
</body>
</html>
