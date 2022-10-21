using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Getech.EAP.Entity.DBEntities.DBEntity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("eap_alarmhistory")]
    public class EapAlarmhistory: ORMEntity
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
         [SugarColumn(ColumnName="AlarmId"    )]
         public string AlarmId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="AlarmState"    )]
         public string AlarmState { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="AlarmLevel"    )]
         public string AlarmLevel { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="AlarmText"    )]
         public string AlarmText { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="AlarmCode"    )]
         public string AlarmCode { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="AlarmUnit"    )]
         public int? AlarmUnit { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="HistoryTime"    )]
         public DateTime? HistoryTime { get; set; }
    }
}
