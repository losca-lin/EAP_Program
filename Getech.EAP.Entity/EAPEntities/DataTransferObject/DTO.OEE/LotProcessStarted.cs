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
	public class LotProcessStarted
	{
		/*
					<LINENAME />
					<TIMESTAMP />
					<PORTNAME />
					<PORTTYPE />
					<CARRIERNAME />
					<LOTLIST>
						<LOT>
							<LOTNAME />
							<LINERECIPENAME />
							<PRODUCTRECIPENAME />
							<PRODUCTSPECNAME />
							<PROCESSOPERATIONNAME />
							<PRODUCTQUANTITY />
							<PRODUCTOWNER />
							<OWNERTYPE />
							<LOTINFO />
						</LOT>
					</LOTLIST>
         */

		public string LINENAME { get; set; }
		public string TIMESTAMP { get; set; }
		public string PORTNAME { get; set; }
		public string PORTTYPE { get; set; }
		public string CARRIERNAME { get; set; }

		[XmlArray("LOTLIST")]
		[XmlArrayItem("LOT")]
		public List<LOT> ITEMLIST { get; set; }

	}
	public class LOT
	{
		public string LOTNAME { get; set; }
		public string LINERECIPENAME { get; set; }
		public string PRODUCTRECIPENAME { get; set; }
		public string PRODUCTSPECNAME { get; set; }
		public string PROCESSOPERATIONNAME { get; set; }
		public string PRODUCTQUANTITY { get; set; }
		public string PRODUCTOWNER { get; set; }
		public string OWNERTYPE { get; set; }
		public string LOTINFO { get; set; }
	}
}
