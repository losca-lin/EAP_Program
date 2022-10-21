using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPAGVCommandCompleteReport
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
        /// [OK，NG]
        /// </summary>
        public string COMMANDRESULT {get;set;}

        /// <summary>
        /// 异常原因
        /// </summary>
        public string ABNORMALREASON {get;set;}

    }
}
