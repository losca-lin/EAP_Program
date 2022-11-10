using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Getech.EAP.Entity.DBEntities.DBEntity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("V_CrystalstickDetail")]
    public class V_CrystalstickDetail : ORMEntity
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName= "Coding"   )]
         public string Coding { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName= "WorkShop")]
         public string WorkShop { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName= "D_Long")]
         public string D_Long { get; set; }
        

        
    }
}
