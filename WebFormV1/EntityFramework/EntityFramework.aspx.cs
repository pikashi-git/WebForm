
using NetWebForm.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFramework
{
    public partial class EntityFramework : System.Web.UI.Page
    {
        GuestBookEntities entity = new GuestBookEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            ////更新
            //UpdateActionByWhere(48);

            ////新增
            //InsertAction();

            ////刪除
            //DeleteActionByKey(50,102);

            ////查詢
            //SelectAction();
            //Response.Write("<br /><br />");

            //SelectActionByWhere("999@inbox.mailtrap.io");
            //Response.Write("<br /><br />");

            //SelectActionByFine1(100);
            //Response.Write("<br /><br />");

            //SelectActionByKey2(17, 101);
            //Response.Write("<br /><br />");
        }
        void UpdateActionByWhere(int id)
        {
            guestbook _guestbook = entity.guestbooks.Where(guestbook => guestbook.id == id).FirstOrDefault();
            _guestbook.postContent = $"更改新內容:{_guestbook.postContent}";
            _guestbook.updatetime = DateTime.Now;
            entity.SaveChanges();
        }
        void InsertAction()
        {
            guestbook _guestbook = new guestbook();
            _guestbook.userID = 102;
            _guestbook.postContent = $"新增加資料{_guestbook.userID}";
            _guestbook.parent = 0;
            _guestbook.createtime = DateTime.Now;
            entity.guestbooks.Add(_guestbook);
            entity.SaveChanges();
        }
        void DeleteActionByKey(int id,int userID)
        {
            guestbook _guestbook = entity.guestbooks.Find(id, userID);
            entity.guestbooks.Remove(_guestbook);
            entity.SaveChanges();
        }
        void SelectAction()
        {
            List <user> _users = entity.users.ToList();
            foreach (user _user in _users)
                Response.Write(_user.userID + ", " + _user.names + ", " + _user.account + ", " + _user.email + "<br/>");
        }
        void SelectActionByWhere(string email)
        {
            List<user> _users = entity.users.Where(user => user.email == email).ToList();
            foreach (user _user in _users)
                Response.Write(_user.userID + ", " + _user.names + ", " + _user.account + ", " + _user.email + "<br />");
        }
        void SelectActionByFine1(int key)
        {
            user _user = entity.users.Find(key);
            Response.Write(_user.userID + ", " + _user.names + ", " + _user.account + ", " + _user.email + "<br />");
        }
        void SelectActionByKey2(int id, int userID)
        {
            guestbook _guestbook = entity.guestbooks.Find(id, userID);
            Response.Write(_guestbook.id + ", " + _guestbook.userID + ", " + _guestbook.postContent + ", " + _guestbook.createtime + "<br />");
        }
    }
}