using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Getech.EAP.Entity.DBEntities.DBEntity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("eap_loginhistory")]
    public class EapLoginhistory : ORMEntity
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="LineId") ]
         public string LineId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="UpdateTime" ,IsPrimaryKey = true   )]
         public string UpdateTime { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="UserName"    )]
         public string UserName { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="UserId" ,IsPrimaryKey = true   )]
         public string UserId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="LoginWindow"    )]
         public string LoginWindow { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="LoginTime"    )]
         public DateTime LoginTime { get; set; }

        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "HistoryTime")]
        public DateTime HistoryTime { get; set; }
    }
}
