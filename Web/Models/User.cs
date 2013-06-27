using System.Collections.Generic;

namespace Web.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserRealm { get; set; }
        public int RealmID { get; set; }
        public List<ApplicationPermission> Applications { get; set; } 
    }
}