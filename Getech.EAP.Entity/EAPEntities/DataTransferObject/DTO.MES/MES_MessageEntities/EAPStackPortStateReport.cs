using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPStackPortStateReport
    {
        /// <summary>
        /// 
        /// </summary>
        public string EQPID {get;set;}

        /// <summary>
        /// 
        /// </summary>
        public string UNITID {get;set;}

        [XmlArray("STACKPORTLIST")] 
        [XmlArrayItem("STACKPORT")] 
        public List<STACKPORT>STACKPORTLIST { get; set; } 

    }
    public class STACKPORT
    {
        /// <summary>
        /// 码垛PORT[1-20,21-24]
        /// </summary>
        public string STACKPORTID {get;set;}
        /// <summary>
        /// [Available，NotAvailable]
        /// </summary>
        public string STACKPORTSTATE {get;set;}
    }
}
