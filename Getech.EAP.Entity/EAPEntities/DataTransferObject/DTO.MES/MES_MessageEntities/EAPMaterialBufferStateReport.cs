using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPMaterialBufferStateReport
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
        /// 缓存区ID
        /// </summary>
        public string BUFFERID {get;set;}

        [XmlArray("PORTLIST")] 
        [XmlArrayItem("PORT")] 
        public List<PORT>PORTLIST { get; set; } 

    }
    //public class PORT
    //{
    //    /// <summary>
    //    /// PORT号
    //    /// </summary>
    //    public string PORTID {get;set;}
    //    /// <summary>
    //    /// PORT状态
    //    /// </summary>
    //    public string PORTSTATE {get;set;}
    //}
}
