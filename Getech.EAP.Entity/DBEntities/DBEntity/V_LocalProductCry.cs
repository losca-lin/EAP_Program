using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Getech.EAP.Entity.DBEntities.DBEntity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("V_LocalProductCry")]
    public class V_LocalProductCry : ORMEntity
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName= "Location", IsPrimaryKey = true   )]
         public string Location { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName= "DJKID")]
         public string DJKID { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName= "InData")]
         public string InData { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName= "TorrNuber")]
         public string TorrNuber { get; set; }

        [SugarColumn(ColumnName = "OutData")]
        public string OutData { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "Conductive")]
        public string Conductive { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "Torr")]
        public string Torr { get; set; }


        [SugarColumn(ColumnName = "F_Degree")]
        public string F_Degree { get; set; }

        [SugarColumn(ColumnName = "BarCode")]
        public string BarCode { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "Firm")]
        public string Firm { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "Coding")]
        public string Coding { get; set; }

        [SugarColumn(ColumnName = "WorkShop")]
        public string WorkShop { get; set; }

        [SugarColumn(ColumnName = "Size")]
        public string Size { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "R_Long")]
        public string R_Long { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "D_Long")]
        public string D_Long { get; set; }

        [SugarColumn(ColumnName = "Weight")]
        public string Weight { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "T_Weigh")]
        public string T_Weigh { get; set; }

        [SugarColumn(ColumnName = "CustomerProfile")]
        public string CustomerProfile { get; set; }

        [SugarColumn(ColumnName = "Remark")]
        public string Remark { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "B_Long")]
        public string B_Long { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "Inclined")]
        public string Inclined { get; set; }

        [SugarColumn(ColumnName = "J_Beige")]
        public string J_Beige { get; set; }

        [SugarColumn(ColumnName = "F_Beige")]
        public string F_Beige { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "Stria")]
        public string Stria { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "Scar")]
        public string Scar { get; set; }

        [SugarColumn(ColumnName = "SizeType")]
        public string SizeType { get; set; }

        [SugarColumn(ColumnName = "WagonNumber")]
        public string WagonNumber { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "P_Type")]
        public string P_Type { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "VerifyRemark")]
        public string VerifyRemark { get; set; }

        [SugarColumn(ColumnName = "Warehousing")]
        public string Warehousing { get; set; }

        [SugarColumn(ColumnName = "Scratch")]
        public string Scratch { get; set; }

        [SugarColumn(ColumnName = "NotGrind")]
        public string NotGrind { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "AbnornalSize")]
        public string AbnornalSize { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "D_Location")]
        public string D_Location { get; set; }

        [SugarColumn(ColumnName = "Passivation_T")]
        public string Passivation_T { get; set; }

        [SugarColumn(ColumnName = "Dopant")]
        public string Dopant { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "Flav")]
        public string Flav { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "LengthInStorage")]
        public string LengthInStorage { get; set; }

        [SugarColumn(ColumnName = "AbnormalLength")]
        public string AbnormalLength { get; set; }

        [SugarColumn(ColumnName = "AbnormalLengthTheory")]
        public string AbnormalLengthTheory { get; set; }

        [SugarColumn(ColumnName = "TotalLength")]
        public string TotalLength { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "TotalWeight")]
        public string TotalWeight { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "InType")]
        public string InType { get; set; }

        [SugarColumn(ColumnName = "IsSuperLot")]
        public string IsSuperLot { get; set; }
    }
}
