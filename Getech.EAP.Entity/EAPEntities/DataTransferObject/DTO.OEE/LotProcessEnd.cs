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
	public class LotProcessEnd
	{
		public string LINENAME { get; set; }
		public string TIMESTAMP { get; set; }
		public string PORTNAME { get; set; }
		public string PORTTYPE { get; set; }
		public string PORTMODE { get; set; }
		public string CARRIERNAME { get; set; }

		[XmlArray("PRODUCTLIST")]
		[XmlArrayItem("PRODUCT")]
		public List<PRODUCT> ITEMLIST { get; set; }

	}
	public class PRODUCT
	{
		public string POSITION { get; set; }
		public string PRODUCTNAME { get; set; }
		public string PRODUCTJUDGE { get; set; }
		public string PRODUCTGRADE { get; set; }
		public string SUBPRODUCTGRADES { get; set; }
		public string PAIRPRODUCTNAME { get; set; }
		public string HOSTPRODUCTNAME { get; set; }
		public string LOTNAME { get; set; }
		public string LINERECIPENAME { get; set; }
		public string PRODUCTRECIPENAME { get; set; }
		public string PRODUCTSPECNAME { get; set; }
		public string PROCESSOPERATIONNAME { get; set; }
		public string PRODUCTOWNER { get; set; }
		public string OWNERTYPE { get; set; }
		public string LOTINFO { get; set; }
		public string ABNORMALCODELIST { get; set; }
		public string HOLDFLAG { get; set; }
		public string PSHEIGHTLIST { get; set; }

		public string PROCESSRESULT { get; set; }

	}
}
