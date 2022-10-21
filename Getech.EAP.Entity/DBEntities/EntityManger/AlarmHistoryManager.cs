using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System;
using System.Collections.Generic;

namespace Getech.EAP.DbService
{

    public class AlarmHistoryManager : EntityManager
    {
        //key LineID machineID UpdataTime
        public List<EapAlarmhistory> ViewAlarmHistory(string lineid, string machineId)
        {
            var result = db1.Queryable<EapAlarmhistory>().Where(o => o.LineId == lineid && o.MachineId == machineId).ToList();
            return result;
        }

        public List<EapAlarmspec> ViewAlarmspec(string lineid, string machineId)
        {
            var result = db1.Queryable<EapAlarmspec>().Where(o => o.LineId == lineid && o.MachineId == machineId).ToList();
            return result;
        }

        public List<EapAlarmhistory> ViewAlarmHistoryListByLineId(string lineId, string machineId)
        {
            var result = db1.Queryable<EapAlarmhistory>().Where(o => o.LineId == lineId && o.MachineId == machineId).ToList();
            return result;
        }

        public List<EapAlarmhistory> ViewAlarmHistoryListByTime(string lineId, string machineId, DateTime fromtime, DateTime totime)
        {
            var result = db1.Queryable<EapAlarmhistory>().Where(o => o.LineId == lineId && o.MachineId == machineId & o.HistoryTime > fromtime & o.HistoryTime < totime).ToList();
            return result;
        }
        public void SaveAlarmHistory(EapAlarmhistory eapLinehistory)
        {
            db1.Insertable(eapLinehistory).ExecuteCommand();
        }
        public void SaveAlarmHistoryList(List<EapAlarmhistory> eapLinehistorylist)
        {
            foreach (var alarmhistory in eapLinehistorylist)
            {
                db1.Insertable(alarmhistory).ExecuteCommand();
            }
        }
        public void SaveEntity(List<EapAlarmspec> eapalarmspeclist)
        {
            foreach (var eapalarmspec in eapalarmspeclist)
            {
                db1.Updateable(eapalarmspec).ExecuteCommand();
            }
        }
    }
}
