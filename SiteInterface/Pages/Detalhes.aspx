<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="SiteInterface.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Detalhes</title>
    <link type ="text/css" rel = "stylesheet" href ="../Content/bootstrap.css" />
</head>
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Content/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div class="container">
    <div class="span10 offset1">
        <div class="row">
            <h3 class="well">Detalhes da Pessoa</h3>
            <br/>
            Informe o Código da Pessoa:
            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="5%"/>
            <asp:DataList ID="DataList1" runat="server">
            </asp:DataList>
            <br/>
            <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" CssClass="btn btn-info btn" OnClick="btnPesquisarPessoa" />
            <a href="Home.aspx">Voltar</a>
            <br/><br/>
            <asp:Panel ID="pnlDados" runat="server" Visible="false">
             Nome Cliente:
            <asp:TextBox ID="txtNomePessoaConsulta" runat="server" CssClass="form-control" Width="45%"/>
            <br/>
            Endereço:
            <asp:TextBox ID="txtEnderecoConsulta" runat="server" CssClass="form-control" Width="45%"/>
            <br/>
            Email:
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Width="35%"/>
            <br/><br/>
            <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" CssClass="btn btn-warning" OnClick="btnAtualizarConsulta"/>
            <span onclick="return confirm('Tem certeza que deseja excluir ?)">
            <asp:Button ID="txtExcluir" runat="server" Text="Excluir" CssClass="btn btn-danger" OnClick="btnExcluirConsulta"/>
            </span>
            </asp:Panel>
        </div>
    </div>
    </div>
    </form>
</body>
</html>
