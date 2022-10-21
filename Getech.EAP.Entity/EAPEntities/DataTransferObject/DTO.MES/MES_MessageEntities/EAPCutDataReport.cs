using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPCutDataReport
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
        /// 产品ID
        /// </summary>
        public string LOTID {get;set;}

        /// <summary>
        /// 切割结果[OK，NG]
        /// </summary>
        public string CUTRESULT {get;set;}

        /// <summary>
        /// 切割时使用Recipe ID
        /// </summary>
        public string RECIPEID {get;set;}

        /// <summary>
        /// 切割使用的物料名称
        /// </summary>
        public string USEDMATERIALNAME {get;set;}

        /// <summary>
        /// 切割使用的物料种类
        /// </summary>
        public string USEDMATERIALTYPE {get;set;}

        /// <summary>
        /// 切割NG原因
        /// </summary>
        public string FAILREASON {get;set;}

        /// <summary>
        /// 开始切割时间：YYMMDD HHMMSS
        /// </summary>
        public string CUTSTARTTIME {get;set;}

        /// <summary>
        /// 结束切割时间：YYMMDD HHMMSS
        /// </summary>
        public string CUTENDTIME {get;set;}

        /// <summary>
        /// 断缝断线距离头部位置，人工输入
        /// </summary>
        public string BREAKPOSITION {get;set;}

    }
}
