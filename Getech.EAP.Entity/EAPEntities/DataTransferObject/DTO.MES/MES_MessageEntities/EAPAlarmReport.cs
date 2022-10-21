using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPAlarmReport
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string EQPID {get;set;}

        /// <summary>
        /// 设备Unit ID
        /// </summary>
        public string UNITID {get;set;}

        [XmlArray("ALARMLIST")]
        [XmlArrayItem("ALARM")]
        public List<ALARM> ALARMLIST { get; set; }

    }
    public class ALARM
    {
        /// <summary>
        /// 报警编号
        /// </summary>
        public string ALARMID { get; set; }

        /// <summary>
        /// 报警等级
        /// </summary>
        public string ALARMLEVEL { get; set; }

        /// <summary>
        /// 报警状态
        /// </summary>
        public string ALARMSTATE { get; set; }

        /// <summary>
        /// 报警内容
        /// </summary>
        public string ALARMTEXT { get; set; }
    }
}
