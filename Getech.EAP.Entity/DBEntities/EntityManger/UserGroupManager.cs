
using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System;
using System.Collections.Generic;

namespace Getech.EAP.DbService
{

    public class UserGroupManager : EntityManager
    {
        //key LineID machineID UpdataTime
        public List<EapUserGroup> ClientViewEapUserGroupByGroupID(EapUserGroup item)
        {
            return db1.Queryable<EapUserGroup>().Where(o => o.GroupID == item.GroupID).ToList();
        }

        public List<EapUserGroup> ClientViewEapUserGroupDistinctGroupID()
        {
            var sql = "select * from eap_usergroup group by groupid";
            return db1.SqlQueryable<EapUserGroup>(sql).ToList();
        }

        public int ClientUpdateEapUserGroup(EapUserGroup item)
        {
            return db1.Updateable(item).ExecuteCommand();
        }

        public bool ClientInsertEapUserGroup(EapUserGroup item)
        {
            var lineCount = db1.Insertable(item).ExecuteCommand();
            return lineCount > 0 ? true : false;
        }

        public int ClientDeleteEapUserGroup(EapUserGroup item)
        {
            return db1.Deleteable(item).ExecuteCommand();
        }


    }
}
