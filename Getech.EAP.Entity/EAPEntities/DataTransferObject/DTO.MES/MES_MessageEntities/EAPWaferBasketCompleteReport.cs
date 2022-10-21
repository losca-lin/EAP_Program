using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPWaferBasketCompleteReport
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
        /// 晶棒ID
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

        /// <summary>
        /// 插片Wafer数量
        /// </summary>
        public string WAFERQTY {get;set;}

        /// <summary>
        /// 当前晶棒的插片片蓝序 LOTID01.LOTID02
        /// </summary>
        public string SEQUENCENO {get;set;}

        /// <summary>
        /// 脱胶：TJ，清洗：QX]
        /// </summary>
        public string OPERATIONTYPE {get;set; }
        public string EMPTYWAFERBASKETRECYCLE { get; set; }

        

    }
}
