<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebFormV1.Request.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" action="index2.aspx?name1=vincent" method="get">
        <div>
            Get方法: 
            姓名: <input type="text" id="name" name="name" value="" />
            密碼: <input type="text" id="password" name="password" value="" />
            <input type="submit" id="submit" name="submit" value="送出" />
        </div>
    </form>

    <form id="form2" action="index2.aspx?name=vincent" method="post">
        <div>
            Post方法: 
            姓名: <input type="text" id="name1" name="name1" value="" />
            密碼: <input type="text" id="password1" name="password1" value="" />
            <input type="submit" id="submit1" name="submit" value="送出" />
        </div>
    </form>
</body>
</html>
