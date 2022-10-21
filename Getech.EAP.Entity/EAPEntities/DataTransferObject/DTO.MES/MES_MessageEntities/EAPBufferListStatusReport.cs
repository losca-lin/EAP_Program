using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPBufferListStatusReport
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string EQPID {get;set;}

        /// <summary>
        /// 设备Unit ID
        /// </summary>
        public string UNITID {get;set;}

        [XmlArray("BUFFERLIST")] 
        [XmlArrayItem("BUFFERINFO")]
        public List<BUFFERINFO> BUFFERLIST { get; set; }
        

    }
    public class BUFFERINFO
    {
        public string BUFFERID { get; set; }
        public string BUFFERSTATUS { get; set; }
        public string LOTID { get; set; }
        public string CARRIERID { get; set; }
        public string CARRIERTYPE { get; set; }

    }
}
