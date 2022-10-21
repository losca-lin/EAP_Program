using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.EAPEntities
{
    public class ColId
    {
        public string name { get; set; }
        public string trxId { get; set; }
        public string localNo { get; set; }

        public Dictionary<string, object> innerMap = new Dictionary<string, object>();

    }
}
