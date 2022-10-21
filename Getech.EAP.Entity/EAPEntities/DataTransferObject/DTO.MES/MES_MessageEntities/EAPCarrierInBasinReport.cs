using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPCarrierInBasinReport
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
        /// 水槽 ID
        /// </summary>
        public string BASINID {get;set;}

        [XmlArray("CARRIERLIST")] 
        [XmlArrayItem("CARRIER")] 
        public List<CARRIER>CARRIERLIST { get; set; }
        public string TANKID { get; set; }
        public string OPERATIONTYPE { get; set; }

    }
    public class CARRIER
    {
        /// <summary>
        /// 片篮
        /// </summary>
        public string LOTID {get;set;}
        /// <summary>
        /// 片篮Lot ID
        /// </summary>
        public string CARRIERID {get;set;}
        /// <summary>
        /// 片篮ID
        /// </summary>
        public string CARRIERTYPE {get;set;}
        public string WAFERQTY { get; set; }
      
    }
}
