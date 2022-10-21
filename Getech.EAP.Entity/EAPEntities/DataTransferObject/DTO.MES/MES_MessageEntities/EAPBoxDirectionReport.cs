using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPBoxDirectionReport
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
        /// 批次号
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
        /// [A，B，C，D，E，F，G，H，I]Line
        /// </summary>
        public string TARGETLINEID {get;set;}

        /// <summary>
        /// [1，2]1：下口，2：上口
        /// </summary>
        public string TARGETBUFFERID {get;set;}

    }
}
