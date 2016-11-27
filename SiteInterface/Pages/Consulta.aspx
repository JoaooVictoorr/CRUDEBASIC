<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="SiteInterface.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta</title>
    <link type ="text/css" rel = "stylesheet" href ="../Content/bootstrap.css" />
</head>
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Content/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="span10 offset1">
            <div class="row">
                <h3 class="well">Consulta de Pessoa</h3>
                <asp:GridView ID="gridPessoas" runat="server" CssClass="table-hover table-striped" GridLines="Horizontal" AutoGenerateColumns="False"  BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="732px" >
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>
                    <asp:BoundField DataField="Codigo" HeaderText="Código" />
                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                    <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
                    <asp:BoundField DataField="Email" HeaderText="E-Mail" />
                </Columns>
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle CssClass="cursor-pointer" BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <SortedAscendingCellStyle BackColor="#F4F4FD" />
                    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                    <SortedDescendingCellStyle BackColor="#D8D8F0" />
                    <SortedDescendingHeaderStyle BackColor="#3E3277" />
                </asp:GridView>
                <a href="Home.aspx" class="btn btn-default btn-lg">Voltar</a>
            </div>
        </div>
    
    </div>
    </form>
</body>
</html>
