using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPXQCuttingReasonCodeReport

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
        /// 任务ID
        /// </summary>
        public string LOTID {get;set;}

        /// <summary>
        /// 搬送类型
        /// </summary>
        public string CURRENTRECIPEID { get;set;}

        /// <summary>
        /// 搬送物品的ID:比如晶棒ID
        /// </summary>
        public string LEFTSPINDLEMOTORTEMPERATURE { get;set;}

        /// <summary>
        /// AGV动作:取料，放料
        /// </summary>
        public string RIGHTSPINDLEMOTORTEMPERATURE { get;set;}

        /// <summary>
        /// AGV位置
        /// </summary>
        public string CUTFLUIDLEVEL { get;set;}
        public string CUTFLUIDTEMPERATURE { get; set; }
        public string CUTFLUIDFLOW { get; set; }
        public string CUTFEEDPOSVALUE { get; set; }
        public string LEFTSPREADINGMOTORPOSVALUE { get; set; }
        public string RIGHTSPREADINGMOTORPOSVALUE { get; set; }
        public string RIGHTSPOOLWIRELENGTH { get; set; }
        public string SPINDLEMOTORWORKINGHOURS { get; set; }
        // add by lc 20220926 for xq切割深度
        public double ABNORMALCUTDEPTH { get; set; }

        [XmlArray("REASONCODELIST")]
        [XmlArrayItem("REASONCODE")]
        public List<REASONCODE> REASONCODELIST { get; set; }
        public class REASONCODE
        {
          
            public string REASONCODE1 { get; set; }
            public string ABNORMALVALUE1 { get; set; }
            public string REASONCODE2 { get; set; }
            public string ABNORMALVALUE2 { get; set; }
            public string REASONCODE3 { get; set; }
            public string ABNORMALVALUE3 { get; set; }
            public string REASONCODE4 { get; set; }
            public string ABNORMALVALUE4 { get; set; }

           

        }

    }
}
