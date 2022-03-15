using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace WebFormV1.WebService
{
    public partial class TestAsmx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //#region 靜態調用web service(asmx)
            // 1. IDE操作建立service reference

            // 2. 宣告實體後運用
            // Method HelloWorld1
            //MyWebServiceTest.MyWebServiceSoapClient mywebservicetest = new MyWebServiceTest.MyWebServiceSoapClient();
            //Response.Write(@"靜態調用web service => " + mywebservicetest.HelloWorld1("Vincent"));

            // Method MyWebServiceMethod
            MyWebServiceTest.MyWebServiceSoapClient mywebservicetest = new MyWebServiceTest.MyWebServiceSoapClient();
            Response.Write(@"靜態調用web service => " + mywebservicetest.MyWebServiceMethod());

            //#endregion

            Response.Write("<br />");

            #region 動態調用web service
            string res = "";

            // 1. 使用 WebClient 下载 WSDL (web service description language)
            WebClient web = new WebClient();
            Stream stream = web.OpenRead("https://localhost:44386/WebService/Asmx/WebService.asmx?wsdl");

            // 2. 建立 WSDL 檔案。
            ServiceDescription description = ServiceDescription.Read(stream);

            // 3. 產生Client端Proxy Class。
            ServiceDescriptionImporter importer = new ServiceDescriptionImporter
            {
                ProtocolName = "Soap", // 指定訪問的Protoccol。
                Style = ServiceDescriptionImportStyle.Client, //Client端 Proxy 的建立。
                CodeGenerationOptions = CodeGenerationOptions.GenerateProperties | CodeGenerationOptions.GenerateNewAsync
            };
            importer.AddServiceDescription(description, null, null); // 添加 WSDL 檔案。

            // 4. 使用 CodeDom 去Compile出Client端Proxy程式。
            CodeNamespace nmspace = new CodeNamespace(); // 加入namespace
            CodeCompileUnit unit = new CodeCompileUnit();
            unit.Namespaces.Add(nmspace);
            ServiceDescriptionImportWarnings warning = importer.Import(nmspace, unit);
            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            CompilerParameters parameter = new CompilerParameters();
            parameter.GenerateExecutable = false;
            parameter.GenerateInMemory = true;
            parameter.ReferencedAssemblies.Add("System.dll");
            parameter.ReferencedAssemblies.Add("System.XML.dll");
            parameter.ReferencedAssemblies.Add("System.Web.Services.dll");
            parameter.ReferencedAssemblies.Add("System.Data.dll");
            CompilerResults result = provider.CompileAssemblyFromDom(parameter, unit);

            // 5. 使用 Reflection 調用 WebService。
            if (!result.Errors.HasErrors)
            {
                Assembly asm = result.CompiledAssembly;
                Type t = asm.GetType("MyWebService"); // 如果在前面有設置Namespace則需要記得將Namespace加到Class之前。
                object o = Activator.CreateInstance(t);

                // Method HelloWorld1
                MethodInfo method = t.GetMethod("HelloWorld1");
                res = Convert.ToString(method.Invoke(o, new object[] { "Vincent" }));

                //// Method HelloWorld
                //MethodInfo method = t.GetMethod("HelloWorld");
                //res = Convert.ToString(method.Invoke(o, null));

                //// Method MyWebServiceMethod
                //MethodInfo method = t.GetMethod("MyWebServiceMethod");
                //res = Convert.ToString(method.Invoke(o, null));
            }
            Response.Write(@"動態調用web service => " + res);
            #endregion
        }
    }
}