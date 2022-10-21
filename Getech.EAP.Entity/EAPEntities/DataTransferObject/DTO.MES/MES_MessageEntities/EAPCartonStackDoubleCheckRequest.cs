using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPCartonStackDoubleCheckRequest
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
        /// 产品停止位置
        /// </summary>
        public string PAUSEPOSITION {get;set;}

        /// <summary>
        /// [码垛口：1-24]
        /// </summary>
        public string STACKPORT {get;set;}

        /// <summary>
        /// [当前码垛位纸箱数量]
        /// </summary>
        public string CARTONQUANTITY {get;set;}

    }
}
