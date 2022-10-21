using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.FDCDTO
{
    [Serializable]
    [XmlRoot("BODY")]
    public class PanelProductIn
    {

        public string LINENAME { get; set; }
        public string MACHINENAME { get; set; }
        public string UNITNAME { get; set; }
        public string PORTNAME { get; set; }
        public string LOTNAME { get; set; }
        public string TRACELEVEL { get; set; }
        public string POSITION { get; set; }
        public string PRODUCTNAME { get; set; }
        public string HOSTPRODUCTNAME { get; set; }
        public string PROCESSINGTIME { get; set; }
        public string MGRADE { get; set; }
        public string PGRADE { get; set; }
    }
}
