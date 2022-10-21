using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class MESGetAGVTransportJobStateReply
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
        /// 搬送任务ID
        /// </summary>
        /// 

    
        [XmlArray("TRANSPORTJOBLIST")]
        [XmlArrayItem("TRANSPORTJOB")]
        public List<TRANSPORTJOB> TRANSPORTJOBLIST { get; set; }
    }
    public class TRANSPORTJOB
        {
            /// <summary>
            /// 单晶LOTID
            /// </summary>
            public string TRANSPORTJOBNAME { get; set; }

            /// <summary>
            /// 搬送类型
            /// </summary>
            public string TRANSPORTJOBSTATE { get; set; }


        }
    
}
