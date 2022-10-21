using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPCheckPalletIDRequest
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
        /// 外箱ID
        /// </summary>
        public string PALLETID {get;set;}

        /// <summary>
        /// 位置信息
        /// </summary>
        public string PAUSEPOSITION {get;set;}

    }
}
