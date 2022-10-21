using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Getech.EAP.Entity.DBEntities.DBEntity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("eap_jobhistory")]
    public class EapJobhistory : ORMEntity
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="LineId" ,IsPrimaryKey = true   )]
         public string LineId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="EventName"    )]
         public string EventName { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="UpdateTime"    )]
         public string UpdateTime { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="WorkJobId" ,IsPrimaryKey = true   )]
         public string WorkJobId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="CreateTime"    )]
         public string CreateTime { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="HistoryTime" ,IsPrimaryKey = true   )]
         public DateTime HistoryTime { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="CurrentMachineid"    )]
         public string CurrentMachineid { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="CurrentUnitid"    )]
         public string CurrentUnitid { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="DefectCode"    )]
         public string DefectCode { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="WorkGrade"    )]
         public string WorkGrade { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="WorkStatus"    )]
         public string WorkStatus { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="CimMode"    )]
         public string CimMode { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="HoldFlag"    )]
         public int? HoldFlag { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="HoldReasonCode"    )]
         public string HoldReasonCode { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ProcessEndTime"    )]
         public string ProcessEndTime { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ProcessStartTime"    )]
         public string ProcessStartTime { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ProcessType"    )]
         public string ProcessType { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ProductId"    )]
         public int? ProductId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ProductSpecName"    )]
         public string ProductSpecName { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="LotId"    )]
         public string LotId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="CarrierID"    )]
         public string CarrierID { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="CurrentPosition"    )]
         public string CurrentPosition { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Description"    )]
         public string Description { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ProcessResult"    )]
         public string ProcessResult { get; set; }
    }
}
