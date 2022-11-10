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
using Getech.EAP.Entity.DBEntities.DBEntity;
using System.Collections;
using Workbench.Contract.RV;
using System.Xml.Linq;
using System.Linq;

namespace Getech.EAP.HttpMessageService
{
    public class MessageService : AbstractService, IMessageServiceContract
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
                log.LogInfoWrite("TCP_Driver", GetType().Name, MethodBase.GetCurrentMethod().Name, string.Format("MessageName :{0},TimeKey :{1},TaskID:{2},agvAction:{3},agvPosition:{4}，agvId:{5}，agvTaskId:{6}", msgName, timeKey, taskId, agvAction, agvPosition, agvId, agvTaskId));


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
                string portId = message.Body.GetVal("port").ToString().Trim();

                string name = "DCR0" + portId;
                string name_1 = "DCR0" + portId + "_1";
                #region mark
                //switch (portId)
                //{
                //    case "1":
                //        name1 = "DCR01";
                //        name2 = "DCR01_1";
                //        handlerTCP_BCRReadRequest(name1, name2, timeKey, portId);
                //        break;
                //    case "2":
                //        name1 = "DCR02";
                //        name2 = "DCR02_1";
                //        handlerTCP_BCRReadRequest(name1, name2, timeKey, portId);
                //        break;
                //    case "3":
                //         name1 = "DCR03";
                //         name2 = "DCR03_1";
                //        handlerTCP_BCRReadRequest(name1,name2,timeKey,portId);
                //        break;
                //    case "4":
                //        name1 = "DCR04";
                //        name2 = "DCR04_1";
                //        handlerTCP_BCRReadRequest(name1, name2, timeKey, portId);
                //        break;
                //    case "5":
                //        name1 = "DCR05";
                //        name2 = "DCR05_1";
                //        handlerTCP_BCRReadRequest(name1, name2, timeKey, portId);
                //        break;
                //    default:
                //        break;
                //}
                #endregion

                handlerTCP_BCRReadRequest(name, name_1, timeKey, portId);


                //tcpCommandService.TCP_BCRReadRequest(name, timeKey,"SA");


            }
            catch (Exception ex)
            {
                log.LogErrorWrite("TCP_Driver", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex.ToString());
            }
        }
        Dictionary<string, string> innerMap1 = new Dictionary<string, string>();
        Dictionary<string, string> innerMap2 = new Dictionary<string, string>();
        public void BCRReadRequestReply1_old(string eqpName, string timeKey, string readID)
        {

            try
            {
                int i = 0;
                if (eqpName.Contains(ConstUtil.PORT))
                {
                    i++;
                    innerMap1.Add(eqpName, readID);


                }
                Console.WriteLine(i + "次" + innerMap1.Count);
                if (innerMap1.Count == 2)
                {

                    foreach (string key in innerMap1.Keys)
                    {
                        string value = innerMap1[key].Trim().ToString();
                        if (value == ConstUtil.READID_NO_READ || string.IsNullOrEmpty(value))
                        {
                            Console.WriteLine(key + "-----0000--------" + value);
                            //innerMap1.Remove(key);



                        }
                        else
                        {
                            Console.WriteLine(key + "-----0011--------" + value);
                            innerMap2.Add(key, value);

                        }

                    }

                    if (innerMap2.Count == 2)
                    {
                        foreach (string key in innerMap2.Keys)
                        {
                            if (!key.Contains("_"))
                            {
                                BCRReadRequestReply(key, "", innerMap2[key]);
                                Console.WriteLine(key + "-----1111--------" + innerMap2[key]);

                            }

                        }


                    }
                    else if (innerMap2.Count == 1)
                    {
                        var enumerator = innerMap2.GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            Console.WriteLine("key is " + enumerator.Current.Key);
                            Console.WriteLine("value is " + enumerator.Current.Value);
                            if (!enumerator.Current.Key.Contains("_"))
                            {
                                Console.WriteLine(enumerator.Current.Key + "----222-----" + innerMap1[enumerator.Current.Key]);
                                BCRReadRequestReply(enumerator.Current.Key, "", innerMap2[enumerator.Current.Key]);

                            }
                            else
                            {
                                Console.WriteLine(enumerator.Current.Key + "-------333------" + innerMap1[enumerator.Current.Key]);
                                BCRReadRequestReply3(enumerator.Current.Key, "", innerMap2[enumerator.Current.Key]);

                            }

                        }


                    }
                    else
                    {
                        Console.WriteLine(eqpName + "44444444444444444444");
                        BCRReadRequestReply(eqpName, "", ConstUtil.READID_NO_READ);

                        Console.WriteLine("444");
                    }
                    innerMap1.Clear();
                    innerMap2.Clear();


                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

        }

        public void BCRReadRequestReply1(string eqpName, string timeKey, string readID)
        {
            try
            {

                #region 获取双扫码枪值
                Dictionary<string, object> innerMap = null;

                string key = "";
                string key_1 = "";
                if (eqpName.Contains("_"))
                {
                    key_1 = eqpName;
                    key = key_1.Split('_')[0];
                    innerMap = getColIdDic(key);

                    if (innerMap == null)
                    {
                        return;
                    }
                    int count = (int)innerMap["count"];

                    if (count < 1)
                    {
                        if (string.IsNullOrEmpty(readID) || readID == ConstUtil.READID_NO_READ)
                        {
                            //innerMap.Remove("count");
                            //count++;
                            //innerMap.Add("count", count);
                            innerMap["count"] = ++count;
                            return;
                        }
                        innerMap["value"] = readID;
                    }

                }
                else
                {
                    key = eqpName;
                    innerMap = getColIdDic(key);
                    if (innerMap == null)
                    {
                        return;
                    }
                    int count = (int)innerMap["count"];
                    if (count < 1)
                    {
                        if (string.IsNullOrEmpty(readID) || readID == ConstUtil.READID_NO_READ)
                        {

                            innerMap["count"] = ++count;
                            return;
                        }

                        innerMap["value"] = readID;
                    }

                }
                getColIdDicDel(key);

                #endregion
                string port = innerMap["port"].ToString();
                timeKey = innerMap["timeKey"].ToString();
                log.LogInfoWrite("TCP_Driver", GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name + "()", eqpName + "单晶id为：" + readID);
                //处理是否需要翻转
                if (eqpName.Contains("_"))
                {
                    handlerLocalProduct(port, timeKey, readID);
                }
                else
                {
                    handlerRevLocalProduct(port, timeKey, readID);
                }
            }
            catch (Exception ex)
            {
                log.LogErrorWrite("TCP_Driver", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex.ToString());
            }

        }

        private void handlerLocalProduct(string port, string timeKey, string readID)
        {
            var eapreply = new JObject();
            string code = "OK";
            string message = "success";
            int status = 2;
            ObjectManager om = new ObjectManager();
            Type t = om.GetType();
            var propterties = t.GetProperties(BindingFlags.Static | BindingFlags.Public);
            foreach (PropertyInfo pi in propterties)
            {
                var o = Activator.CreateInstance(pi.PropertyType);
                pi.SetValue(om, o);
            }


            //readID = "CDGC2232204Z4801T61Y04W";
            if (readID == ConstUtil.READID_NO_READ)
            {
                code = "NG";
                status = 2;
                message = "单晶id未读取";
            }
            else
            {

                V_CrystalstickDetail vLocalProduct = ObjectManager.V_CrystalstickDetailManager.ViewV_CrystalstickDetailListByCode(readID);
                if (vLocalProduct == null)
                {
                    code = "NG";
                    message = "没有单晶数据";
                    status = 2;
                    eapreply.Add("port", port);
                    eapreply.Add("code", code);
                    eapreply.Add("message", message);
                    eapreply.Add("status", status);
                    tcpCommandService.TCP_HttpReportReply("KQX-JXS-01", timeKey, eapreply);
                    return;
                }
                double first_length = double.Parse(vLocalProduct.D_Long);
                string[] mms = vLocalProduct.WorkShop.Substring(0, vLocalProduct.WorkShop.Length - 1).Split(';');
                if (mms.Length != 1)
                {
                    ArrayList lenRes = new ArrayList();
                    for (int i = 0; i < mms.Length; i++)
                    {
                        double l_length = double.Parse(ObjectManager.V_CrystalstickDetailManager.ViewV_CrystalstickDetailListByCode(mms[i]).D_Long);
                        if (l_length != first_length)
                        {
                            lenRes.Add(l_length);

                        }
                    }

                    lenRes.Sort();
                    if (lenRes == null || lenRes.Count == 0)
                    {
                        status = 2;
                    }
                    else
                    {
                        double max_length = double.Parse(lenRes[lenRes.Count - 1].ToString());

                        if (first_length < max_length)
                        {
                            //当扫码上侧小与剩余最大的长度，status=2代表不翻转
                            status = 1;
                        }
                    }
                }
            }
            eapreply.Add("port", port);
            eapreply.Add("code", code);
            eapreply.Add("message", message);
            eapreply.Add("status", status);
            tcpCommandService.TCP_HttpReportReply("KQX-JXS-01", timeKey, eapreply);

        }

        //反方向
        private void handlerRevLocalProduct(string port, string timeKey, string readID)
        {
            var eapreply = new JObject();
            string code = "OK";
            string message = "success";
            int status = 1;
            ObjectManager om = new ObjectManager();
            Type t = om.GetType();
            var propterties = t.GetProperties(BindingFlags.Static | BindingFlags.Public);
            foreach (PropertyInfo pi in propterties)
            {
                var o = Activator.CreateInstance(pi.PropertyType);
                pi.SetValue(om, o);
            }


            //readID = "CDGC2232204Z4801T61Y04W";
            if (readID == ConstUtil.READID_NO_READ)
            {
                code = "NG";
                status = 2;
                message = "单晶id未读取";
            }
            else
            {

                V_CrystalstickDetail vLocalProduct = ObjectManager.V_CrystalstickDetailManager.ViewV_CrystalstickDetailListByCode(readID);
                if (vLocalProduct == null)
                {
                    code = "NG";
                    message = "没有单晶数据";
                    status = 2;
                    eapreply.Add("port", port);
                    eapreply.Add("code", code);
                    eapreply.Add("message", message);
                    eapreply.Add("status", status);
                    tcpCommandService.TCP_HttpReportReply("KQX-JXS-01", timeKey, eapreply);
                    return;
                }
                double first_length = double.Parse(vLocalProduct.D_Long);
                string[] mms = vLocalProduct.WorkShop.Substring(0, vLocalProduct.WorkShop.Length - 1).Split(';');
                if (mms.Length == 1)
                {
                    status = 2;

                }
                else
                {
                    ArrayList lenRes = new ArrayList();
                    for (int i = 0; i < mms.Length; i++)
                    {
                        double l_length = double.Parse(ObjectManager.V_CrystalstickDetailManager.ViewV_CrystalstickDetailListByCode(mms[i]).D_Long);
                        if (l_length != first_length)
                        {
                            lenRes.Add(l_length);

                        }
                    }

                    lenRes.Sort();
                    if (lenRes == null || lenRes.Count == 0)
                    {
                        status = 2;
                    }
                    else
                    {

                        double max_length = double.Parse(lenRes[lenRes.Count - 1].ToString());
                        if (first_length < max_length)
                        {
                            //当扫码上侧小与剩余最大的长度，status=2代表不翻转
                            status = 2;
                        }
                    }

                }
            }
            eapreply.Add("port", port);
            eapreply.Add("code", code);
            eapreply.Add("message", message);
            eapreply.Add("status", status);
            tcpCommandService.TCP_HttpReportReply("KQX-JXS-01", timeKey, eapreply);

        }
        public void BCRReadRequestReply1_old2(string eqpName, string timeKey, string readID)
        {
            try
            {
                //var machine = ObjectManager.MachineManager.ViewMachine(eqpName);
                // if (machine == null)
                // {
                //    log.LogErrorWrite("TCP_Driver", GetType().Name, MethodBase.GetCurrentMethod().Name, string.Format("Find Machine Error[{0}]:MachineID={1}", timeKey, machine.MachineId));
                //     return;
                // }
                string port = "";
                // timeKey = innerMap["timeKey"].ToString();
                var eapreply = new JObject();

                #region 获取双扫码枪值
                Dictionary<string, object> innerMap = null;
                Dictionary<string, object> innerMap_1 = null;
                string key = "";
                string key_1 = "";
                if (eqpName.Contains("_"))
                {
                    key_1 = eqpName;
                    innerMap_1 = getColIdDic(key_1);
                    innerMap_1["value"] = readID;

                    key = key_1.Split('_')[0];
                    innerMap = getColIdDic(key);
                    if (innerMap["value"].ToString() == "")
                    {
                        return;
                    }
                }
                else
                {
                    key = eqpName;
                    innerMap = getColIdDic(key);
                    innerMap["value"] = readID;

                    key_1 = key + "_1";
                    innerMap_1 = getColIdDic(key_1);
                    if (innerMap_1["value"].ToString() == "")
                    {
                        return;
                    }
                }
                getColIdDicDel(key);
                getColIdDicDel(key_1);

                #endregion

                port = innerMap["port"].ToString();
                timeKey = innerMap["timeKey"].ToString();


                string code = "ok";
                string message = "success";
                int status = 1;
                ObjectManager om = new ObjectManager();
                Type t = om.GetType();
                var propterties = t.GetProperties(BindingFlags.Static | BindingFlags.Public);
                foreach (PropertyInfo pi in propterties)
                {
                    var o = Activator.CreateInstance(pi.PropertyType);
                    pi.SetValue(om, o);
                }


                //readID = "CDGC2232204Z4801T61Y04W";
                if (readID == ConstUtil.READID_NO_READ)
                {
                    code = "NG";
                    message = "单晶id未读取";
                }
                else
                {

                    XdTable xdTable = ObjectManager.XdTableManager.ViewXdTableListBymonocrystal(readID);
                    //todo xdtable判空
                    if (xdTable == null)
                    {
                        code = "NG";
                        message = "没有单晶数据";
                        status = 2;
                        eapreply.Add("port", port);
                        eapreply.Add("code", code);
                        eapreply.Add("message", message);
                        eapreply.Add("status", status);
                        tcpCommandService.TCP_HttpReportReply("KQX-JXS-01", timeKey, eapreply);
                        return;
                    }
                    int first_length = int.Parse(xdTable.Length);
                    string[] mms = xdTable.Mmonocrystal.Substring(0, xdTable.Mmonocrystal.Length - 1).Split(';');

                    ArrayList lenRes = new ArrayList();
                    for (int i = 1; i < mms.Length; i++)
                    {
                        int l_length = int.Parse(ObjectManager.XdTableManager.ViewXdTableListBymonocrystal(mms[i]).Length);
                        lenRes.Add(l_length);
                    }
                    lenRes.Sort();
                    int max_length = int.Parse(lenRes[lenRes.Count - 1].ToString());
                    if (first_length < max_length)
                    {
                        //当扫码上侧小与剩余最大的长度，status=2代表不翻转
                        status = 2;
                    }
                }
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
                Dictionary<string, object> innerMap = null;
                string port = "";
                // timeKey = innerMap["timeKey"].ToString();
                var eapreply = new JObject();

                innerMap = getColIdDic(eqpName);
                port = innerMap["port"].ToString();
                timeKey = innerMap["timeKey"].ToString();



                // 取数据库数据，readid为单晶ID，处理数据逻辑后返回到中为机械手
                //....
                //....
                string code = "ok";
                string message = "success";
                int status = 1;
                ObjectManager om = new ObjectManager();
                Type t = om.GetType();
                var propterties = t.GetProperties(BindingFlags.Static | BindingFlags.Public);
                foreach (PropertyInfo pi in propterties)
                {
                    var o = Activator.CreateInstance(pi.PropertyType);
                    pi.SetValue(om, o);
                }


                //readID = "CDGC2232204Z4801T61Y04W";
                if (readID == ConstUtil.READID_NO_READ)
                {
                    code = "NG";
                    message = "单晶id未读取";
                }
                else
                {

                    XdTable xdTable = ObjectManager.XdTableManager.ViewXdTableListBymonocrystal(readID);
                    //todo xdtable判空
                    if (xdTable == null)
                    {
                        code = "NG";
                        message = "没有单晶数据";
                        status = 2;
                        eapreply.Add("port", port);
                        eapreply.Add("code", code);
                        eapreply.Add("message", message);
                        eapreply.Add("status", status);
                        tcpCommandService.TCP_HttpReportReply("KQX-JXS-01", timeKey, eapreply);
                        return;
                    }
                    int first_length = int.Parse(xdTable.Length);
                    string[] mms = xdTable.Mmonocrystal.Substring(0, xdTable.Mmonocrystal.Length - 1).Split(';');

                    ArrayList lenRes = new ArrayList();
                    for (int i = 1; i < mms.Length; i++)
                    {
                        int l_length = int.Parse(ObjectManager.XdTableManager.ViewXdTableListBymonocrystal(mms[i]).Length);
                        lenRes.Add(l_length);
                    }
                    lenRes.Sort();
                    int max_length = int.Parse(lenRes[lenRes.Count - 1].ToString());
                    if (first_length < max_length)
                    {
                        //当扫码上侧小与剩余最大的长度，status=2代表不翻转
                        status = 2;
                    }
                }
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

        public void BCRReadRequestReply3(string eqpName, string timeKey, string readID)
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
                int status = 2;
                ObjectManager om = new ObjectManager();
                Type t = om.GetType();
                var propterties = t.GetProperties(BindingFlags.Static | BindingFlags.Public);
                foreach (PropertyInfo pi in propterties)
                {
                    var o = Activator.CreateInstance(pi.PropertyType);
                    pi.SetValue(om, o);
                }


                //readID = "CDGC2232204Z4801T61Y04W";
                if (readID == ConstUtil.READID_NO_READ)
                {
                    code = "NG";
                    message = "单晶id未读取";

                }
                var eapreply = new JObject();

                XdTable xdTable = ObjectManager.XdTableManager.ViewXdTableListBymonocrystal(readID);
                if (xdTable == null)
                {
                    code = "NG";
                    message = "没有单晶数据";
                    status = 2;
                    eapreply.Add("port", port);
                    eapreply.Add("code", code);
                    eapreply.Add("message", message);
                    eapreply.Add("status", status);
                    tcpCommandService.TCP_HttpReportReply("KQX-JXS-01", timeKey, eapreply);
                    return;
                }
                int first_length = int.Parse(xdTable.Length);
                string[] mms = xdTable.Mmonocrystal.Substring(0, xdTable.Mmonocrystal.Length - 1).Split(';');

                ArrayList lenRes = new ArrayList();
                for (int i = 1; i < mms.Length; i++)
                {
                    int l_length = int.Parse(ObjectManager.XdTableManager.ViewXdTableListBymonocrystal(mms[i]).Length);
                    lenRes.Add(l_length);
                }
                lenRes.Sort();
                int max_length = int.Parse(lenRes[lenRes.Count - 1].ToString());
                if (first_length < max_length)
                {
                    //当扫码上侧小与剩余最大的长度，status=2代表不翻转
                    status = 1;
                }

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

        public void handlerTCP_BCRReadRequest(string name, string name_1, string timeKey, string portId)
        {
            Dictionary<string, object> innerMap = new Dictionary<string, object>();
            innerMap.Add("name", name);
            innerMap.Add("port", portId);
            innerMap.Add("timeKey", timeKey);
            innerMap.Add("value", "");
            innerMap.Add("count", 0);
            putColIdDic(name, innerMap);

            //Dictionary<string, object> innerMap_1 = new Dictionary<string, object>();
            //innerMap_1.Add("name", name_1);
            //innerMap_1.Add("port", portId);
            //innerMap_1.Add("timeKey", timeKey);
            //innerMap_1.Add("value", "");
            //putColIdDic(name_1, innerMap_1);
            tcpCommandService.TCP_BCRReadRequest(name, timeKey, "SA");
            tcpCommandService.TCP_BCRReadRequest(name_1, timeKey, "SA");
        }


        public void AGVTransferStateCommand(string timeKey, Dictionary<string, string> innerMap, List<Entity.EAPEntities.DataTransferObject.MES_Reply.TRANSPORTJOB> jobList)
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

                        foreach (var tasklist in taskIdList)
                        {
                            var remp = (JObject)tasklist;
                            TRANSPORTJOB tRANSPORTJOB = new TRANSPORTJOB();
                            tRANSPORTJOB.TRANSPORTJOBNAME = remp.GetVal("TRANSPORTJOBNAME");
                            tRANSPORTJOB.TRANSPORTJOBSTATE = remp.GetVal("TRANSPORTJOBSTATE");
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
