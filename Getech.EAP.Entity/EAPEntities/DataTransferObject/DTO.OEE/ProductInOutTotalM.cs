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
	public class ProductInOutTotalM
	{
		/*
					<LINENAME />
					<MACHINENAME />
					<PORTNAME />
					<TRACELEVEL />
					<POSITION />
					<LOTNAME />
					<LINERECIPENAME />
					<PRODUCTSPECNAME />
					<PROCESSOPERATIONNAME />
					<PRODUCTOWNER />
					<OWNERTYPE />
					<PRODUCTINFO />
					<CROSSLINEFLAG />
					<GLASSSIZE />
					<ORIENTEDSITE />
					<ORIENTEDFACTORYNAME />
					<CURRENTSITE />
					<CURRENTFACTORYNAME />
					<PRODUCTNAME />
					<HOSTPRODUCTNAME />
					<STARTTIMESTAMP />
					<ENDTIMESTAMP />
					<PRODUCTGRADE />
					<PRODUCTJUDGE />
					<SUBMACHINELIST>
						<SUBMACHINE>
							<UNITNAME />
							<PORTNAME />
							<TRACELEVEL />
							<POSITION />
							<STARTTIMESTAMP />
							<ENDTIMESTAMP />
						</SUBMACHINE>
					</SUBMACHINELIST>	
         */

		public string LINENAME { get; set; }
		public string MACHINENAME { get; set; }
		public string PORTNAME { get; set; }
		public string TRACELEVEL { get; set; }
		public string POSITION { get; set; }
		public string LOTNAME { get; set; }
		public string LINERECIPENAME { get; set; }
		public string PRODUCTSPECNAME { get; set; }
		public string PROCESSOPERATIONNAME { get; set; }
		public string PRODUCTOWNER { get; set; }
		public string OWNERTYPE { get; set; }
		//public string OWNERTYPE { get; set; }
		public string PRODUCTINFO { get; set; }
		public string CROSSLINEFLAG { get; set; }
		public string GLASSSIZE { get; set; }
		public string ORIENTEDSITE { get; set; }
		public string ORIENTEDFACTORYNAME { get; set; }
		public string CURRENTSITE { get; set; }
		public string CURRENTFACTORYNAME { get; set; }
		public string PRODUCTNAME { get; set; }
		public string HOSTPRODUCTNAME { get; set; }
		public string STARTTIMESTAMP { get; set; }
		public string ENDTIMESTAMP { get; set; }
		public string PRODUCTGRADE { get; set; }
		public string PRODUCTJUDGE { get; set; }


		[XmlArray("SUBMACHINELIST")]
		[XmlArrayItem("SUBMACHINE")]
		public List<SUBMACHINE> ITEMLIST { get; set; }

	}
	public class SUBMACHINE
	{
		public string UNITNAME { get; set; }
		public string PORTNAME { get; set; }
		public string TRACELEVEL { get; set; }
		public string POSITION { get; set; }
		public string STARTTIMESTAMP { get; set; }
		public string ENDTIMESTAMP { get; set; }
	}
}
