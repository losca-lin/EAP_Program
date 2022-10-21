using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPBinLabelRequest
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
        /// BIN的ID
        /// </summary>
        public string BINID {get;set;}

        /// <summary>
        /// Bin在分选机的位置
        /// </summary>
        public string BINPOSITION {get;set;}

        /// <summary>
        /// 对应recipe分选类别
        /// </summary>
        public string SORTINGTYPE {get;set;}

        /// <summary>
        /// BIN等级
        /// </summary>
        public string BINGRADE {get;set;}

        [XmlArray("LOTLIST")] 
        [XmlArrayItem("LOT")] 
        public List<LOT>LOTLIST { get; set; } 

    }
}
