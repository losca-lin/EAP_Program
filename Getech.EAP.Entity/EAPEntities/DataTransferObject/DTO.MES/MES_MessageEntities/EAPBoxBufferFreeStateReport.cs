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
    //add by lb 220830
    public class EAPBoxBufferFreeStateReport
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
        /// [1-21;21为待检区]
        /// </summary>
        public string BUFFERID { get; set; }
        /// <summary>
        /// [1-3；1:下，2:中，3:上]
        /// </summary>
        public string BUFFERSLOT { get; set; }
        /// <summary>
        /// [FREE , LOCK]
        /// </summary>
        public string FREESTATE { get; set; }
    }
}
