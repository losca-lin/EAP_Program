using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPBinTrackIn
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
        /// 珍珠棉盒ID
        /// </summary>
        public string BOXID {get;set;}

        [XmlArray("BINLIST")] 
        [XmlArrayItem("BIN")] 
        public List<BIN>BINLIST { get; set; } 

    }
}
