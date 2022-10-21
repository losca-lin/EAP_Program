using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPEquipmentStateChangeReport
    {
        /// <summary>
        /// 
        /// </summary>
        public string EQPID {get;set;}

        /// <summary>
        /// 设备ID
        /// </summary>
        public string EQPSTATE {get;set;}

        [XmlArray("UNITLIST")] 
        [XmlArrayItem("UNIT")] 
        public List<STATEUNIT> UNITLIST { get; set; } 

    }
    public class STATEUNIT
    {
        /// <summary>
        /// 
        /// </summary>
        public string UNITID {get;set;}
        /// <summary>
        /// 子设备ID
        /// </summary>
        public string UNITSTATE {get;set;}
    }
}
