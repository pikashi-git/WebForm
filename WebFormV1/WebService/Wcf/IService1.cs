using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Services;

namespace WebFormV1.WebService.Wcf
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼和組態檔中的介面名稱 "IService1"。
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Info DoWork(string name, int age);

        [OperationContract]
        [WebGet(UriTemplate = "/DoWork1", ResponseFormat = WebMessageFormat.Json)]
        string DoWork1();
    }
}
