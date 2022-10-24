using Getech.EAP.Entity.DBEntities.EntityManger;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workbench.Contract;
using Workbench.Contract.JsonMessage;
using Workbench.Contract.TCP;

namespace Getech.EAP.TCP.MessageHandler
{
    public class DW4_TCP_BCRReadRequestReply : AbstractTCPService
    {
        public override void Execute(ITCPContext context, JsonData data)
        {
            try
            {
                Dictionary<string, object> innerMap = new Dictionary<string, object>();
                JObject jobject = ConvertUtils.DeserializeObject<JObject>(data.Data.ToString());
                var contextname = context.Name;
                
                var ReadID = jobject.GetVal("ID").Trim();
                //var dcr= ObjectManager.DCRManager.FindDCRByDCR(contextname);
                //var machine = ObjectManager.MachineManager.ViewMachine(dcr.LineId, dcr.MachineId);
                messageService.BCRReadRequestReply1(contextname,"",ReadID);
               // opcMessageService.BCRReadRequestReply(contextname, ReadID);

            }
            catch (Exception ex)
            {
                log.LogErrorWrite("TCPMessageHandler", GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name + "()", ex);
            }
        }
    }
}
