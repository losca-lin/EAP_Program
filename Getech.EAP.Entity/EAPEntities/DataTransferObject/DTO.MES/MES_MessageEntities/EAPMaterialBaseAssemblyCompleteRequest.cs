using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPMaterialBaseAssemblyCompleteRequest
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
        /// 料座或者载具ID
        /// </summary>
        public string CARRIERID {get;set;}

        /// <summary>
        /// 载具种类
        /// </summary>
        public string CARRIERTYPE {get;set;}

        /// <summary>
        /// 树脂板ID
        /// </summary>
        public string PEBOARDID {get;set;}

        /// <summary>
        /// 树脂板批次号
        /// </summary>
        public string PEBOARDBATCHID {get;set;}

        /// <summary>
        /// 树脂板规格类型
        /// </summary>
        public string PEBOARDSPEC {get;set;}

    }
}
