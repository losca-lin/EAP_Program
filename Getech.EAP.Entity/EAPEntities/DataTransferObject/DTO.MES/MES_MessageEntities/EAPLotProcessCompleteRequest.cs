using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPLotProcessCompleteRequest
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
        /// 晶棒ID或批次ID
        /// </summary>
        public string LOTID {get;set;}

        /// <summary>
        /// 载具ID
        /// </summary>
        public string CARRIERID {get;set;}

        /// <summary>
        /// 载具种类
        /// </summary>
        public string CARRIERTYPE {get;set;}
        public string CUTTERID { get; set; }

    }
}
