using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPTankCleanRequest
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
        /// 批号
        /// </summary>
        public string LOTID {get;set;}

        /// <summary>
        /// 水箱ID
        /// </summary>
        /// 
        public string LOTTYPE { get; set; }

        /// <summary>
        /// 水箱ID
        /// </summary>
        public string TANKID {get;set;}

        /// <summary>
        /// 载具ID
        /// </summary>
        public string CARRIERID {get;set;}

        /// <summary>
        /// 载具种类
        /// </summary>
        public string CARRIERTYPE {get;set;}

        /// <summary>
        /// [Y:需要清洗， N:不需要清洗]
        /// </summary>
        public string CLEANREQUEST {get;set;}

    }
}
