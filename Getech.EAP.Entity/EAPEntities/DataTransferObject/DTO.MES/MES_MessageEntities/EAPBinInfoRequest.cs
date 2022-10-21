using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPBinInfoRequest
    {
        /// <summary>
        /// EAPID
        /// </summary>
        public string EAPID {get;set;}

        /// <summary>
        /// UNITID
        /// </summary>
        public string UNITID {get;set;}

        /// <summary>
        /// BINID
        /// </summary>
        public string BINID {get;set;}

    }
}
