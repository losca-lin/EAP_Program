using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPCancelTrackInRequest
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
        /// 料座或者载具ID
        /// </summary>
        public string CARRIERID {get;set;}

        /// <summary>
        /// [MaterialBase: 料座， Tank: 水箱，包装部分待确认]
        /// </summary>
        public string CARRIERTYPE {get;set; }
        public string REASONTEXT { get; set; }

    }
}
