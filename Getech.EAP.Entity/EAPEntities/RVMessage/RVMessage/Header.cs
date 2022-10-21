using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.EAPEntities.RVMessage.RVMessage
{
    public class Header
    {
        public Header()
        {
            MESSAGENAME = "";
            TRANSACTIONID = "";
            REPLYSUBJECTNAME = "";
            EVENTUSER = "";
            EVENTCOMMENT = "";
            LANGUAGE = "";
            TERMINAL = "";
        }

        public string MESSAGENAME { get; set; }
        public string TRANSACTIONID { get; set; }
        public string REPLYSUBJECTNAME { get; set; }
        public string EVENTUSER { get; set; }
        public string EVENTCOMMENT { get; set; }
        public string LANGUAGE { get; set; }
        public string TERMINAL { get; set; }
    }
}
