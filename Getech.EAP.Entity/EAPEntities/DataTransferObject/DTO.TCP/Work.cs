using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.TCP
{
	[Serializable]
	[XmlRoot("BODY")]
	public class Work
	{
		public string WORKID { get; set; }
		public string WAFERQUANTITY { get; set; }
	}
}
