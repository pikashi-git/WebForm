using Jose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormV1.Security
{
    public partial class JWTTest : System.Web.UI.Page
    {
        string secret = "TestJWT";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            //取得JWT token
            var token = GenerateJWT();
            Response.Write("token: " + token + "<br />");

            //token還原object
            var obj = GetJWTObject(token);
            Response.Write("Name: " + (obj as JWTObject).Name + "<br />");
            Response.Write("Role: " + (obj as JWTObject).Role + "<br />");
        }

        string GenerateJWT()
        {
            var payload = new JWTObject()
            {
                Name = "Tom",
                Role = "User"
            };
            var token = JWT.Encode(payload, Encoding.UTF8.GetBytes(secret), JwsAlgorithm.HS512);
            return token;
        }

        object GetJWTObject(string token)
        {
            var Obj = JWT.Decode<JWTObject>(token, Encoding.UTF8.GetBytes(secret), JwsAlgorithm.HS512);
            return Obj;
        }
        
        class JWTObject
        { 
            public string Name { get; set; }
            public string Role { get; set; }
        }
    }
}