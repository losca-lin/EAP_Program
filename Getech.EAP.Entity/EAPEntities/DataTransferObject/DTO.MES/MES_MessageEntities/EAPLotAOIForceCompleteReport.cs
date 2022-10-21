using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    //add by lc 20220726
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPLotAOIForceCompleteReport

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
        /// 刀号
        /// </summary>
        public string CUTTERID {get;set;}

        /// <summary>
        /// 尾篮id
        /// </summary>
        public string LASTWAFERBASKETID { get;set;}


    }
}
