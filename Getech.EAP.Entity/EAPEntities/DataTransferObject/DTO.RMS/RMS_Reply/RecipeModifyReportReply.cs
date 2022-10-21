using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.RMS_Reply
{
    [Serializable]
    [XmlRoot("BODY")]
    public class RecipeModifyReportReply
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string RecipeID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RecipeVersion { get; set; }

        [XmlArray("PARAMETERLISTLIST")]
        [XmlArrayItem("PARAMETERLIST")]
        public List<PARAMETERLIST> PARAMETERLISTLIST { get; set; }

    }
    public class PARAMETERLIST
    {
        /// <summary>
        /// 码垛PORT[1-20,21-24]
        /// </summary>
        public string PARAMETERNAME { get; set; }
        /// <summary>
        /// [Available，NotAvailable]
        /// </summary>
        public string Value { get; set; }

    }
}
