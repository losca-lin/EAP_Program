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
	public class AlarmReport
	{
		/*
					<LINENAME />
					<MACHINENAME />
					<UNITNAME />
					<ALARMCODE />
					<ALARMLEVEL />
					<ALARMSTATE />
					<ALARMTEXT />
					<ALARMID />
					<ALARMREASONCODE />
					<ALARMREASONCODETEXT />
					<TIMESTAMP />		
         */

		public string LINENAME { get; set; }
		public string MACHINENAME { get; set; }
		public string UNITNAME { get; set; }
		public string ALARMCODE { get; set; }
		public string ALARMLEVEL { get; set; }
		public string ALARMSTATE { get; set; }
		public string ALARMTEXT { get; set; }
		public string ALARMID { get; set; }
		public string ALARMREASONCODE { get; set; }
		public string ALARMREASONCODETEXT { get; set; }
		public string TIMESTAMP { get; set; }


	}
}
