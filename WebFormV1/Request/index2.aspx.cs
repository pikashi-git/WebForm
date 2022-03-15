using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormV1.Request
{
    public partial class index2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string httpmethod = Request.HttpMethod.ToLower();
            string idName = "name";
            string idPassword = "password";
            ltMethod.Text = httpmethod;
            if (httpmethod.Equals("post"))
            {
                idName = "name1";
                idPassword = "password1";
            }
            else
            {
                idName = "name";
                idPassword = "password";
            }
            nameQueryString.Text = Request.QueryString[idName];
            passwordQueryString.Text = Request.QueryString[idPassword];
            nameForm.Text = Request.Form[idName];
            passwordForm.Text = Request.Form[idPassword];
            nameRequest.Text = Request["name"];
            passwordRequest.Text = Request["password"];
            nameRequest1.Text = Request["name1"];
            passwordRequest1.Text = Request["password1"];
        }
    }
}