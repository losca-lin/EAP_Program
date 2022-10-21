using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Getech.EAP.DbService
{
    public class MachineManager : EntityManager
    {
        //key : LineID MachineID ServerID
        public List<EapMachine> ViewMachineListbyLineId(string lineID)
        {
            var result = db1.Queryable<EapMachine>().Where(o => o.LineId == lineID).ToList();
            return result;
        }
        //public List<EapMachine> ViewMachineListbyServerId(string serverID)
        //{
        //    var result = db1.Queryable<EapMachine>().Where(o => o.ServerId == serverID).ToList();
        //    return result;
        //}
        //方法使用太频繁，后续改成缓存
        public EapMachine ViewMachine(string lineID, string machineID)
        {
            var result = db1.Queryable<EapMachine>().Where(o => o.LineId == lineID && o.MachineId == machineID).ToList().FirstOrDefault();
            return result;
        }

        public List<EapMachine> ViewMachinebyLineId(string lineID)
        {
            var result = db1.Queryable<EapMachine>().Where(o => o.LineId == lineID).ToList();
            return result;
        }

        public List<EapMachinehistory> ViewMachineHisotryListbyTime(DateTime fromtime, DateTime totime)
        {
            var result = db1.Queryable<EapMachinehistory>().Where(o => o.HistoryTime > fromtime & o.HistoryTime < totime).ToList();
            return result;
        }

        public List<EapMachinehistory> ViewMachineHisotryListbyLineId(string lineID)
        {
            var result = db1.Queryable<EapMachinehistory>().Where(o => o.LineId == lineID).ToList();
            return result;
        }

        public List<EapMachinehistory> ViewMachineHisotryListbyLineId(string lineID,string machineId)
        {
            var result = db1.Queryable<EapMachinehistory>().Where(o => o.LineId == lineID && o.MachineId == machineId).ToList();
            return result;
        }

        public List<EapMachinehistory> ViewMachineHisotryListbyTime(string lineID, DateTime fromtime, DateTime totime)
        {
            var result = db1.Queryable<EapMachinehistory>().Where(o => o.LineId == lineID && o.HistoryTime > fromtime & o.HistoryTime < totime).ToList();
            return result;
        }

        public List<EapMachinehistory> ViewMachineHisotryListbyMachineAndTime(string MachineId, DateTime fromtime, DateTime totime)
        {
            var result = db1.Queryable<EapMachinehistory>().Where(o => o.MachineId == MachineId && o.HistoryTime > fromtime & o.HistoryTime < totime).ToList();
            return result;
        }

        public EapMachine ViewMachine(string machineID)
        {
            var result = db1.Queryable<EapMachine>().Where(o => o.MachineId == machineID).ToList().FirstOrDefault();
            return result;
        }
        public void SaveEntityAndHistory(EapMachine machine, string eventName)
        {
            db1.Updateable(machine).ExecuteCommand();
            EapMachinehistory eapMachinehistory = new EapMachinehistory()
            {
                LineId = machine.LineId,
                MachineId = machine.MachineId,
                EventName = eventName,
                UpdateTime = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                MachineStatus = machine.MachineStatus,
                MachineType = machine.MachineType,
                MachineRunmode = machine.MachineRunmode,
                HistoryTime = DateTime.Now
            };
            db1.Insertable(eapMachinehistory).ExecuteCommand();
        }
        public void SaveEntityAndHistory(EapMachine machine, string eventName, string trxid)
        {
            db1.Updateable(machine).ExecuteCommand();
            EapMachinehistory eapMachinehistory = new EapMachinehistory()
            {
                LineId = machine.LineId,
                MachineId = machine.MachineId,
                EventName = eventName,
                UpdateTime= trxid,
                MachineStatus = machine.MachineStatus,
                MachineType = machine.MachineType,
                MachineRunmode = machine.MachineRunmode,
                HistoryTime = DateTime.Now
            };
            db1.Insertable(eapMachinehistory).ExecuteCommand();
        }
        public void updateMachine(EapMachine machine)
        {
            db1.Updateable(machine).ExecuteCommand();
        }

        public void deleteLine(EapMachine machine)
        {
            db1.Deleteable(machine).ExecuteCommand();
        }
    }
}
