using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Getech.EAP.Entity.DBEntities.DBEntity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("eap_machinehistory")]
    public class EapMachinehistory : ORMEntity
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="LineId")]
         public string LineId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="EventName"    )]
         public string EventName { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="MachineId"    )]
         public string MachineId { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "UpdateTime", IsPrimaryKey = true)]
        public string UpdateTime { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName="MachineType"    )]
         public string MachineType { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="CimMode"    )]
         public string CimMode { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="MachineStatus"    )]
         public string MachineStatus { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="MachineRunmode"    )]
         public string MachineRunmode { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="MachineOperationmode"    )]
         public string MachineOperationmode { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="CurrenRecipeID"    )]
         public string CurrenRecipeID { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ConnectionStatus"    )]
         public string ConnectionStatus { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ConnectionType"    )]
         public string ConnectionType { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="CarrierType"    )]
         public string CarrierType { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Description"    )]
         public string Description { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="HistoryTime" ,IsPrimaryKey = true   )]
         public DateTime HistoryTime { get; set; }
    }
}
