using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity
{
    public class LoginHistory
    {
        public LoginHistory() { }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string LoginWindow { get; set; }
        public string LoginTime { get; set; }
        public string TimeFrom { get; set; }
        public string TimeTo { get; set; }
    }
}
