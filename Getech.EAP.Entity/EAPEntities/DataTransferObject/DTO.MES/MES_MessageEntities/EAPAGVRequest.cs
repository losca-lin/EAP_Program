using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    //add by lc 20220421
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPAGVRequest
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
        public string GOODSTYPE {get;set;}

        /// <summary>
        /// 搬送物品的ID:比如晶棒ID
        /// </summary>
        public string GOODSID {get;set;}

        /// <summary>
        /// AGV动作:取料，放料
        /// </summary>
        public string OPTIONTYPE {get;set;}

        /// <summary>
        /// AGV位置
        /// </summary>
        public string USERID {get;set;}

    }
}
