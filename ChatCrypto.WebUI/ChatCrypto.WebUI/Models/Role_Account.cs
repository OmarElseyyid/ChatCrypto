//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatCrypto.WebUI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role_Account
    {
        public Nullable<int> Role_id { get; set; }
        public Nullable<int> Account_id { get; set; }
        public Nullable<System.DateTime> Created_at { get; set; }
        public bool Is_active { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Role Role { get; set; }
    }
}
