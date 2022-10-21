using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.EAPEntities.RVMessage.RVMessage_RMS
{
    public class RVMessageInfo
    {
		public RVMessageInfo()
		{
			HEADER = new HEADER();
			BODY = new JObject();
			RETURN = new RETURN();
		}
		public HEADER HEADER { get; set; }
		public JObject BODY { get; set; }
		public RETURN RETURN { get; set; }
	}
}
