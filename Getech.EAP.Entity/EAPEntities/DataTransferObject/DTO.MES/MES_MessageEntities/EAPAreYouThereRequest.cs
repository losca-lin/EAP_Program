using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPAreYouThereRequest
    {
        /// <summary>
        /// EAPID
        /// </summary>
        public string EAPID {get;set;}

    }
}
