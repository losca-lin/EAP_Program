using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Workbench.Contract;
using Workbench.Contract.JsonMessage;
using Workbench.Contract.TCP;

namespace Getech.EAP.TCP.MessageHandler
{
    public class DW4_TCP_HttpServerMessageReport: AbstractHttpServer

    {
        public override void Execute(ITCPContext context, string data)
        {
            try
            {
                if (!data.Contains("{"))
                {
                    log.LogErrorWrite("TCPMessageHandler", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", "HttpServerReceiveDataError");
                    return;
                }
                var body = "{"+data.Split('{')[1];
                JObject jobject = ConvertUtils.DeserializeObject<JObject>(body);
                string machineName = context.Name;
                string timeKey = CreateTimekey();
                Request rq = new Request
                {
                    Body = jobject
                };
                var messagename = "JXSBCRRequest";//jobject.GetVal("msgName");
                switch (messagename)
                {
                    case "JXSBCRRequest":
                        flsMessageService.JXSBCRRequest(machineName, timeKey, rq);
                        break;
                }
            }
            catch (Exception ex)
            {
                log.LogErrorWrite("TCPMessageHandler", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex);
            }
        }

        private string CreateTimekey()
        {
            var timekey = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            Random random = new Random(Guid.NewGuid().GetHashCode());
            timekey = string.Concat(timekey, random.Next(1000, 9999).ToString());
            return timekey;
        }
    }
}
