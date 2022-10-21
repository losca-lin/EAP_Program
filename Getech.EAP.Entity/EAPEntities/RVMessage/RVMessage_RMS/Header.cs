using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.EAPEntities.RVMessage.RVMessage_RMS
{
	public class HEADER
	{
		public string MACHINENAME { get; set; }
		public string MESSAGENAME { get; set; }
		public string EVENTTIME { get; set; }
		public string INBOXNAME { get; set; }
		public string LISENTER { get; set; }
		public string REPLYSUBJECT { get; set; }
		public HEADER()
		{
			MACHINENAME = "";
			MESSAGENAME = "";
			EVENTTIME = "";
			INBOXNAME = "";
			LISENTER = "";
			REPLYSUBJECT = "";
		}

		public HEADER(HEADER header)
		{
			MACHINENAME = header.MACHINENAME;
			MESSAGENAME = header.MESSAGENAME;
			EVENTTIME = header.EVENTTIME;
			INBOXNAME = header.INBOXNAME;
			LISENTER = header.LISENTER;
			REPLYSUBJECT = header.REPLYSUBJECT;
		}

        public static HEADER GetHeaderObject(JObject obj)
        {
            return new HEADER
			{
				MACHINENAME = (string)obj.GetValue("MACHINENAME"),
				MESSAGENAME = (string)obj.GetValue("MESSAGENAME"),
				EVENTTIME = (string)obj.GetValue("EVENTTIME"),
				LISENTER = (string)obj.GetValue("LISENTER"),
				REPLYSUBJECT = (string)obj.GetValue("REPLYSUBJECT")
			};
        }
    }
}
