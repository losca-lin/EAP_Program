using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.OEEDTO
{
	[Serializable]
	[XmlRoot("BODY")]
	public class MachineControlStateChanged
	{
		/*
					<LINENAME />
					<CONTROLSTATENAME />
					<TIMESTAMP />
         */

		public string LINENAME { get; set; }
		public string CONTROLSTATENAME { get; set; }
		public string TIMESTAMP { get; set; }



	}
}
