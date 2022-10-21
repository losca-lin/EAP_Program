using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System.Collections.Generic;

namespace Getech.EAP.DbService
{
    public class PortManager : EntityManager
    {

        public List<EapPort> FindPortListByLineID(string lineID)
        {
            var result = db1.Queryable<EapPort>().Where(o => o.LineId == lineID).ToList();
            return result;
        }

        public List<EapPort> FindPortListByMachineId(string machineId)
        {
            var result = db1.Queryable<EapPort>().Where(o => o.MachineId == machineId).ToList();
            return result;
        }

        public EapPort FindPortByLineIDAndPortNo(string lineID,string portNo)
        {
            var result = db1.Queryable<EapPort>().Where(o => o.LineId == lineID && o.PortNo == portNo).First();
            return result;
        }

        public List<EapPort> ViewPortlistByLineIDAndMachineID(string lineID, string machineid)
        {
            var result = db1.Queryable<EapPort>().Where(o => o.LineId == lineID && o.MachineId == machineid).ToList();
            return result;
        }

        public List<EapPort> ViewPortlistByMachineID(string machineid)
        {
            var result = db1.Queryable<EapPort>().Where(o =>o.MachineId == machineid).ToList();
            return result;
        }

        public List<EapPort> ViewPortlistByLineID(string lineID)
        {
            var result = db1.Queryable<EapPort>().Where(o => o.LineId == lineID).ToList();
            return result;
        }

        public void saveEntity(EapPort port)
        {
            db1.Updateable(port).ExecuteCommand();
        }

        public EapPort FindPortByLineIDAndPortId(string lineID, string portId)
        {
            var result = db1.Queryable<EapPort>().Where(o => o.LineId == lineID && o.PortId == portId).First();
            return result;
        }
        public void saveEapPort(EapPort eapPort)
        {
            db1.Insertable(eapPort).ExecuteCommand();
        }

        public void updateEapMesproduct(EapPort eapPort)
        {
            db1.Updateable(eapPort).ExecuteCommand();
        }

        public void deleteEapMesproduct(EapPort eapPort)
        {
            db1.Deleteable(eapPort).ExecuteCommand();
        }

    }
}
