using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPControlModeChangeReport
    {
        /// <summary>
        /// EAPID
        /// </summary>
        public string EAPID {get;set;}

        /// <summary>
        /// 控制模式[Online,Offline]
        /// </summary>
        public string CONTROLMODE {get;set;}

        [XmlArray("EQPLIST")]
        [XmlArrayItem("EQP")]
        public List<EQP1> EQPLIST { get; set; }

    }

    public class EQP1
    {
        /// <summary>
        /// 具体的EQPID
        /// </summary>
        public string EQPID { get; set; }
    }
}
