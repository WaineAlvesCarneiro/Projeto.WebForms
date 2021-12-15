<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pessoas.aspx.cs" Inherits="WebForms.Pessoa.Views.Pessoas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastra Pessoas</title>
</head>
<body>
    <h2><%: Title %></h2>
    <form id="form2" runat="server" autocomplete="off">
        <div style="height: 32px">
            Nome:<asp:TextBox ID="txtNome" runat="server" Width="299px"></asp:TextBox>
        </div>
            Tipo:<asp:TextBox ID="txtTipoPessoa" runat="server" Width="43px"></asp:TextBox>
        <p>
            <asp:Button ID="btnguardar" runat="server" OnClick="btnguardar_Click" Text="Gravar" />
        </p>
        <asp:GridView ID="gridPessoa" runat="server" OnSelectedIndexChanged="gridPessoa_SelectedIndexChanged" Width="504px">
        </asp:GridView>
    </form>
</body>
</html>