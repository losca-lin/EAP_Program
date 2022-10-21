using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.FDCDTO
{
	[Serializable]
	[XmlRoot("MESSAGE")]
	public class ProductIn
	{
		public string MESSAGE_ID { get; set; }
		public string TRANSACTIONID { get; set; }
		public string LINENAME { get; set; }
		public string MACHINENAME { get; set; }
		public string UNITNAME { get; set; }
		public string PORTNAME { get; set; }
		public string TRACELEVEL { get; set; }
		public string LOTNAME { get; set; }
		public string JOBRECIPENAME { get; set; }
		public string PRODUCTSPECNAME { get; set; }
		public string PROCESSOPERATIONNAME { get; set; }
		public string PRODUCTOWNER { get; set; }
		public string POSITION { get; set; }
		public string PRODUCTNAME { get; set; }
		public string HOSTPRODUCTNAME { get; set; }
		public string TIMESTAMP { get; set; }
		public string LASTGLASSFLAG { get; set; }

	}
}
