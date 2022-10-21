using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPBinCompleteRequest
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
        /// Bin在分选机的位置
        /// </summary>
        public string BINPOSITION {get;set;}

        /// <summary>
        /// 对应recipe分选类别
        /// </summary>
        public string SORTINGTYPE {get;set;}

        [XmlArray("LOTLIST")] 
        [XmlArrayItem("LOT")] 
        public List<LOT>LOTLIST { get; set; } 

    }
    public class LOT
    {
        /// <summary>
        /// 单晶
        /// </summary>
        public string LOTID {get;set;}
        /// <summary>
        /// 单晶LOTID
        /// </summary>
        public string CUTTERID {get;set;}
        /// <summary>
        /// 刀号
        /// </summary>
        public string WAFERQUANTITY {get;set;}
    }
}
