using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.DTO.MES.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    //add by lb 220826
    public class EAPEmptyTankDestinationRequest
    {
        public string EQPID { get; set; }
        public string UNITID { get; set; }
        public string TANKID { get; set; }
        public string PAUSEPOSITION { get; set; }
    }
}
