using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPEmptyMaterialBaseValidationRequest
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
        /// [料座左侧RFID]
        /// </summary>
        public string MATERIALBASELEFTRFID {get;set;}

        /// <summary>
        /// [料座右侧RFID]
        /// </summary>
        public string MATERIALBASERIGHTRFID {get;set;}

        /// <summary>
        /// 料座或其他载具类别
        /// </summary>
        public string CARRIERTYPE {get;set;}

    }
}
