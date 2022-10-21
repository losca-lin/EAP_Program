using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPEquipmentInfoReport
    {
        /// <summary>
        /// EAP ID
        /// </summary>
        public string EAPID {get;set; }
        /// <summary>
        /// 控制模式[Online，Offline]
        /// </summary>
        public string CONTROLMODE { get; set; }

        [XmlArray("EQPINFOLIST")] 
        [XmlArrayItem("EQP")] 
        public List<EQP>EQPINFOLIST { get; set; } 

    }
    public class EQP
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string EQPID {get;set; }
        /// <summary>
        /// 设备状态[Run,Idle,Stop,Down]
        /// </summary>
        public string EQPSTATE { get; set; }
        /// <summary>
        /// 警报状态
        /// </summary>
        public string ALARMSTATE { get; set; }
        [XmlArray("UNITINFOLIST")] 
        [XmlArrayItem("UNIT")] 
        public List<UNIT>UNITINFOLIST { get; set; } 
        [XmlArray("PORTLIST")] 
        [XmlArrayItem("PORT")] 
        public List<PORT>PORTLIST { get; set; } 
    }
    public class UNIT
    {
        /// <summary>
        /// 子设备ID
        /// </summary>
        public string UNITID {get;set;}

        /// <summary>
        /// 子设备状态
        /// </summary>
        public string UNITSTATE {get;set; }
        /// <summary>
        /// 设备操作状态[Manual,Auto]
        /// </summary>
        public string OPERATIONMODE { get; set; }
        /// <summary>
        /// 配方ID
        /// </summary>
        public string RECIPEID { get; set; }

    }
    public class PORT
    {
        /// <summary>
        /// 端口ID
        /// </summary>
        public string PORTID {get;set;}

        /// <summary>
        /// 端口状态
        /// </summary>
        public string PORTSTATE {get;set;}

    }
}
