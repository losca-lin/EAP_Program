using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System.Collections.Generic;

namespace Getech.EAP.DbService
{
    public class V_LocalProductCryManager : EntityManager
    {

        public V_LocalProductCry ViewVLocalProductCryListByCode(string Coding)
        {
            var result = db1.Queryable<V_LocalProductCry>().Where(o => o.Coding == Coding).First();
            return result;
        }


        public List<EapDcr> ViewDCRListByMahicneID(string mahcineid)
        {
            var result = db1.Queryable<EapDcr>().Where(o => o.MachineId == mahcineid).ToList();
            return result;
        }

        public List<EapDcr> ViewDCRListByMachineId(string lineID, string machineId)
        {
            var result = db1.Queryable<EapDcr>().Where(o => o.LineId == lineID && o.MachineId == machineId).ToList();
            return result;
        }

        public EapDcr FindDCRByMachineIdAndPausePosition(string lineID, string machineId, string pausePosition)
        {
            var result = db1.Queryable<EapDcr>().Where(o => o.LineId == lineID && o.MachineId == machineId && o.PausePosition == pausePosition).First();
            return result;
        }
        //add by lc 20220919 
        public EapDcr FindDCRByMachineAndPosition(string machineId, string pausePosition)
        {
            var result = db1.Queryable<EapDcr>().Where(o => o.MachineId == machineId && o.PausePosition == pausePosition).First();
            return result;
        }

        public EapDcr FindDCRByDCR(string dcrName)
        {
            var result = db1.Queryable<EapDcr>().Where(o => o.ContextName == dcrName).First();
            return result;
        }

        public EapDcr FindDCRByPausePosition(string lineID, string pausePosition)
        {
            var result = db1.Queryable<EapDcr>().Where(o => o.LineId == lineID && o.PausePosition == pausePosition).First();
            return result;
        }

        public EapDcr ViewDCRByDcrNo(string lineID, string serverID, string machineID, string dcrNo)
        {
            var result = db1.Queryable<EapDcr>().Where(o => o.LineId == lineID && o.MachineId == machineID && o.DcrNo == dcrNo).First();
            return result;
        }

        public EapDcr ViewDCRByContextname(string contextname)
        {
            var result = db1.Queryable<EapDcr>().Where(o => o.ContextName == contextname).First();
            return result;
        }

        public void saveDCR(EapDcr dcr)
        {
            db1.Insertable(dcr).ExecuteCommand();
        }

        public void updateDcr(EapDcr dcr)
        {
            db1.Updateable(dcr).ExecuteCommand();
        }

        public void deleteDcr(EapDcr dcr)
        {
            db1.Deleteable(dcr).ExecuteCommand();
        }
    }
}
