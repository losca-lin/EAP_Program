using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPMaterialBaseAssignTankReport
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
        /// 晶棒ID或批次号
        /// </summary>
        public string LOTID {get;set;}

        /// <summary>
        /// 料座或者载具ID
        /// </summary>
        public string CARRIERID {get;set;}

        /// <summary>
        /// 载具种类
        /// </summary>
        public string CARRIERTYPE {get;set;}

        /// <summary>
        /// 水箱ID
        /// </summary>
        public string TANKID {get;set;}

    }
}
