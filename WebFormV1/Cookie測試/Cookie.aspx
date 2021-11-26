<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookie.aspx.cs" Inherits="Test.Cookie.Cookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:Button ID="btn1" OnClick="btn1_Click" Text="建立cookie" runat="server" /><br />
           <asp:Button ID="btn2" OnClick="btn2_Click" Text="刪除cookie" runat="server" /><br />
        </div>
    </form>
</body>
</html>
