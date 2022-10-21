using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.FDCDTO
{
	[Serializable]
	[XmlRoot("Body")]
	public class ProductInEqp
	{
		public string MACHINENAME { get; set; }
		public string LOTNAME { get; set; }
		public string PRODUCT_ID { get; set; }
		public string WAFERID { get; set; }
		public string PRODUCTRECIPE { get; set; }
		
	}
}
