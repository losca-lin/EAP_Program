using Getech.EAP.DbService;

namespace Getech.EAP.Entity.DBEntities.EntityManger
{
    public class ObjectManager
    {
        public static AlarmHistoryManager AlarmHistoryManager { get; set; }
        public static DCRManager DCRManager { get; set; }
        public static JobManager JobManager { get; set; }
        public static LineManager LineManager { get; set; }
        public static LoginHistoryManager LoginHistoryManager { get; set; }
        public static MachineManager MachineManager { get; set; }
        public static MaterialConsumerManager MaterialConsumerManager { get; set; }
        public static MaterialManager MaterialManager { get; set; }
        public static MesProductManager MesProductManager { get; set; }
        public static UnitManager UnitManager { get; set; }
        public static UserManager UserManager { get; set; }

        public static XdTableManager XdTableManager { get; set; }

        public static EDCDataManager EDCDataManager { get; set; }
        public static FDCDataManager FDCDataManager { get; set; }

        public static BufferManager BufferManager { get; set; }

        public static PortManager PortManager { get; set; }

        public static UserGroupManager UserGroupManager { get; set; }

        public static V_LocalProductCryManager V_LocalProductCryManager { get; set; }
        public static V_CrystalstickDetailManager V_CrystalstickDetailManager { get; set; }
    }
}
