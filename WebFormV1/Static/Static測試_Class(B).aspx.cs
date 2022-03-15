using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormV1
{
    public partial class static測試B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("之前值: " +Static數值固定.code);
            Response.Write("<br />");
            Static數值固定.code = "static測試B";
            Response.Write("現在值: "+ Static數值固定.code);
        }
    }
}