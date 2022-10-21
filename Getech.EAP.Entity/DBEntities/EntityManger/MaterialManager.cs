using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Getech.EAP.DbService
{
    public class MaterialManager : EntityManager
    {
        public List<EapMaterial> ViewMaterialListByLineId(string lineID)
        {
            var result = db1.Queryable<EapMaterial>().Where(o => o.LineId == lineID).ToList();
            return result;
        }

        public EapMaterial ViewMaterial(string lineID, string serverID, string machineId, string materialId)
        {
            var result = db1.Queryable<EapMaterial>().Where(o => o.LineId == lineID
            && o.MachineId == machineId && o.MaterialId == materialId).ToList().FirstOrDefault();
            return result;
        }

        public List<EapMaterial> ViewMaterialListByMachine(string lineID, string serverID, string machineId)
        {
            var result = db1.Queryable<EapMaterial>().Where(o => o.LineId == lineID
            && o.MachineId == machineId).ToList();
            return result;
        }

        public List<EapMaterialhistory> ViewMaterialHistroyListBylineId(string lineID)
        {
            var result = db1.Queryable<EapMaterialhistory>().Where(o => o.LineId == lineID).ToList();
            return result;
        }

        public List<EapMaterialhistory> ViewMaterialHistroyList(EapMaterialhistory materialhistory)
        {
            if(materialhistory.MaterialName != null)
                return db1.Queryable<EapMaterialhistory>().Where(o => o.LineId == materialhistory.LineId && o.MaterialName == materialhistory.MaterialName).ToList();
            var result = db1.Queryable<EapMaterialhistory>().Where(o => o.LineId == materialhistory.LineId).ToList();
            return result;
        }

        public void SaveEntityAndHistory(EapMaterial material, string eventName)
        {
            db1.Updateable(material).ExecuteCommand();
            EapMaterialhistory eapMaterialhistory = new EapMaterialhistory()
            {
                LineId = material.LineId,
                MachineId = material.MachineId,
                EventName = eventName,
                UpdateTime = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                MaterialName = material.MaterialId,
                MaterialStatus = material.MaterialStatus,
                MaterialType = material.MaterialType,
                HistoryTime = DateTime.Now
            };
            db1.Insertable(eapMaterialhistory).ExecuteCommand();
        }

        public void saveEapMaterial(EapMaterial eapMaterial)
        {
            db1.Insertable(eapMaterial).ExecuteCommand();
        }

        public void updateEapMaterial(EapMaterial eapMaterial)
        {
            db1.Updateable(eapMaterial).ExecuteCommand();
        }

        public void deleteEapMaterial(EapMaterial eapMaterial)
        {
            db1.Deleteable(eapMaterial).ExecuteCommand();
        }
        public List<EapMaterialhistory> ViewMaterialHistoryListByLineIDAndTime(string lineId, DateTime formtime, DateTime totime)
        {
            var result = db1.Queryable<EapMaterialhistory>().Where(o => o.LineId == lineId & o.HistoryTime > formtime & o.HistoryTime < totime).ToList();
            return result;
        }
    }
}
