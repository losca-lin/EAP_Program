using System;

namespace Getech.EAP.Entity
{
    public class User
    {
        public string UserName { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Level { get; set; }
        public string Creator { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
