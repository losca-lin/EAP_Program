using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EDADTO
{
	[Serializable]
	[XmlRoot("MESSAGE")]
	public class DW4EdcDataSend
	{
		public string MESSAGENAME { get; set; }
		public string TRANSITION { get; set; }
		public string TIMESTAMP { get; set; }
		//public string LINE_ID { get; set; }
		public string EQP_ID { get; set; }
		//public string MAIN_UNIT_ID { get; set; }
		public string LOT_ID { get; set; }
		public string RECIPE_ID { get; set; }
		/*public string OWNER_CODE { get; set; }
		public string OWNER_TYPE { get; set; }
		public string INSPECT_TIME { get; set; }
		public string TRACK_IN_TIME { get; set; }
		public string TRACK_OUT_TIME { get; set; }*/

		/*[XmlArray("UNIT_LIST")]
		[XmlArrayItem("UNIT")]
		public List<Unit> UNITLIST { get; set; }
		public class Unit
		{
			/// <summary>
			/// ProcessData Item名称
			/// </summary>
			public string UNIT_ID { get; set; }
			public string START_TIME { get; set; }
			public string END_TIME { get; set; }
		}*/
	

	    [XmlArray("PARAM_LIST")]
		[XmlArrayItem("PARAM")]
		public List<Param> PARALIST { get; set; }
		public class Param
		{
			/// <summary>
			/// ProcessData Item名称
			/// </summary>
			/*public string INSPECT_TIME { get; set; }
			public string PRODUCT_NAME { get; set; }
			public string PRODUCTTYPE { get; set; }
			public string RECIPE_NAME { get; set; }*/
			public string PARAM_NAME { get; set; }
			public string PARAM_VALUE { get; set; }

			/*[XmlArray("SITE_LIST")]
			[XmlArrayItem("SITE")]
			public List<Site> SITELIST { get; set; }*/
			
		}
		/*public class Site
		{
			public int SITE_NAME { get; set; }
			public string PARAM_VALUE { get; set; }
		}*/
	}

	
}
