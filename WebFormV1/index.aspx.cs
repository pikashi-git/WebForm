using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class index : System.Web.UI.Page
    {
        test tt { get; set; } = new test();
        protected void Page_Load(object sender, EventArgs e)
        {
            throw new Exception(User.Identity.IsAuthenticated.ToString());
            throw new Exception(Request.Url.ToString());
        }
        class test
        { 
            public string t1 { get; set; }
            public string t2 { get; set; }
        }
    }
}