using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.EAPEntities.RVMessage.RVMessage_RMS
{
	public class RETURN
	{
		public string RETURNCODE { get; set; }

		public string RETURNMESSAGE { get; set; }

		public RETURN()
		{
			RETURNCODE = "";
			RETURNMESSAGE = "";
		}

		public RETURN(RETURN r)
		{
			RETURNCODE = r.RETURNCODE;
			RETURNMESSAGE = r.RETURNMESSAGE;
		}

		public bool CheckResult()
		{
			return RETURNCODE == "OK";
		}

		public void SetReturnOK()
		{
			RETURNCODE = "OK";
			RETURNMESSAGE = "SUCCESS";
		}

		public void SetReturnNG(string err)
		{
			RETURNCODE = "NG";
			RETURNMESSAGE = err;
		}
	}
}
