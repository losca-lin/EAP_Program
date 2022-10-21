using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.ENGDTO
{
	[Serializable]
	[XmlRoot("MESSAGE")]
	public class EnergyReport
	{
		public string message_id { get; set; }
		public string line_id { get; set; }
		public string eqp_id { get; set; }
		public string timestamp { get; set; }
		public string eqp_status { get; set; }
		public string recipe_id { get; set; }
		public string glass_id { get; set; }

		[XmlArray("param_list")]
		[XmlArrayItem("param")]
		public List<ENGParam> paraList { get; set; }
	}
	public class ENGParam
	{
		public string unit_id { get; set; }
		public string meter_no { get; set; }
		public string energy_type { get; set; }
		public string refresh { get; set; }
		public string value1 { get; set; }
		public string value2 { get; set; }
		public string value3 { get; set; }
		public string value4 { get; set; }
		public string total_value { get; set; }
	}
}
