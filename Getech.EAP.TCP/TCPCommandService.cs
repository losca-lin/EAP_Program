using Getech.EAP.Entity;
using Getech.EAP.Entity.EAPEntities.DataTransferObject.DTO.TCP.ZHString_Message;
using Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_Reply;
using Getech.EAP.Entity.TCP;
using Getech.EAP.TCP.Contract;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Workbench.Contract;
using Workbench.Contract.JsonMessage;
using Workbench.Contract.Log;
using Workbench.Contract.TCP;

namespace Getech.EAP.TCP
{
    public class TCPCommandService : AbstractEventHandler, ITCPCommandService
    {
        private static readonly ILogManager log = NLogManager.Logger;

        private ITCPContext context;
        public TCPCommandService()
        {
           // var line = (InlineTool)HostInfo.Current.InlineToolList.FirstOrDefault();
           // context = CommonContexts.GetTCPContextByName(line.LineID);
        }
        public ITCPContext TCPContext
        {
            get
            {
                if (context == null)
                {
                    throw new Exception("Cannot Find Context by Name Line3");
                }
                return context;
            }
        }

        private ITCPContext GetTCPContextByContextName(string contextname)
        {
            return CommonContexts.GetTCPContextByName(contextname);
        }
        public void TCP_HttpReportReply(string contextName, string timeKey, JObject senddata)
        {
            try
            {
                var tcpContext = GetTCPContextByContextName(contextName);
                tcpContext.Send(senddata);
                log.LogInfoWrite(GetType().Namespace, GetType().Name, MethodBase.GetCurrentMethod().Name + "()", "Send Data Excute OK");
            }
            catch (Exception ex)
            {
                log.LogErrorWrite(GetType().Namespace, GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex);
            }
        }


        public void TCP_BCRReadRequest(string contextname, string timekey, string senddata)
        {
            try
            {
                var tcpContext = GetTCPContextByContextName(contextname);
                StringBuilder stringCollection = new StringBuilder();
                stringCollection.Append(string.Format("==========================================\n", new object[0]));
                stringCollection.Append(string.Format("Message Name        : {0} \n", "TCP_BCRReadRequest"));
                stringCollection.Append(string.Format("Machine Name        : {0} \n", contextname + " ip:" + tcpContext.Configuration.Parameters["EapIpAddress"]
                    + ":" + tcpContext.Configuration.Parameters["Port"]));
                stringCollection.Append(string.Format("Transaction         : {0} \n", timekey));
                stringCollection.Append(string.Format("Message Type        : {0} \n", "TCPSend[EAP->EQP]"));
                stringCollection.Append(string.Format("Message             : \n{0} \n", senddata));
                tcpContext.Send_Single(stringCollection, senddata);
                log.LogInfoWrite(GetType().Namespace, GetType().Name, MethodBase.GetCurrentMethod().Name + "()", "Send Data Excute OK");
            }
            catch (Exception ex)
            {
                log.LogErrorWrite(GetType().Namespace, GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex);
            }
        }

    }
}
