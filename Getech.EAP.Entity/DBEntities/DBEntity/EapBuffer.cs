using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Getech.EAP.Entity.DBEntities.DBEntity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("eap_buffer")]
    public class EapBuffer : ORMEntity
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
         [SugarColumn(ColumnName="BufferId" ,IsPrimaryKey = true   )]
         public string BufferId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="BufferType"    )]
         public string BufferType { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="BufferStatus"    )]
         public string BufferStatus { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="BufferNo"    )]
         public string BufferNo { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="TargetPort"    )]
         public string TargetPort { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="TargetArea"    )]
         public string TargetArea { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="TargetEqtGroup"    )]
         public string TargetEqtGroup { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Description"    )]
         public string Description { get; set; }
    }
}
