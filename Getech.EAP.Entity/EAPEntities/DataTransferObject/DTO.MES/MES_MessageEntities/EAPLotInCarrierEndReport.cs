using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPLotInCarrierEndReport
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
        /// [料座或者载具ID]
        /// </summary>
        public string CARRIERID {get;set;}

        /// <summary>
        /// [载具类型: 水箱]
        /// </summary>
        public string CARRIERTYPE {get;set;}

        /// <summary>
        /// [单个单晶总片篮数量]
        /// </summary>
        public string TOTALCARRIERQTY {get;set;}

        /// <summary>
        /// [脱胶：TJ，清洗：QX]
        /// </summary>
        public string OPERATIONTYPE {get;set;}

    }
}
