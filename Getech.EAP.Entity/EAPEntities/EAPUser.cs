using Getech.EAP.Entity.DBEntities.DBEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity
{
    public class EAPUser
   { 
        public EAPUser() { }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string GroupID { get; set; }
        public string PassWord { get; set; }
        public string Operator { get; set; }
        public string LastModifyTime { get; set; }
        public bool IsLogin { get; set; }
        public string LastLoginIP { get; set; }
    }
}
