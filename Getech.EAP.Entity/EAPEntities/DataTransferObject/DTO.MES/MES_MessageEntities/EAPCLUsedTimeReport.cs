using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPCLUsedTimeReport

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
        /// 槽轮ID
        /// </summary>
        public string CLNAME {get;set;}

        /// <summary>
        /// 槽轮工时
        /// </summary>
        public string CLUSEDTIME {get;set;}
    }
}
