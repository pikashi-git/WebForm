//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFormV1.MyWebServiceTest {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyWebServiceTest.MyWebServiceSoap")]
    public interface MyWebServiceSoap {
        
        // CODEGEN: 命名空間 http://tempuri.org/ 的元素名稱  HelloWorldResult 未標示為 nillable，正在產生訊息合約
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebFormV1.MyWebServiceTest.HelloWorldResponse HelloWorld(WebFormV1.MyWebServiceTest.HelloWorldRequest request);
        
        // CODEGEN: 訊息 HelloWorld2 的包裝函式名稱 (HelloWorld2) 與預設值 (HelloWorld1) 不符，正在產生訊息合約
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld2", ReplyAction="*")]
        WebFormV1.MyWebServiceTest.HelloWorld21 HelloWorld1(WebFormV1.MyWebServiceTest.HelloWorld2 request);
        
        // CODEGEN: 訊息 MyWebService2 的包裝函式名稱 (MyWebService2) 與預設值 (MyWebServiceMethod) 不符，正在產生訊息合約
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyWebService2", ReplyAction="*")]
        WebFormV1.MyWebServiceTest.MyWebService21 MyWebServiceMethod(WebFormV1.MyWebServiceTest.MyWebService2 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebFormV1.MyWebServiceTest.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebFormV1.MyWebServiceTest.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebFormV1.MyWebServiceTest.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebFormV1.MyWebServiceTest.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HelloWorld2", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class HelloWorld2 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string name;
        
        public HelloWorld2() {
        }
        
        public HelloWorld2(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HelloWorld2Response", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class HelloWorld21 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string HelloWorld2Result;
        
        public HelloWorld21() {
        }
        
        public HelloWorld21(string HelloWorld2Result) {
            this.HelloWorld2Result = HelloWorld2Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MyWebService2", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class MyWebService2 {
        
        public MyWebService2() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MyWebService2Response", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class MyWebService21 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string MyWebService2Result;
        
        public MyWebService21() {
        }
        
        public MyWebService21(string MyWebService2Result) {
            this.MyWebService2Result = MyWebService2Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MyWebServiceSoapChannel : WebFormV1.MyWebServiceTest.MyWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyWebServiceSoapClient : System.ServiceModel.ClientBase<WebFormV1.MyWebServiceTest.MyWebServiceSoap>, WebFormV1.MyWebServiceTest.MyWebServiceSoap {
        
        public MyWebServiceSoapClient() {
        }
        
        public MyWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebFormV1.MyWebServiceTest.HelloWorldResponse WebFormV1.MyWebServiceTest.MyWebServiceSoap.HelloWorld(WebFormV1.MyWebServiceTest.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebFormV1.MyWebServiceTest.HelloWorldRequest inValue = new WebFormV1.MyWebServiceTest.HelloWorldRequest();
            inValue.Body = new WebFormV1.MyWebServiceTest.HelloWorldRequestBody();
            WebFormV1.MyWebServiceTest.HelloWorldResponse retVal = ((WebFormV1.MyWebServiceTest.MyWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebFormV1.MyWebServiceTest.HelloWorld21 WebFormV1.MyWebServiceTest.MyWebServiceSoap.HelloWorld1(WebFormV1.MyWebServiceTest.HelloWorld2 request) {
            return base.Channel.HelloWorld1(request);
        }
        
        public string HelloWorld1(string name) {
            WebFormV1.MyWebServiceTest.HelloWorld2 inValue = new WebFormV1.MyWebServiceTest.HelloWorld2();
            inValue.name = name;
            WebFormV1.MyWebServiceTest.HelloWorld21 retVal = ((WebFormV1.MyWebServiceTest.MyWebServiceSoap)(this)).HelloWorld1(inValue);
            return retVal.HelloWorld2Result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebFormV1.MyWebServiceTest.MyWebService21 WebFormV1.MyWebServiceTest.MyWebServiceSoap.MyWebServiceMethod(WebFormV1.MyWebServiceTest.MyWebService2 request) {
            return base.Channel.MyWebServiceMethod(request);
        }
        
        public string MyWebServiceMethod() {
            WebFormV1.MyWebServiceTest.MyWebService2 inValue = new WebFormV1.MyWebServiceTest.MyWebService2();
            WebFormV1.MyWebServiceTest.MyWebService21 retVal = ((WebFormV1.MyWebServiceTest.MyWebServiceSoap)(this)).MyWebServiceMethod(inValue);
            return retVal.MyWebService2Result;
        }
    }
}
