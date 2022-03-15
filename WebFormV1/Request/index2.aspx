<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index2.aspx.cs" Inherits="WebFormV1.Request.index2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             方法: <asp:Literal ID="ltMethod" runat="server"></asp:Literal><br />
        </div>
        <hr />
        <div>
            Request.QueryString方法:<br />
            姓名: <asp:Literal ID="nameQueryString" runat="server"></asp:Literal><br />
            密碼: <asp:Literal ID="passwordQueryString" runat="server"></asp:Literal><br />
        </div>
        <hr />
        <div>
            Request.Form方法:<br />
            姓名: <asp:Literal ID="nameForm" runat="server"></asp:Literal><br />
            密碼: <asp:Literal ID="passwordForm" runat="server"></asp:Literal><br />
        </div>
        <hr />
        <div>
            Request方法:<br />
            姓名1: <asp:Literal ID="nameRequest" runat="server"></asp:Literal><br />
            密碼1: <asp:Literal ID="passwordRequest" runat="server"></asp:Literal><br />
            姓名2: <asp:Literal ID="nameRequest1" runat="server"></asp:Literal><br />
            密碼2: <asp:Literal ID="passwordRequest1" runat="server"></asp:Literal><br />
        </div>
    </form>
</body>
</html>
