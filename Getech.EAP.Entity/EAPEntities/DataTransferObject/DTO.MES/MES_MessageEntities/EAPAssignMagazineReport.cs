using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.DTO.MES.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPAssignMagazineReport
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
        /// 树脂板批次号
        /// </summary>
        public string CONSUMABLENAME { get; set; }
        /// <summary>
        /// 弹匣ID
        /// </summary>
        public string MAGAZINEVID { get; set; }
    }
}
