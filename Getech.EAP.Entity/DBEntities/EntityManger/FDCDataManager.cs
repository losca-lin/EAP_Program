﻿using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System.Collections.Generic;

namespace Getech.EAP.DbService
{
    public class FDCDataManager : EntityManager
    {
        //add by lc 20220524
        public List<EapProfiledataspec> ViewFDCDataListByLineAndMachine(string lineId, string machineid,string datatype)
        {
            var result = db1.Queryable<EapProfiledataspec>().Where(o => o.LineId == lineId && o.DataType== datatype && o.MachineId == machineid).ToList();
            return result;
        }
      
        public EapProfiledataspec ViewFDCDataByDataname(string lineid, string machineid, string dataname)
        {
            var result = db1.Queryable<EapProfiledataspec>().Where(o => o.LineId == lineid && o.MachineId == machineid && o.DataName == dataname).First();
            return result;
        }

        public EapProfiledataspec ViewFDCDataByDatanameAndType(string lineid, string machineid, string dataname, string datatype)
        {
            var result = db1.Queryable<EapProfiledataspec>().Where(o => o.LineId == lineid && o.MachineId == machineid && o.DataName == dataname && o.DataType == datatype).First();
            return result;
        }
        public void saveFDCData(EapProfiledataspec edc)
        {
            db1.Insertable(edc).ExecuteCommand();
        }

        public void updateFDCData(EapProfiledataspec edc)
        {
            db1.Updateable(edc).ExecuteCommand();
        }

        public void deleteFDCData(EapProfiledataspec edc)
        {
            db1.Deleteable(edc).ExecuteCommand();
        }

    }
}
