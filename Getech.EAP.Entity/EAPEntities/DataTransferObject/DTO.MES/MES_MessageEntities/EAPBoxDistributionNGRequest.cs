using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPBoxDistributionNGRequest
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
        /// 珍珠棉盒ID
        /// </summary>
        public string BOXID {get;set;}

        /// <summary>
        /// 产品停止位置
        /// </summary>
        public string PAUSEPOSITION {get;set;}

    }
}
