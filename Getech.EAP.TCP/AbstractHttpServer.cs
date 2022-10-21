using Workbench.Contract;
using Workbench.Contract.Log;
using Workbench.Contract.TCP;
using Getech.EAP.TCP.Contract;
using Getech.EAP.HttpMessageServiceContract;

namespace Getech.EAP.TCP
{
    public abstract class AbstractHttpServer : IHttpEventHandler
    {
        protected static readonly ILogManager log = NLogManager.Logger;
        protected static readonly ITCPCommandService tcpCmdService = CommonContexts.ResolveInstance<ITCPCommandService>();
        protected static readonly IMessageServiceContract flsMessageService = CommonContexts.ResolveInstance<IMessageServiceContract>();
        public abstract void Execute(ITCPContext context, string data);
    }
}
