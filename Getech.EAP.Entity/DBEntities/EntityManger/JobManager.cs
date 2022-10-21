using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Getech.EAP.DbService
{
    public class JobManager : EntityManager
    {
        public List<EapWorkjob> ViewJobListByLine(string lineId)
        {
            var result = db1.Queryable<EapWorkjob>().Where(o => o.LineId == lineId).ToList();
            return result;
        }
        public List<EapWorkjob> ViewJobListByMachineID(string machineid)
        {
            var result = db1.Queryable<EapWorkjob>().Where(o => o.CurrentMachineid == machineid).ToList();
            return result;
        }

        public List<EapJobhistory> ViewJobHistoryListByLineID(EapJobhistory item)
        {
            if (item.WorkJobId != null)
                return db1.Queryable<EapJobhistory>().Where(o => o.WorkJobId == item.WorkJobId && o.LineId == item.LineId).ToList();
            var result = db1.Queryable<EapJobhistory>().Where(o => o.LineId == item.LineId).ToList();
            return result;
        }

        public List<EapJobhistory> ViewJobHistoryListByLineIDAndTime(string lineId, DateTime formtime, DateTime totime)
        {
            var result = db1.Queryable<EapJobhistory>().Where(o => o.LineId == lineId & o.HistoryTime > formtime & o.HistoryTime < totime).ToList();
            return result;
        }

        public List<EapWorkjob> ViewJobInfoByCassetteSeqNo(string CarrierID)
        {
            var result = db1.Queryable<EapWorkjob>().Where(o => o.CarrierID == CarrierID).ToList();
            return result;
        }

        public EapWorkjob ViewJobByWorkJobId(string jobId)
        {
            var result = db1.Queryable<EapWorkjob>().Where(o => o.WorkJobId == jobId).ToList().FirstOrDefault();
            return result;
        }
        public EapWorkjob ViewJobByWorkJobId(string jobId, DateTime formtime, DateTime totime)
        {
            var result = db1.Queryable<EapWorkjob>().Where(o => o.WorkJobId == jobId).ToList().FirstOrDefault();
            return result;
        }

        public List<EapJobhistory> ViewJobByWorkJobIdAndTime(string jobId, DateTime formtime, DateTime totime)
        {
            var result = db1.Queryable<EapJobhistory>().Where(o => o.WorkJobId == jobId & o.HistoryTime > formtime & o.HistoryTime < totime).ToList();
            return result;
        }

        public List<EapJobhistory> ViewJobByEventName(string eventname)
        {
            var result = db1.Queryable<EapJobhistory>().Where(o => o.EventName == eventname).ToList();
            return result;
        }

        public List<EapJobhistory> ViewJobByEventNameAndTime(string eventname, DateTime formtime, DateTime totime)
        {
            var result = db1.Queryable<EapJobhistory>().Where(o => o.EventName == eventname & o.HistoryTime > formtime & o.HistoryTime < totime).ToList();
            return result;
        }

        public void SaveEntityAndHistory(EapWorkjob job, string eventName)
        {
            db1.Updateable(job).ExecuteCommand();
            EapJobhistory jobhistory = new EapJobhistory()
            {
                LineId = job.LineId,
                EventName = eventName,
                UpdateTime = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                WorkJobId = job.WorkJobId,
                //CurrentMachineId = job.CurrentMachineid,
                //CurrentUnitId = job.CurrentUnitid,
                DefectCode = job.DefectCode,
                //WorkJobGrade = job.WorkGrade,
                WorkStatus = job.WorkStatus,
                CimMode = job.CimMode,
                HoldFlag = job.HoldFlag,
                HoldReasonCode = job.HoldReasonCode,
                ProcessStartTime = job.ProcessStartTime,
                ProcessEndTime = job.ProcessEndTime,
                ProcessType = job.ProcessType,
                ProductId = job.ProductId,
                //ProductoringID = job.ProductSpecName,
                LotId = job.LotId,
                HistoryTime = DateTime.Now
            };

            db1.Insertable(jobhistory).ExecuteCommand();
        }


        public void updateJob(EapWorkjob job)
        {
            db1.Updateable(job).ExecuteCommand();
        }

        public void deleteJob(EapWorkjob job)
        {
            db1.Deleteable(job).ExecuteCommand();
        }

    }
}
