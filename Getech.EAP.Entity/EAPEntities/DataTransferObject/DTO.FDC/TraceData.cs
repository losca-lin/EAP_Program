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
	public class TraceData
	{
		public string MACHINENAME { get; set; }
		public string STIME { get; set; }
		[XmlArray("SVIDLIST")]
		[XmlArrayItem("SVDATA")]
		public List<SVDATA> SVIDLIST { get; set; }
		public class SVDATA
		{
			/// <summary>
			/// FDCData Item名称
			/// </summary>
			
			public string SVID { get; set; }
			public string VALUE { get; set; }

		}

	}
}
