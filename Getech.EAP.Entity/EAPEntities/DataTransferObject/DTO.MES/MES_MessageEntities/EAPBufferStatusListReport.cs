using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPBufferStatusListReport
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
        /// 单晶ID
        /// </summary>
        public string LOTID {get;set;}

        /// <summary>
        /// 料座ID
        /// </summary>
        public string CARRIERID {get;set;}

        /// <summary>
        /// 载具类型：MaterialBase
        /// </summary>
        public string CARRIERTYPE {get;set;}

        [XmlArray("BUFFERLIST")] 
        [XmlArrayItem("BUFFER")] 
        public List<BUFFER>BUFFERLIST { get; set; } 

    }
    public class BUFFER
    {
        /// <summary>
        /// 具体的Buffer ID
        /// </summary>
        public string BUFFERID {get;set;}
        /// <summary>
        /// [Empty，Full]
        /// </summary>
        public string BUFFERSTATUS {get;set;}
    }
}
