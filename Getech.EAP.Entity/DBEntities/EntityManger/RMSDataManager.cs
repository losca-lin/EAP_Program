using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System.Collections.Generic;

namespace Getech.EAP.DbService
{
    public class RMSDataManager : EntityManager
    {
        public List<EapProfiledataspec> ViewRMSDataListByLineAndMachine(string lineId, string machineid,string datatype)
        {
            var result = db1.Queryable<EapProfiledataspec>().Where(o => o.LineId == lineId && o.DataType== datatype && o.MachineId == machineid).ToList();
            return result;
        }
        //add by zyl 20220630
        public EapProfiledataspec ViewRMSDataByDataname(string lineid, string machineid, string dataname)
        {
            var result = db1.Queryable<EapProfiledataspec>().Where(o => o.LineId == lineid && o.MachineId == machineid && o.DataName == dataname).First();
            return result;
        }
        public EapProfiledataspec ViewRMSDataByDatanameAndType(string lineid, string machineid, string dataname, string datatype)
        {
            var result = db1.Queryable<EapProfiledataspec>().Where(o => o.LineId == lineid && o.MachineId == machineid && o.DataName == dataname && o.DataType == datatype).First();
            return result;
        }
        public void saveRMSData(EapProfiledataspec rms)
        {
            db1.Insertable(rms).ExecuteCommand();
        }

        public void updateRMSData(EapProfiledataspec rms)
        {
            db1.Updateable(rms).ExecuteCommand();
        }

        public void deleteRMSData(EapProfiledataspec rms)
        {
            db1.Deleteable(rms).ExecuteCommand();
        }

    }
}
