using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPProcessDataReport
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
        /// 载具种类
        /// </summary>
        public string CARRIERTYPE {get;set;}

        /// <summary>
        /// 使用Recipe ID
        /// </summary>
        public string RECIPEID {get;set;}

        [XmlArray("ITEMLIST")] 
        [XmlArrayItem("ITEM")] 
        public List<ITEM>ITEMLIST { get; set; } 

    }
    public class ITEM
    {
        /// <summary>
        /// ProcessData Item名称
        /// </summary>
        public string ITEMNAME {get;set;}
        /// <summary>
        /// ProcessData Item数值
        /// </summary>
        public string ITEMVALUE {get;set;}
    }
}
