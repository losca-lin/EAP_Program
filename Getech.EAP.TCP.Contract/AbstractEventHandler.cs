using System;
using Workbench.Contract;
using Workbench.Contract.JsonMessage;
using Workbench.Contract.TCP;

namespace Getech.EAP.TCP.Contract
{
    public abstract class AbstractEventHandler : ITCPEventHandler
    {
        protected static readonly ITCPCommandService tcpCmd = CommonContexts.ResolveInstance<ITCPCommandService>();

        public void Execute(ITCPContext context, JsonData data)
        {
            throw new NotImplementedException();
        }
    }
}
