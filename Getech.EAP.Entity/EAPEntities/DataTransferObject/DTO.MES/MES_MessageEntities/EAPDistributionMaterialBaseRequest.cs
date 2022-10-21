using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPDistributionMaterialBaseRequest
    {
        /// <summary>
        /// EAPID
        /// </summary>
        public string EQPID {get;set;}

        /// <summary>
        /// UNITID
        /// </summary>
        public string UNITID {get;set;}

        /// <summary>
        /// 产品停止位置
        /// </summary>
        public string PAUSEPOSITION {get;set;}

        /// <summary>
        /// 料座ID
        /// </summary>
        public string CARRIERID {get;set;}

        /// <summary>
        /// 载具种类：MaterialBase
        /// </summary>
        public string CARRIERTYPE {get;set;}

    }
}
