using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_Reply
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPPackageBinInBoxReply
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string EQPID { get; set; }

        /// <summary>
        /// 设备Unit ID
        /// </summary>
        public string UNITID { get; set; }

        [XmlArray("BINIDLIST")]
        [XmlArrayItem("BIN")]
        public List<BIN> BINIDLIST { get; set; }

        /// <summary>
        /// 珍珠棉盒ID
        /// </summary>
        public string BOXID { get; set; }
        /// <summary>
        /// 珍珠棉盒在分选机的位置
        /// </summary>
        public string BOXPOSITION { get; set; }
        /// <summary>
        /// 包装号段
        /// </summary>
        public string SEGMENTNO { get; set; }
        /// <summary>
        /// 对应recipe分选类别
        /// </summary>
        public string SORTINGTYPE { get; set; }
        /// <summary>
        /// BOX等级
        /// </summary>
        public string BOXGRADE { get; set; }

    }
    public class BIN
    {
        /// <summary>
        /// 上料位置ID
        /// </summary>
        public string BINID { get; set; }

    }
}
