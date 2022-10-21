using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Getech.EAP.Entity.DBEntities.DBEntity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("eap_linehistory")]
    public class EapLinehistory : ORMEntity
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="LineId" ,IsPrimaryKey = true   )]
         public string LineId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ServerId"    )]
         public string ServerId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="UpdateTime"    )]
         public string UpdateTime { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="LineType"    )]
         public string LineType { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="OnlineControlStatus"    )]
         public string OnlineControlStatus { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Description"    )]
         public string Description { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Factory"    )]
         public string Factory { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="HistoryTime" ,IsPrimaryKey = true   )]
         public DateTime HistoryTime { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="EventName"    )]
         public string EventName { get; set; }
    }
}
