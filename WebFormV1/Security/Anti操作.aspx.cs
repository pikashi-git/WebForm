using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Microsoft.Security.Application;

namespace WebFormV1.Security
{
    public partial class Anti操作 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string src = @"https://s.yimg.com/ny/api/res/1.2/ukP7byIUd4AB1Xmhm1oMCg--/YXBwaWQ9aGlnaGxhbmRlcjt3PTk2MDtoPTY4NS4yO2NmPXdlYnA-/https://s.yimg.com/os/creatr-uploaded-images/2021-03/f7b7d020-7c87-11eb-bbf7-6240fb656695";
            string alt = @"台積電設廠";
            string title = @"測試";
            src = string.Format(@"""><script>alert('{0}');</script>", src);
            alt = string.Format(@"""><script>alert('{0}');</script>", alt);
            title = string.Format(@"""><script>alert('{0}');</script>", title);
            var innertext = title;
            ltTest.Text = string.Format(@"<img src=""{0}"" alt=""{1}"" title=""{3}"">{2}</img>", Encoder.XmlAttributeEncode(src), Encoder.XmlAttributeEncode(alt), Encoder.HtmlEncode(innertext), Encoder.XmlAttributeEncode("title"));
        }
    }
}