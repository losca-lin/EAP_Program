using Workbench.Contract.JsonMessage;
using System.Reflection;
using Workbench.Contract;
using System.Configuration;
using Newtonsoft.Json.Linq;
using Getech.EAP.HttpMessageServiceContract;
using System;
using System.Collections.Generic;
using Getech.EAP.Entity.DBEntities.EntityManger;
using Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities;
using RestSharp;
using Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_Reply;
using TRANSPORTJOB = Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities.TRANSPORTJOB;

namespace Getech.EAP.HttpMessageService
{
    public class MessageService: AbstractService, IMessageServiceContract
    {
        public void FLS_AGVActionReport(string eqpName, string timeKey, Request message)
        {
            try
            {
                var machine = ObjectManager.MachineManager.ViewMachine(eqpName);
                if (machine == null)
                {
                    log.LogErrorWrite("TCP_Driver", GetType().Name, MethodBase.GetCurrentMethod().Name, string.Format("Find Machine Error[{0}]:MachineID={1}", timeKey, machine.MachineId));
                    return;
                }
                var serverId = message.Body.GetVal("serverId");
               
                var taskId = message.Body.GetVal("taskId");
                //var commandResult = message.Body.GetVal("commandResult");
                //var AbnormalReason = message.Body.GetVal("AbnormalReason");
                var agvPosition = message.Body.GetVal("agvPosition");//agv 小车id
                var agvAction = message.Body.GetVal("agvAction");//agv任务状态开始/结束/取消
                var agvTaskId = message.Body.GetVal("agvTaskId");//agv自己任务号
                var goodsType = message.Body.GetVal("goodsType");
                var goodsID = message.Body.GetVal("goodsID");
                var agvId = message.Body.GetVal("agvId");//agv 小车id
                var msgName = message.Body.GetVal("msgName");
                var transactionId = message.Body.GetVal("transactionId");
                log.LogInfoWrite("TCP_Driver", GetType().Name, MethodBase.GetCurrentMethod().Name, string.Format("MessageName :{0},TimeKey :{1},TaskID:{2},agvAction:{3},agvPosition:{4}，agvId:{5}，agvTaskId:{6}", msgName, timeKey, taskId, agvAction, agvPosition,agvId, agvTaskId));


                var eapreply = new JObject();
                eapreply.Add("serverId", serverId);
                eapreply.Add("msgName", msgName);
                eapreply.Add("returnCode", "OK");
                eapreply.Add("returnMsg ", "0000000");
                eapreply.Add("transactionId ", transactionId);
                //tcpCommandService.TCP_FLS_AGVActionReportReply("FLS-01", timeKey, eapreply);
            }
            catch (Exception ex)
            {
                log.LogErrorWrite("TCP_Driver", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex.ToString());
            }
        }

        public void JXSBCRRequest(string eqpName, string timeKey, Request message)
        {
            try
            {
                var portId = message.Body.GetVal("port").ToString().Trim();
                string name = "DCR0" + portId;

                Dictionary<string, object> innerMap = new Dictionary<string, object>();
                innerMap.Add("port", portId);
                innerMap.Add("timeKey", timeKey);
                putColIdDic(name, innerMap);

                tcpCommandService.TCP_BCRReadRequest(name, timeKey,"SA");


            }
            catch (Exception ex)
            {
                log.LogErrorWrite("TCP_Driver", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex.ToString());
            }
        }


        public void BCRReadRequestReply(string eqpName, string timeKey, string readID)
        {
            try
            {
                //var machine = ObjectManager.MachineManager.ViewMachine(eqpName);
               // if (machine == null)
               // {
                //    log.LogErrorWrite("TCP_Driver", GetType().Name, MethodBase.GetCurrentMethod().Name, string.Format("Find Machine Error[{0}]:MachineID={1}", timeKey, machine.MachineId));
                //     return;
                // }

                Dictionary<string, object> innerMap = getColIdDic(eqpName);
                string port = innerMap["port"].ToString();
                timeKey = innerMap["timeKey"].ToString();
                // 取数据库数据，readid为单晶ID，处理数据逻辑后返回到中为机械手
                //....
                //....
                string code = "ok";
                string message = "success";
                int status = 1;
                if (readID == "NoRead")
                {
                    code = "NG";
                    message = "单晶id未读取";
                }

                var eapreply = new JObject();
                eapreply.Add("port", port);
                eapreply.Add("code", code);
                eapreply.Add("message", message);
                eapreply.Add("status", status);
                tcpCommandService.TCP_HttpReportReply("KQX-JXS-01", timeKey, eapreply);
            }
            catch (Exception ex)
            {
                log.LogErrorWrite("TCP_Driver", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex.ToString());
            }
        }

        



        public void AGVTransferStateCommand( string timeKey, Dictionary<string, string> innerMap, List<Entity.EAPEntities.DataTransferObject.MES_Reply.TRANSPORTJOB> jobList)
        {
            try
            {
                Request reqest = new Request();
                reqest.Header = new Header();
                //reqest.Header.TransactionID = timeKey;
                //reqest.Header.MachineName = eqpName;
                //reqest.Header.MessageName = "AGVCommandDownload";
                if (innerMap.Count > 0)
                {
                    foreach (var key in innerMap.Keys)
                    {
                        reqest.Body.Add(key, innerMap[key]);
                    }
                    reqest.Body.Add("transactionId", timeKey);
                    //reqest.Body.Add("MachineName", eqpName);
                    reqest.Body.Add("msgName", "AGVTransferStateCommand");
                }
                //将List加入JSON
                reqest.Body = ConvertUtils.AddList(reqest.Body, "taskIdList", jobList);
                var apiClient = new APIClient(ConfigurationManager.AppSettings["FlsUrl"]);
                //var req = new RestRequest("/route/to/demo", Method.POST);
                var req = new RestRequest("", Method.POST);
                req.RequestFormat = DataFormat.Json;
                string rmj = ConvertUtils.Serialization(reqest.Body);
                req.AddJsonBody(rmj);
                log.LogInfoWrite("TCP_Driver", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", rmj.ToString());
                var result = apiClient.Client.Execute(req);
                //Reuqest执行后的Response内容
                if (result.Content != "")
                {
                    JObject jobject = null;
                    jobject = ConvertUtils.DeserializeObject<JObject>(result.Content);
                    var messageName = jobject.GetVal("msgName");
                    var returnCode = jobject.GetVal("returnCode");
                    var taskIdList = jobject.GetList("taskIdList");
                    var joblist = new List<TRANSPORTJOB>();
                    //var taskState = jobject.GetVal("taskState ");
                    if (messageName == "AGVTransferStateCommand")
                    {
                        
                        foreach (var tasklist in taskIdList) {
                            var remp = (JObject)tasklist;
                            TRANSPORTJOB tRANSPORTJOB = new TRANSPORTJOB();
                            tRANSPORTJOB.TRANSPORTJOBNAME = remp.GetVal("TRANSPORTJOBNAME");
                            tRANSPORTJOB.TRANSPORTJOBSTATE= remp.GetVal("TRANSPORTJOBSTATE");
                            joblist.Add(tRANSPORTJOB);
                        }
                        var mesGetAGVTransportJobStateReply = new MESGetAGVTransportJobStateReply();
                        mesGetAGVTransportJobStateReply.TRANSPORTJOBLIST = joblist;
                    }
                    reqest = null;
                    rmj = "";
                    req = null;
                    log.LogInfoWrite("TCP_Driver", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", string.Format("WebMessageResponse:{0}", result.Content));
                    return;
                }
                else
                {
                    reqest = null;
                    rmj = "";
                    req = null;
                    log.LogInfoWrite("TCP_Driver", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", "WebMessageSendOK!");
                    return;
                }
            }
            catch (Exception ex)
            {
                log.LogErrorWrite("TCP_Driver", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex.ToString());
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
        }

    }
}
