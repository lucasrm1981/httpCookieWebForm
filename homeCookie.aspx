<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeCookie.aspx.cs" Inherits="httpCookieWebForm.homeCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="UTF-8"/>
    <title></title>
</head>
<body>
    <h1>Gravação, Leitura e Remoção de Cookie utilizando ASP. NET</h1>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnGravar" runat="server" OnClick="btnGravar_Click" Text="Gravar Cookies"
            Width="120px" Height="30px"
            ToolTip="Efetua a gravação dos dados no cookies!" />
        <br />
        <asp:Button ID="btnLer" runat="server" OnClick="btnLer_Click"
            Text="Ler Cookies" Width="120px" Height="30px"
            ToolTip="Efetua a leitura dos cookies!" />
        <br />
        <asp:Button ID="btnRemoverCookie" runat="server" OnClick="btnRemoverCookie_Click"
            Text="Remover Cookies" Width="120px" Height="30px"
            ToolTip="Efetua a remoção dos dados no cookies!" />
        <br />
        <asp:Literal ID="ltrCookie" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
