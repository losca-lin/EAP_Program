using Getech.EAP.Entity;
using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Getech.EAP.DbService
{
    public class LineManager : EntityManager
    {
        //key : lineId ServerId
        private Dictionary<string, EapLine> lineData = new Dictionary<string, EapLine>();
        public void init()
        {
            var lineList = ViewLineList();
            if (lineList != null)
            {
                foreach (var line in lineList)
                {
                    lineData.Add(line.LineId, line);
                }
            }
        }

        public bool IsOffline(string lineId)
        {
            EapLine line = null;
            if (lineData.ContainsKey(lineId))
            {
                line = lineData[lineId];
                if (line.OnlineControlStatus == OnlineControlStatus.Local.ToString()
                    || line.OnlineControlStatus == OnlineControlStatus.Online.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public List<EapLine> ViewLineList()
        {
            var result = db1.Queryable<EapLine>().ToList();
            return result;
        }

        public List<EapLine> ViewLineList(string eapId)
        {
            var result = db1.Queryable<EapLine>().Where(o => o.EapId == eapId).ToList();
            return result;
        }

        public EapLine ViewLine(string lineID, string serverID)
        {
            var result = db1.Queryable<EapLine>().Where(o => o.ServerId == serverID && o.LineId == lineID).ToList().FirstOrDefault();
            return result;
        }

        public EapLine ViewLine(string lineID)
        {
            var result = db1.Queryable<EapLine>().Where(o => o.LineId == lineID).ToList().FirstOrDefault();
            return result;
        }

        public List<EapLinehistory> ViewLineHistorylist(string lineID)
        {
            var result = db1.Queryable<EapLinehistory>().Where(o => o.LineId == lineID).ToList();
            return result;
        }
        public List<EapLinehistory> ViewLinelistByTime(string lineID, DateTime fromtime, DateTime totime)
        {
            var result = db1.Queryable<EapLinehistory>().Where(o => (o.LineId == lineID) && o.HistoryTime > fromtime && o.HistoryTime < totime).ToList();
            return result;
        }

        public List<EapLine> ViewLineListByServerID(string serverId)
        {
            var result = db1.Queryable<EapLine>().Where(o => o.ServerId == serverId).ToList();
            return result;
        }
        public void SaveEntityAndHistory(EapLine line, string eventName, string userId)
        {
            db1.Updateable(line).ExecuteCommand();
            EapLinehistory eapLinehistory = new EapLinehistory()
            {
                ServerId = HostInfo.Current.EapId,
                LineId = line.LineId,
                UpdateTime = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                LineType = line.LineType,
                OnlineControlStatus = line.OnlineControlStatus,
                EventName = eventName,
                //use` = userId,
                HistoryTime = DateTime.Now
            };
            db1.Insertable(eapLinehistory).ExecuteCommand();
        }

        public void updateLine(EapLine line)
        {
            db1.Updateable(line).ExecuteCommand();
        }

        public void deleteLine(EapLine line)
        {
            db1.Deleteable(line).ExecuteCommand();
        }
    }
}
