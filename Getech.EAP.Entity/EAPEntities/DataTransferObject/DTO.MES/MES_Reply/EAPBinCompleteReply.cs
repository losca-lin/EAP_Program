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
    public class EAPBinCompleteReply
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string EQPID { get; set; }

        /// <summary>
        /// 设备Unit ID
        /// </summary>
        public string UNITID { get; set; }

        [XmlArray("LOTLIST")]
        [XmlArrayItem("LOT")]
        public List<LOT> LOTLIST { get; set; }

        /// <summary>
        /// 珍珠棉盒ID
        /// </summary>
        public string BINPOSITION { get; set; }
        /// <summary>
        /// 珍珠棉盒在分选机的位置
        /// </summary>
        public string SORTINGTYPE { get; set; }
        /// <summary>
        /// 包装号段
        /// </summary>
        public string BINID { get; set; }

    }
    public class LOT
    {
        /// <summary>
        /// 单晶LOTID
        /// </summary>
        public string LOTID { get; set; }
        /// <summary>
        /// 刀号
        /// </summary>
        public string CUTTERID { get; set; }
        /// <summary>
        /// 来自此单晶的晶片数
        /// </summary>
        public string WAFERQUANTITY { get; set; }

    }
}
