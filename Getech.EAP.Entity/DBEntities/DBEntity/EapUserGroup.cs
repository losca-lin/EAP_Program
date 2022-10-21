using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.DBEntities.DBEntity
{
    [SugarTable("eap_userGroup")]
    public class EapUserGroup : ORMEntity
    {
        [SugarColumn(ColumnName = "GroupId", IsPrimaryKey = true)]
        public string GroupID { get; set; }


        [SugarColumn(ColumnName = "MainMenu", IsPrimaryKey = false)]
        public string MainMenu { get; set; }

        [SugarColumn(ColumnName = "SubMenu", IsPrimaryKey = false)]
        public string SubMenu { get; set; }

        [SugarColumn(ColumnName = "SubMenuENG", IsPrimaryKey = false)]
        public string SubMenuENG { get; set; }

        [SugarColumn(ColumnName = "IsMenuEnable", IsPrimaryKey = false)]
        public bool ismenuenable { get; set; }

    }
}
