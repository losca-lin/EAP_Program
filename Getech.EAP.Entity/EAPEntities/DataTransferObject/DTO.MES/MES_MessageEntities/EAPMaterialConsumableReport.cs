using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPMaterialConsumableReport
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
        /// 物料种类(AB胶如何区分)
        /// </summary>
        public string MATERIALTYPE {get;set;}

        /// <summary>
        /// 损耗量
        /// </summary>
        public string MATERIALCONSUMABLEDCOUNT {get;set;}

        /// <summary>
        /// 消耗类型：自损，消耗[Self Losses,Produce]
        /// </summary>
        public string MATERIALCONSUMABLEDTYPE {get;set;}

    }
}
