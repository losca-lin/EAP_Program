using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_Reply
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPFoamBoxCartonIDReply
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string EQPID { get; set; }

        /// <summary>
        /// 设备Unit ID
        /// </summary>
        public string UNITID { get; set; }

        [XmlArray("BOXLIST")]
        [XmlArrayItem("BOX")]
        public List<BOX> BOXLIST { get; set; }

        /// <summary>
        /// 包装号段
        /// </summary>
        public string SEGMENTNO { get; set; }
        /// <summary>
        /// 外箱ID
        /// </summary>
        public string CARTONID { get; set; }

    }
    public class BOX
    {
        /// <summary>
        /// 泡沫盒ID
        /// </summary>
        public string BOXID { get; set; }
    }
}
