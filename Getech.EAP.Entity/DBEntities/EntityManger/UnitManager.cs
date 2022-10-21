using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System.Collections.Generic;
using System.Linq;

namespace Getech.EAP.DbService
{
    public class UnitManager : EAPDbContext
    {
        public EapUnit ViewUnit(string lineID, string serverID, string machineId, string unitId)
        {
            var result = db1.Queryable<EapUnit>().Where(o => o.LineId == lineID
            && o.MachineId == machineId && o.UnitId == unitId).ToList().FirstOrDefault();
            return result;
        }

        public List<EapUnit> ViewUnitListByMachineId(string lineID, string serverID, string machineId)
        {
            var result = db1.Queryable<EapUnit>().Where(o => o.LineId == lineID
            && o.MachineId == machineId).ToList();
            return result;
        }
        public List<EapUnit> ViewUnitListByLineId(string lineID)
        {
            var result = db1.Queryable<EapUnit>().Where(o => o.LineId == lineID).ToList();
            return result;
        }
        public void saveEapUnit(EapUnit eapUnit)
        {
            db1.Insertable(eapUnit).ExecuteCommand();
        }

        public void updateEapUnit(EapUnit eapUnit)
        {
            db1.Updateable(eapUnit).ExecuteCommand();
        }

        public void deleteEapUnit(EapUnit eapUnit)
        {
            db1.Deleteable(eapUnit).ExecuteCommand();
        }
    }
}
