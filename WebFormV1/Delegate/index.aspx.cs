using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormV1.Delegate
{
    public partial class index : System.Web.UI.Page
    {
        public delegate void MyDelegate(object sender, EventArgs e);
        public event MyDelegate MyEvent;
        public delegate void MyDelegate2(string message);
        protected void Page_Load(object sender, EventArgs e)
        {
            //使用內建delegate
            Control ctrl1 = this.WebUserControl1.FindControl("Button1");
            if (ctrl1 != null)
                (ctrl1 as Button).Click += new EventHandler(TestEventHalder1);

            //使用自建delegate
            Control ctrl2 = this.WebUserControl1.FindControl("Button2");
            if (ctrl2 != null)
            {
                MyEvent = TestEventHalder2;
                (ctrl2 as Button).Click += new EventHandler(MyEvent);
            }

            //測試委派
            MyDelegate2 myDelegate2 = TestDelegate;
            myDelegate2("測試執行委派方法");
        }
        protected void TestEventHalder1(object sender, EventArgs e)
        {
            Response.Write((sender as Button).Text.ToString());
        }
        protected void TestEventHalder2(object sender, EventArgs e)
        {
            Response.Write((sender as Button).Text.ToString());
        }
        protected void TestDelegate(string message)
        {
            Response.Write(message);
        }
    }
}