using Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_Reply;
using Getech.EAP.Entity.TCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using Workbench.Contract;

namespace Getech.EAP.TCP.Contract
{
    public interface ITCPCommandService : IAutoRegister
    {
        void TCP_HttpReportReply(string contextName, string timeKey, JObject senddata);

        void TCP_BCRReadRequest(string contextname, string timekey, string senddata);
    }
}
