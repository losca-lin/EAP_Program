using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPXQCommonReasonCodeReport

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
        public string CUTSTARTYEAR {get;set;}

        /// <summary>
        /// 搬送物品的ID:比如晶棒ID
        /// </summary>
        public string CUTSTARTMONTH {get;set;}

        /// <summary>
        /// AGV动作:取料，放料
        /// </summary>
        public string CUTSTARTDAY {get;set;}

        /// <summary>
        /// AGV位置
        /// </summary>
        public string CUTSTARTHOUR {get;set;}
        public string CUTSTARTMINUTE { get; set; }
        public string CUTSTARTSECOND { get; set; }
        public string CUTENDYEAR { get; set; }
        public string CUTENDMONTH { get; set; }
        public string CUTENDDAY { get; set; }
        public string CUTENDHOUR { get; set; }
        public string CUTENDMINUTE { get; set; }
        public string CUTENDSECOND { get; set; }
        public string CURRENTRECIPEID { get; set; }
        public string BEFOREWIREQUANTITY { get; set; }
        public string LASTBEFOREWIREQUANTITY { get; set; }
        public string LASTPERIODMINIMUMQUANTITY { get; set; }

        [XmlArray("REASONCODELIST")]
        [XmlArrayItem("REASONCODE")]
        public List<REASONCODE> CODELIST { get; set; }
        public class REASONCODE
        {
            /// <summary>
            /// ProcessData Item名称
            /// </summary>
            /*public string INSPECT_TIME { get; set; }
			public string PRODUCT_NAME { get; set; }
			public string PRODUCTTYPE { get; set; }
			public string RECIPE_NAME { get; set; }*/
            public string REASONCODE1 { get; set; }
            public string ABNORMALVALUE1 { get; set; }
            public string REASONCODE2 { get; set; }
            public string ABNORMALVALUE2 { get; set; }
            public string REASONCODE3 { get; set; }
            public string ABNORMALVALUE3 { get; set; }
            public string REASONCODE4 { get; set; }
            public string ABNORMALVALUE4 { get; set; }

            /*[XmlArray("SITE_LIST")]
			[XmlArrayItem("SITE")]
			public List<Site> SITELIST { get; set; }*/

        }

    }
}
