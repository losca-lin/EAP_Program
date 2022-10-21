using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPPackageCartonInPalletRequest
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string EQPID {get;set;}

        /// <summary>
        /// 设备Unit ID
        /// </summary>
        public string UNITID {get;set;}

        /// <summary>
        /// 外箱ID
        /// </summary>
        public string CARTONID {get;set;}

        /// <summary>
        /// 目前是装托的第几箱
        /// </summary>
        public string SEQUENCE {get;set;}

        /// <summary>
        /// 1~24
        /// </summary>
        public string STACKPORT {get;set;}

    }
}
