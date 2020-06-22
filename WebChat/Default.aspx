<%@ page language="C#" autoeventwireup="true" codebehind="Default.aspx.cs" inherits="WebChat.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <h1>ASP.NET - Chat</h1>
        <asp:Label ID="erroLabel" Visible="false" CssClass="erro" runat="server"></asp:Label>
        <asp:MultiView ID="MultiView1" ActiveViewIndex="0" runat="server">
            <asp:View ID="View1" runat="server"></asp:View>
            <asp:View ID="View2" runat="server"></asp:View>
        </asp:MultiView>

        <div>
        </div>
    </form>
</body>
</html>
