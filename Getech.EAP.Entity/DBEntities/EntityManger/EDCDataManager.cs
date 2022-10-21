using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System.Collections.Generic;

namespace Getech.EAP.DbService
{
    public class EDCDataManager : EntityManager
    {
        public List<EapProfiledataspec> ViewEDCDataListByLineAndMachine(string lineId, string machineid,string datatype)
        {
            var result = db1.Queryable<EapProfiledataspec>().Where(o => o.LineId == lineId && o.DataType== datatype && o.MachineId == machineid).ToList();
            return result;
        }
        //add by lc 20220519
        public EapProfiledataspec ViewEDCDataByDataname(string lineid, string machineid, string dataname)
        {
            var result = db1.Queryable<EapProfiledataspec>().Where(o => o.LineId == lineid && o.MachineId == machineid && o.DataName == dataname).First();
            return result;
        }
        public EapProfiledataspec ViewEDCDataByDatanameAndType(string lineid, string machineid, string dataname, string datatype)
        {
            var result = db1.Queryable<EapProfiledataspec>().Where(o => o.LineId == lineid && o.MachineId == machineid && o.DataName == dataname && o.DataType == datatype).First();
            return result;
        }
        public void saveEDCData(EapProfiledataspec edc)
        {
            db1.Insertable(edc).ExecuteCommand();
        }

        public void updateEDCData(EapProfiledataspec edc)
        {
            db1.Updateable(edc).ExecuteCommand();
        }

        public void deleteEDCData(EapProfiledataspec edc)
        {
            db1.Deleteable(edc).ExecuteCommand();
        }

    }
}
