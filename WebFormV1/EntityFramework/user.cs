//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetWebForm.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        public int userID { get; set; }
        public string names { get; set; }
        public string nick { get; set; }
        public string account { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public Nullable<System.Guid> authcode { get; set; }
        public string role { get; set; }
        public Nullable<System.DateTime> validateDate { get; set; }
        public Nullable<bool> enabled { get; set; }
    
        public virtual cart cart { get; set; }
    }
}