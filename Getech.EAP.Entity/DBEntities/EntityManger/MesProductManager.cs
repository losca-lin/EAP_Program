using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System.Collections.Generic;
using System.Linq;

namespace Getech.EAP.DbService
{
    public class MesProductManager : EntityManager
    {
        public EapMesproduct ViewMesProduct(string lineID, string serverID, string workJobId)
        {
            var result = db1.Queryable<EapMesproduct>().Where(o => o.LineId == lineID && o.WorkJobId == workJobId).ToList().FirstOrDefault();
            return result;
        }

        public List<EapMesproduct> ViewMesProductListByLineId(string lineId, string serverId)
        {
            var result = db1.Queryable<EapMesproduct>().Where(o => o.LineId == lineId).ToList();
            return result;
        }

        public void saveEapMesproduct(EapMesproduct eapMesproduct)
        {
            db1.Insertable(eapMesproduct).ExecuteCommand();
        }

        public void updateEapMesproduct(EapMesproduct eapMesproduct)
        {
            db1.Updateable(eapMesproduct).ExecuteCommand();
        }

        public void deleteEapMesproduct(EapMesproduct eapMesproduct)
        {
            db1.Deleteable(eapMesproduct).ExecuteCommand();
        }
    }
}
