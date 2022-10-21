using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPPackageBinInBoxRequest
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
        /// 珍珠棉盒ID
        /// </summary>
        public string BOXID {get;set;}

        /// <summary>
        /// 珍珠棉盒在分选机的位置
        /// </summary>
        public string BOXPOSITION {get;set;}

        /// <summary>
        /// 对应recipe分选类别
        /// </summary>
        public string SORTINGTYPE {get;set;}

        /// <summary>
        /// Bin等级
        /// </summary>
        public string BINGRADE {get;set;}

        [XmlArray("BINIDLIST")] 
        [XmlArrayItem("BIN")] 
        public List<BIN>BINIDLIST { get; set; } 

    }
    public class BIN
    {
        /// <summary>
        /// BIINID
        /// </summary>
        public string BINID {get;set;}
        /// <summary>
        /// 删除
        /// </summary>
        //public string BINGRADE {get;set;}
        /// <summary>
        /// 删除
        /// </summary>
        //public string WAFERINBINQTY {get;set;}
    }
}
