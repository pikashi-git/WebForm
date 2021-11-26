using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test.Cookie
{
    public partial class Cookie : System.Web.UI.Page
    {
        string cookieName = "_Test";
        int expireMin = 30;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void SetCookie(string val)
        {
            HttpCookie cookie = new HttpCookie(cookieName);
            cookie.Value = val;
            cookie.Expires = DateTime.Now.AddMinutes(expireMin);
            Response.Cookies.Add(cookie);
        }

        void RemoveCoookie()
        {
            HttpCookie cookie = Request.Cookies[cookieName];
            cookie.Expires = DateTime.Now.AddYears(-1);
            Response.SetCookie(cookie);
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            //設置cookie
            SetCookie("AAA");
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            RemoveCoookie();
        }
    }
}