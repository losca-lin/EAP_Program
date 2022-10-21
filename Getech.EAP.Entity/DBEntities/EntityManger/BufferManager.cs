using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System.Collections.Generic;

namespace Getech.EAP.DbService
{
    public class BufferManager : EntityManager
    {
        public EapBuffer findBufferByKey(string lineid, string machineid, string targetPort, string targetArea, string targetEqtGroup)
        {
            var result = db1.Queryable<EapBuffer>().Where(o => o.LineId == lineid && o.MachineId == machineid && o.TargetArea == targetArea && o.TargetPort == targetPort && o.TargetEqtGroup == targetEqtGroup).First();
            return result;
        }
        //add bu lc 20220803
        public EapBuffer ViewBufferByKey(string targetPort, string targetArea, string targetEqtGroup)
        {
            var result = db1.Queryable<EapBuffer>().Where(o => o.TargetArea == targetArea && o.TargetPort == targetPort && o.TargetEqtGroup == targetEqtGroup).First();
            return result;
        }
        public EapBuffer ViewBufferByBufferid(string lineid, string machineid, string bufferid)
        {
            var result = db1.Queryable<EapBuffer>().Where(o => o.LineId == lineid && o.MachineId == machineid && o.BufferId == bufferid).First();
            return result;
        }
        public List<EapBuffer> ViewBufferByLineidBufferid(string lineid)
        {
            var result = db1.Queryable<EapBuffer>().Where(o => o.LineId == lineid).ToList();
            return result;
        }
        //add by lc 20220803
        public EapBuffer FindBufferByBufferid( string bufferid)
        {
            var result = db1.Queryable<EapBuffer>().Where(o => o.BufferId == bufferid).First();
            return result;
        }
        //add by lc 20220805
        public EapBuffer FindBufferByLineBuffer(string lineid,string targetArea,string targetEqtGroup)
        {
            var result = db1.Queryable<EapBuffer>().Where(o => o.LineId == lineid && o.TargetArea==targetArea && o.TargetEqtGroup== targetEqtGroup).First();
            return result;
        }
        public EapBuffer ViewBufferByMachineid(string lineid, string machineid)
        {
            var result = db1.Queryable<EapBuffer>().Where(o => o.LineId == lineid && o.MachineId == machineid).First();
            return result;
        }

        public void saveBuffer(EapBuffer eapBuffer)
        {
            db1.Insertable(eapBuffer).ExecuteCommand();
        }

        public void updateBuffer(EapBuffer eapBuffer)
        {
            db1.Updateable(eapBuffer).ExecuteCommand();
        }

        public void deleteBuffer(EapBuffer eapBuffer)
        {
            db1.Deleteable(eapBuffer).ExecuteCommand();
        }
    }
}
