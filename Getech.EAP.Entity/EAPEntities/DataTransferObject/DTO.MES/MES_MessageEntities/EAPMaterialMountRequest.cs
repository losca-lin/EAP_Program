using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPMaterialMountRequest
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
        /// 物料名称
        /// </summary>
        public string MATERIALNAME {get;set;}

        /// <summary>
        /// 物料位置
        /// </summary>
        public string MATERIALPOSITION {get;set;}

        /// <summary>
        /// 物料种类
        /// </summary>
        public string MATERIALTYPE {get;set;}

        /// <summary>
        /// [MOUNT,UNMOUNT]
        /// </summary>
        public string OPERATIONTYPE {get;set;}

        /// <summary>
        /// SYSTEM[userid,system,EAPNum]
        /// </summary>
        public string USERID {get;set;}

    }
}
