using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPTrackOutList
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string EQPID {get;set;}

        /// <summary>
        /// 设备Unit ID
        /// </summary>
        public string UNITID {get;set;}

        [XmlArray("CARRIERLIST")] 
        [XmlArrayItem("CARRIER")]
        public List<CARRIER>CARRIERLIST { get; set; }
        public string OPERATIONTYPE { get; set; }

    }
    //public class CARRIER
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
}
