using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPMaterialCuringHardnessReport
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
        /// 载具ID
        /// </summary>
        public string CARRIERID {get;set;}

        /// <summary>
        /// 载具种类
        /// </summary>
        public string CARRIERTYPE {get;set;}

        /// <summary>
        /// 固化硬度
        /// </summary>
        public string CURINGHARDNESS {get;set;}

    }
}
