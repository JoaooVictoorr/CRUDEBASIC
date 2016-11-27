<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="SiteInterface.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Pessoa</title>
    <link type ="text/css" rel = "stylesheet" href ="../Content/bootstrap.css" />
</head>
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Content/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div class="container">
     <div class="span10 offset-1">
         <div class="row">
          <h3 class="well">Cadastro de Cliente</h3>
          <br />
          Nome da Pessoa * <br />
          <asp:TextBox ID="txtPessoaNome" runat="server" placeholder="Nome Completo" Width="45%" CssClass="form-control"/>  
          <asp:RequiredFieldValidator ID="requiredNome" ErrorMessage="Insira o Nome" runat="server" ControlToValidate="txtPessoaNome" ForeColor="Red"/> 
          <br />
          <br />
          Endereço *      
          <asp:TextBox ID="txtEnderecoPessoa" runat="server" placeholder="Endereço Residencial" Width="50%" CssClass="form-control"/>  
          <asp:RequiredFieldValidator ID="requiredEndereco" runat="server" ErrorMessage="Insira um Endereço" ControlToValidate="txtEnderecoPessoa" ForeColor="Red"/>   
          <br />
          <br />
          E-Mail:      
          <asp:TextBox ID="txtEmail" runat="server" placeholder="E-Mail Válido" Width="25%" CssClass="form-control"/> 
          <br />
          <br />  
          <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-info" OnClick="btnCadastrar" /> 
          <a href="Home.aspx" class="btn btn-default">Voltar</a>
         </div>
     </div>
    </div>
    </form>
</body>
</html>
