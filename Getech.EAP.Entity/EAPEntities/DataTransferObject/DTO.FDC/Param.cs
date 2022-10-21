using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.FDCDTO
{
	public class Param
	{
        public string PARAM_VALUE;

        public string param_name { get; set; }
		public string param_value { get; set; }
	}
}
