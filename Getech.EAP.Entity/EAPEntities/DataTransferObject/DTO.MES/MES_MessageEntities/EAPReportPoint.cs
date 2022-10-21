using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPReportPoint
    {
        public string SN { get; set; }
        public string POSITION { get; set; }
        public string EAPSUBJECTNAME { get; set; }

        public string MACHINEID { get; set; }
    }
}


