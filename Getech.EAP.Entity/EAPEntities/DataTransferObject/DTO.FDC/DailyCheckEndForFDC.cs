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
	public class DailyCheckEndForFDC
	{
		public string MESSAGE_ID { get; set; }
		public string TRANSACTIONID { get; set; }
		public string SYSTEMBYTE { get; set; }
		public string TIMESTAMP { get; set; }
		public string LINENAME { get; set; }


		[XmlArray("EQP_LIST")]
		[XmlArrayItem("EQP")]
		public List<EQP> eqpList { get; set; }
		/*
		 <EQP_LIST>
			<EQP>
				<MACHINENAME />
				<CHECK_TIME />
				<SUBEQP_LIST>
					<SUBEQP>
						<UNITNAME />
						<PARAM_LIST>
							<PARAM>
								<PARAM_NAME />
								<PARAM_VALUE />
							</PARAM>
						</PARAM_LIST>
					</SUBEQP>
				</SUBEQP_LIST>
			</EQP>
		</EQP_LIST>
		 
		 */
		public class EQP
		{
			public string MACHINENAME { get; set; }
			public string CHECK_TIME { get; set; }


			[XmlArray("SUBEQP_LIST")]
			[XmlArrayItem("SUBEQP")]
			public List<SUBEQP> eqpList { get; set; }
		}

		public class SUBEQP
		{
			public string UNITNAME { get; set; }

			[XmlArray("PARAM_LIST")]
			[XmlArrayItem("PARAM")]
			public List<Param> paraList { get; set; }
		}
	}
}
