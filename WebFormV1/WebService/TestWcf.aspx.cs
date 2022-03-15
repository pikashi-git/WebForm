using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormV1.WcfServiceReference1;

namespace WebFormV1.WebService
{
    public partial class TestWcf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();

            // 使用 'client' 變數來呼叫服務上的作業。
            Info rtv = client.DoWork("Vincent", 28);
            Response.Write($"{rtv.Name} {rtv.Age}歲 !");

            // 永遠關閉用戶端。
            client.Close();
        }
    }
}