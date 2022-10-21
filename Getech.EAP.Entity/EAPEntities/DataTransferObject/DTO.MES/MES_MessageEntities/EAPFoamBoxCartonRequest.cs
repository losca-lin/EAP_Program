using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPFoamBoxCartonRequest
    {
        /// <summary>
        /// EAPID
        /// </summary>
        public string EQPID { get; set; }
        public string UNITID { get; set; }

        /// <summary>
        /// UNITID
        /// </summary>

        public string BOXID { get; set; }

        /* [XmlArray("BOXLIST")] 
         [XmlArrayItem("BOX")] 
         public List<BOX>BOXLIST { get; set; } 

     }
     public class BOX
     {
         /// <summary>
         /// 
         /// </summary>
         public string BOXID {get;set;}
     }*/
    }
}
