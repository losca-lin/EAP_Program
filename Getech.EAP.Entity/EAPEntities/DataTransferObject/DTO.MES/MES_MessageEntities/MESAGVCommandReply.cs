using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class MESAGVCommandReply
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
        /// 搬送任务ID
        /// </summary>
        public string TASKID {get;set;}

        /// <summary>
        /// 搬送类型
        /// </summary>
        public string GOODSTYPE {get;set;}

        /// <summary>
        /// 搬送物品的ID:比如晶棒ID
        /// </summary>
        public string GOODSID {get;set;}

        /// <summary>
        /// 取货口
        /// </summary>
        public string SOURCEPORT {get;set;}

        /// <summary>
        /// 放货口
        /// </summary>
        public string TARGETPORT {get;set;}

        /// <summary>
        /// 搬送任务ID
        /// </summary>
        public string RESULT { get;set;}

    }
}
