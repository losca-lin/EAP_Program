using Getech.EAP.HttpMessageServiceContract;
using Getech.EAP.TCP.Contract;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workbench.Contract;
using Workbench.Contract.Log;

namespace Getech.EAP.HttpMessageService
{
    public abstract class AbstractService
    {
        protected static readonly ILogManager log = NLogManager.Logger;
        protected static readonly IMessageServiceContract fLSMessageService = CommonContexts.ResolveInstance<IMessageServiceContract>();

        protected static readonly ITCPCommandService tcpCommandService = CommonContexts.ResolveInstance<ITCPCommandService>();
        protected static readonly System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.Generic.Dictionary<string, object>> colIdDic = new ConcurrentDictionary<string, Dictionary<string, object>>();

        public void putColIdDic(string key, Dictionary<string, object> innerMap)
        {
            colIdDic.TryAdd(key, innerMap);
        }

        public Dictionary<string, object> getColIdDicDel(string key)
        {
            Dictionary<string, object> innerMap = null;
            if (colIdDic.ContainsKey(key))
            {
                innerMap = colIdDic[key];
                colIdDic.TryRemove(key, out innerMap);

            }
            return innerMap;
        }

    

        public Dictionary<string, object> getColIdDic(string key)
        {
            Dictionary<string, object> innerMap = null;
            if (colIdDic.ContainsKey(key))
            {
                innerMap = colIdDic[key];

            }
            return innerMap;
        }


    }
}
