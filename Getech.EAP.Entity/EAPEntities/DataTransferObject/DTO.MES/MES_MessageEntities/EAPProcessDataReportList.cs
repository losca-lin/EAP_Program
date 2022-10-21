using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPProcessDataReportList
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
        /// [Normal End，Abnormal End]
        /// </summary>
        public string RECIPEID {get;set;}

        [XmlArray("CARRIERLIST")] 
        [XmlArrayItem("CARRIER1")] 
        public List<CARRIER1> CARRIERLIST { get; set; } 

        [XmlArray("ITEMLIST")] 
        [XmlArrayItem("ITEM")] 
        public List<ITEM>ITEMLIST { get; set; } 

    }
    //public class CARRIER1
    //{
    //    /// <summary>
    //    /// 单晶ID
    //    /// </summary>
    //    public string LOTID {get;set;}
    //    /// <summary>
    //    /// 料座或者载具ID
    //    /// </summary>
    //    public string CARRIERID {get;set;}
    //    /// <summary>
    //    /// 载具种类
    //    /// </summary>
    //    public string CARRIERTYPE {get;set;}
    //    /// <summary>
    //    /// 片蓝Wafer数量
    //    /// </summary>
    //    public string WAFERQTY {get;set;}
    //}
    //public class ITEM
    //{
    //    /// <summary>
    //    /// process data item名称
    //    /// </summary>
    //    public string ITEMNAME {get;set;}
    //    /// <summary>
    //    /// process data item数值
    //    /// </summary>
    //    public string ITEMVALUE {get;set;}
    //}
}
