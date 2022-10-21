using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPBoxInBufferReport
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
        /// [A，B，C，D，E，F，G，H，I]Line
        /// </summary>
        public string LINEID {get;set;}

        /// <summary>
        /// [1，2]1：下口，2：上口
        /// </summary>
        public string BUFFERID {get;set;}

        /// <summary>
        /// 当前在Buffer内珍珠棉盒数量
        /// </summary>
        public string BOXINBUFFERQTY {get;set;}
        /// <summary>
        /// [1-3；1:下，2:中，3:上]
        /// </summary>
        public string BUFFERSLOT { get; set; }

    }
}
