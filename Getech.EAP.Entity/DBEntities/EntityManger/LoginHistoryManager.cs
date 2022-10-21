using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System;
using System.Collections.Generic;

namespace Getech.EAP.DbService
{
    public class LoginHistoryManager : EntityManager
    {
        public List<EapLoginhistory> ViewEapLoginhistory(string lineID, string userId)
        {
            var result = db1.Queryable<EapLoginhistory>().Where(o => o.LineId == lineID && o.UserId == userId).ToList();
            return result;
        }
        public List<EapLoginhistory> ViewEapLoginhistorybyTime(string lineID, DateTime fromtime, DateTime totime)
        {
            var result = db1.Queryable<EapLoginhistory>().Where(o => o.LineId == lineID && o.LoginTime > fromtime & o.LoginTime < totime).ToList();
            return result;
        }
        public List<EapLoginhistory> ViewEapLoginhistorybyTimeAndId(string lineID, string userId, DateTime fromtime, DateTime totime)
        {
            var result = db1.Queryable<EapLoginhistory>().Where(o => o.LineId == lineID && o.UserId == userId && o.LoginTime > fromtime & o.LoginTime < totime).ToList();
            return result;
        }

        public List<EapLoginhistory> ViewEapLoginhistory(string userId)
        {
            var result = db1.Queryable<EapLoginhistory>().Where(o => o.UserId == userId).ToList();
            return result;
        }

        public List<EapLoginhistory> ViewEapLoginhistory()
        {
            var result = db1.Queryable<EapLoginhistory>().ToList();
            return result;
        }
        public void saveEntity(EapLoginhistory item)
        {
            item.UpdateTime = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            db1.Insertable(item).ExecuteCommand();
        }

    }
}
