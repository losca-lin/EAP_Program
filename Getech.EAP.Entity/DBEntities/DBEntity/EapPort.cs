using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Getech.EAP.Entity.DBEntities.DBEntity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("eap_port")]
    public class EapPort : ORMEntity
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
         [SugarColumn(ColumnName="PortId" ,IsPrimaryKey = true   )]
         public string PortId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="PortType"    )]
         public string PortType { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="PortStatus"    )]
         public string PortStatus { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="PortNo"    )]
         public string PortNo { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ChangeNo"    )]
         public string ChangeNo { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Description"    )]
         public string Description { get; set; }
    }
}
