﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_Reply
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPBinLabelReply
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string EQPID { get; set; }

        /// <summary>
        /// 设备Unit ID
        /// </summary>
        public string UNITID { get; set; }
        /// <summary>
        /// 设备BIN ID
        /// </summary>
        public string BINID { get; set; }

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
        /// 生成的标签编码
        /// </summary>
        public string LABELID { get; set; }
        /// <summary>
        /// 生成的标签内容
        /// </summary>
        public string LABELINFO { get; set; }

    }
}
