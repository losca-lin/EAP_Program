using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.RVMessage.RVMessage
{
    [XmlRoot("MESSAGE")]
    public class RVMessageInfo
    {
        public RVMessageInfo()
        {
            Body = new List<Body>();
        }
        [XmlElement("HEADER")]
        public Header Header { get; set; }

        [XmlArray("BODY")]
        public List<Body> Body { get; set; }

        [XmlElement("RETURN")]
        public Return Rerutn { get; set; }

        public string StringXml { get; set; }
    }
}
