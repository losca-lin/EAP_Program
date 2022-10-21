using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPTrackOut
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
        /// 产品ID
        /// </summary>
        public string LOTID {get;set;}

        /// <summary>
        /// 载具ID
        /// </summary>
        public string CARRIERID {get;set;}

        /// <summary>
        /// 载具类型
        /// </summary>
        public string CARRIERTYPE {get;set;}

        /// <summary>
        /// 额外载具ID
        /// </summary>
        public string EXCARRIERID {get;set;}

        /// <summary>
        /// 额外载具类型
        /// </summary>
        public string EXCARRIERTYPE {get;set;}

        public string OPERATIONTYPE { get; set; }

    }
}
