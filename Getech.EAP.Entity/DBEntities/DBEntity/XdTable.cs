using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Getech.EAP.Entity.DBEntities.DBEntity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("xdtable")]
    public class XdTable : ORMEntity
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName= "id", IsPrimaryKey = true   )]
         public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName= "monocrystal")]
         public string Monocrystal { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName= "mmonocrystal")]
         public string Mmonocrystal { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName= "length")]
         public string Length { get; set; }
        /// <summary>
        ///  

    }
}
