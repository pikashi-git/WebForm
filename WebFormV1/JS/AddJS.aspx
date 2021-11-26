<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddJS.aspx.cs" Inherits="Test.JS.AddJS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tbMsg" runat="server"></asp:TextBox><br />
            <asp:Button ID="btn" OnClick="btn_Click" runat="server" Text="測試" />
        </div>
    </form>
</body>
</html>
