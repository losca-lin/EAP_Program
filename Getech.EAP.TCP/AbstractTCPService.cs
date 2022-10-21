using Workbench.Contract;
using Workbench.Contract.Log;
using Workbench.Contract.TCP;
using Workbench.Contract.JsonMessage;
using Getech.EAP.TCP.Contract;
using Getech.EAP.HttpMessageServiceContract;
using System.Threading;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace Getech.EAP.TCP
{
    public abstract class AbstractTCPService : ITCPEventHandler
    {
        protected static readonly ILogManager log = NLogManager.Logger;
        protected static readonly ITCPCommandService tcpCmdService = CommonContexts.ResolveInstance<ITCPCommandService>();
        protected static readonly IMessageServiceContract messageService = CommonContexts.ResolveInstance<IMessageServiceContract>();
        protected static readonly System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.Generic.Dictionary<string, object>> colIdDic = new ConcurrentDictionary<string, Dictionary<string, object>>();
        public abstract void Execute(ITCPContext context, JsonData data);

        public void putColIdDic(string key, Dictionary<string, object> innerMap)
        {
            colIdDic.TryAdd(key, innerMap);
        }

        public Dictionary<string, object> getColIdDic(string key)
        {
            Dictionary<string, object> innerMap = null;
            if (colIdDic.ContainsKey(key))
            {
                innerMap = colIdDic[key];
                colIdDic.TryRemove(key, out innerMap);

            }
            //log 提示为空
            return innerMap;
        }
    }
}
