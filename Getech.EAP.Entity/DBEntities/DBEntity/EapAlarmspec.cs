using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Getech.EAP.Entity.DBEntities.DBEntity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("eap_alarmspec")]
    public class EapAlarmspec : ORMEntity
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
         [SugarColumn(ColumnName="Address" ,IsPrimaryKey = true   )]
         public string Address { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Position"    )]
         public string Position { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="AlarmLevel"    )]
         public string AlarmLevel { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="AlarmID"    )]
         public string AlarmID { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="AlarmText"    )]
         public string AlarmText { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Offset"    )]
         public string Offset { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "AlarmState")]
        public string AlarmState { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName="Description"    )]
         public string Description { get; set; }
    }
}
