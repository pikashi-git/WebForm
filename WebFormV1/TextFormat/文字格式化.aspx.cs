using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormV1
{
    public partial class 測試文字格式化 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = @"vincent";
            Response.Write(string.Format(@"我是""{0}""<br />", name));
            //Response.Write(@"我是{0}<br />", name);
            Response.Write($@"我是""{name}""<br />");
        }
    }
}