using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPJobScrappedReport
    {
        /// <summary>
        /// 线切机台
        /// </summary>
        public string EQPID {get;set;}

        /// <summary>
        /// 设备UnitID
        /// </summary>
        public string UNITID {get;set;}

        /// <summary>
        /// 批次号或晶棒ID
        /// </summary>
        public string LOTID {get;set;}

        /// <summary>
        /// 报废位置
        /// </summary>
        public string POSITION {get;set;}

        /// <summary>
        /// 报废数量
        /// </summary>
        public string SCRAPCOUNT {get;set;}

        /// <summary>
        /// 报废码
        /// </summary>
        public string SCRAPCODE {get;set;}

        /// <summary>
        /// 报废种类（是切片前的或者切片后的）
        /// </summary>
        public string SCRAPTYPE {get;set;}

    }
}
