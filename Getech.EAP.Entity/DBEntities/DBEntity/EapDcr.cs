using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Getech.EAP.Entity.DBEntities.DBEntity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("eap_dcr")]
    public class EapDcr : ORMEntity
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
         [SugarColumn(ColumnName="DcrNo" ,IsPrimaryKey = true   )]
         public string DcrNo { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="DcrName"    )]
         public string DcrName { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="UnitID"    )]
         public string UnitID { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ContextName"    )]
         public string ContextName { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="PausePosition"    )]
         public string PausePosition { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Description"    )]
         public string Description { get; set; }
    }
}
