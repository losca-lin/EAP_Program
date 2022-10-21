using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPDestinationMBRequest
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
        /// [料座ID]
        /// </summary>
        public string CARRIERID {get;set;}

        /// <summary>
        /// 料座或其他载具类别
        /// </summary>
        public string CARRIERTYPE {get;set;}

        /// <summary>
        /// [产品停止位置]

        /// </summary>
        public string PAUSEPOSITION {get;set;}

    }
}
