using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    //add by lc 20220421
    [Serializable]
    [XmlRoot("BODY")]
    public class MESRequestGHKPortChange
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
        /// 任务ID
        /// </summary>
        public string PORTID {get;set;}

        /// <summary>
        /// 搬送类型
        /// </summary>
        public string LOTID {get;set;}

        /// <summary>
        /// 搬送物品的ID:比如晶棒ID
        /// </summary>
        public string CARRIERID {get;set;}

        public string RFID { get; set; }



    }
}
