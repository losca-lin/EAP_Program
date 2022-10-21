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
	public class PortTransferStateChanged
	{
		/*
					<LINENAME />
					<MACHINENAME />
					<TIMESTAMP />
					<PORTLIST>
						<PORT>
							<PORTNAME />
							<PORTTRANSFERSTATE />
							<CARRIERNAME />
							<PRODUCTGRADE />
						</PORT>
					</PORTLIST>
         */

		public string LINENAME { get; set; }
		public string MACHINENAME { get; set; }
		public string TIMESTAMP { get; set; }

		[XmlArray("PORTLIST")]
		[XmlArrayItem("PORT")]
		public List<PORT> ITEMLIST { get; set; }

	}
	public class PORT
	{
		public string PORTNAME { get; set; }
		public string PORTTRANSFERSTATE { get; set; }
		public string CARRIERNAME { get; set; }
		public string PRODUCTGRADE { get; set; }
	}
}
