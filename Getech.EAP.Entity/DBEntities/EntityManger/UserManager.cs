using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System.Collections.Generic;
using System.Linq;

namespace Getech.EAP.DbService
{
    public class UserManager : EntityManager
    {
        public EapUser ViewEapUser(string lineID, string serverID, string userId)
        {
            var result = db1.Queryable<EapUser>().Where(o => o.LineId == lineID && o.ServerId == serverID
            && o.UserId == userId).ToList().FirstOrDefault();
            return result;
        }

        public List<EapUser> VieweapUsers()
        {
            return db1.Queryable<EapUser>().ToList();
        }

        public EapUser ViewEapUser(string userId)
        {
            var result = db1.Queryable<EapUser>().Where(o =>o.UserId == userId).ToList().FirstOrDefault();
            return result;
        }

        public List<EapUser> ViewEapUserListByLineId(string lineId, string serverId)
        {
            var result = db1.Queryable<EapUser>().Where(o => o.LineId == lineId && o.ServerId == serverId).ToList();
            return result;
        }

        public int updateEapUser(EapUser item)
        {
           return db1.Updateable(item).ExecuteCommand();
        }

        public void saveEapUser(EapUser item)
        {
            db1.Insertable(item).ExecuteCommand();
        }

        public bool insertEapUser(EapUser item)
        {
            var lineCount = db1.Insertable(item).ExecuteCommand();
            return lineCount > 0 ? true : false;
        }

        public int deleteEapUser(EapUser item)
        {
            return db1.Deleteable(item).ExecuteCommand();
        }
    }
}
