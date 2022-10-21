using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Getech.EAP.Entity.DBEntities.DBEntity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("eap_profiledataspec")]
    public class EapProfiledataspec : ORMEntity
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
         [SugarColumn(ColumnName="DataName" ,IsPrimaryKey = true   )]
         public string DataName { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="DataType" ,IsPrimaryKey = true   )]
         public string DataType { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="dataNo"    )]
         public int DataNo { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="reportTo"    )]
         public string ReportTo { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="updateTime"    )]
         public DateTime? UpdateTime { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="valueOperand"    )]
         public int ValueOperand { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="valueOperator"    )]
         public string ValueOperator { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="parameterValue"    )]
         public string ParameterValue { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="valueType"    )]
         public string ValueType { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="woffset"    )]
         public string Woffset { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="wpoints"    )]
         public string Wpoints { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="boffset"    )]
         public string Boffset { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="bpoints"    )]
         public string Bpoints { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Description"    )]
         public string Description { get; set; }
    }
}
