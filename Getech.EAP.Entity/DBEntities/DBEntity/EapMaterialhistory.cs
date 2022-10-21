using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Getech.EAP.Entity.DBEntities.DBEntity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("eap_materialhistory")]
    public class EapMaterialhistory : ORMEntity
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="LineId" ,IsPrimaryKey = true   )]
         public string LineId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="MachineId" ,IsPrimaryKey = true   )]
         public string MachineId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="EventName"    )]
         public string EventName { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="UpdateTime" ,IsPrimaryKey = true   )]
         public string UpdateTime { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="MaterialName"    )]
         public string MaterialName { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="MaterialStatus"    )]
         public string MaterialStatus { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="MaterialType"    )]
         public string MaterialType { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="HistoryTime"    )]
         public DateTime? HistoryTime { get; set; }
    }
}
