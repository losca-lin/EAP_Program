using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_Reply
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPPEBoardReply
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string EQPID { get; set; }

        /// <summary>
        /// 设备Unit ID
        /// </summary>
        public string UNITID { get; set; }

         [XmlArray("POSITIONLIST")]
          [XmlArrayItem("POSITION")]
          public List<POSITION> POSITIONLIST { get; set; }

      }
        public class POSITION
        {
        /// <summary>
        /// 上料位置ID
        /// </summary>
        public string POSITIONNAME { get; set; }

        /// <summary>
        /// 树脂板批次号
        /// </summary>
        public string PEBOARDBATCHID { get; set; }

        /// <summary>
        /// 树脂板数量
        /// </summary>
        public string PEBOARDQUANTITY { get; set; }

    }
}
