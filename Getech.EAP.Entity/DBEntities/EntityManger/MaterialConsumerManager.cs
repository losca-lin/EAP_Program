using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System.Collections.Generic;
using System.Linq;

namespace Getech.EAP.DbService
{
    public class MaterialConsumerManager : EntityManager
    {
        public EapMaterialconsumer ViewMaterialConsumer(string lineID, string serverID, string machineId, string materialId)
        {
            var result = db1.Queryable<EapMaterialconsumer>().Where(o => o.LineId == lineID
            && o.MachineId == machineId && o.MaterialId == materialId).ToList().FirstOrDefault();
            return result;
        }

        public List<EapMaterialconsumer> ViewMaterialConsumerListByMachineId(string lineID, string serverID, string machineId)
        {
            var result = db1.Queryable<EapMaterialconsumer>().Where(o => o.LineId == lineID
            && o.MachineId == machineId).ToList();
            return result;
        }

        public void saveEapMaterialconsumer(EapMaterialconsumer materialConsumer)
        {
            db1.Insertable(materialConsumer).ExecuteCommand();
        }

        public void updateEapMaterialconsumer(EapMaterialconsumer materialConsumer)
        {
            db1.Updateable(materialConsumer).ExecuteCommand();
        }

        public void deleteEapMaterialconsumer(EapMaterialconsumer materialConsumer)
        {
            db1.Deleteable(materialConsumer).ExecuteCommand();
        }
    }
}
