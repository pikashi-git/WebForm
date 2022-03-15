using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormV1.RegisJavascript
{
    public partial class AddJS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void AddJsScript(string js)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertJS", js, true);
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string text = "alert('" + tbMsg.Text + "');";
            AddJsScript(text);
        }
    }
}