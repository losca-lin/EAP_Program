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
    //add by lb 220831
    public class EAPFullTankPositionReport
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
        /// 水箱ID
        /// </summary>
        public string TANKID { get; set; }
        /// <summary>
        /// 当前位置
        /// </summary>
        public string PAUSEPOSITION { get; set; }
    }
}
