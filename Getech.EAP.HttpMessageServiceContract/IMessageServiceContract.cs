

using Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities;
using Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_Reply;
using System.Collections.Generic;
using Workbench.Contract;
using Workbench.Contract.JsonMessage;
using TRANSPORTJOB = Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_Reply.TRANSPORTJOB;

namespace Getech.EAP.HttpMessageServiceContract
{
    public interface IMessageServiceContract:IAutoRegister
    {

        //EAP主动接收FLS消息
        void FLS_AGVActionReport(string eqpName, string timekey, Request message);

        void JXSBCRRequest(string eqpName, string timekey, Request message);

        void BCRReadRequestReply(string eqpName, string timekey, string readID);
        void BCRReadRequestReply1(string eqpName, string timekey, string readID);

        //EAP下达获取AGV搬送状态命令
        void AGVTransferStateCommand(string timekey, Dictionary<string, string> innerMap,List<TRANSPORTJOB> jobList);
        
    }
}