using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.EAPEntities.RVMessage.RVMessage
{
    public class Return
    {
        public Return()
        {
            RETURNCODE = "";
            RETURNMESSAGE = "";
        }

        public string RETURNCODE { get; set; }

        public string RETURNMESSAGE { get; set; }
    }
}
