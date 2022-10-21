using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPFoamBoxCartonIDRequest
    {
        /// <summary>
        /// EAPID
        /// </summary>
        public string EQPID {get;set;}

        /// <summary>
        /// UNITID
        /// </summary>
        public string UNITID {get;set;}

        public string BOXID { get; set; }

        //[XmlArray("BOXLIST")] 
        //[XmlArrayItem("BOX")] 
        //public List<BOX>BOXLIST { get; set; } 

    }
}
