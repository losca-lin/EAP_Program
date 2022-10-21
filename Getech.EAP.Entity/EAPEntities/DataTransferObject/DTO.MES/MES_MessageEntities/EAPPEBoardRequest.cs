using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPPEBoardRequest
    {
        /// <summary>
        /// EAPID
        /// </summary>
        public string EQPID {get;set;}

        /// <summary>
        /// UNITID
        /// </summary>
        public string UNITID {get;set;}

    }
}
