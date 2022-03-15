using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebFormV1.WebService.Asmx
{
    /// <summary>
    ///WebService1 的摘要描述
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)] //<==預設
    //[WebServiceBinding(ConformsTo = WsiProfiles.None)] // <== 若有同名Method, 則需改用此設定
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允許使用 ASP.NET AJAX 從指令碼呼叫此 Web 服務，請取消註解下列一行。
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService : System.Web.Services.WebService
    {
        [WebMethod(Description ="Hello Method Description!!")]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(MessageName ="HelloWorld2")]
        public string HelloWorld1(string name)
        {
            return string.Format($@"Hello World {name} !!");
        }

        //EnableSession:    是否啟用Session
        //BufferResponse:   是否等到響應被完全緩沖完，才發送信息給請求端
        //CacheDuration:    緩存時間的屬性。預設值為0也就是disable
        //MessageName:      函式同名異式多載方法
        [WebMethod(EnableSession = true,CacheDuration = 60, BufferResponse = true, MessageName = "MyWebService2")]
        public string MyWebServiceMethod()
        {
            return @"Hello";
        }
    }
}
