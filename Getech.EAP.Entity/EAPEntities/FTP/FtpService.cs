using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Workbench.Contract.Log;

namespace Getech.EAP.Entity.FTP
{
    public class FTPService
    {

        /// <summary>
        /// BC收到规定消息生成文档
        /// </summary>
        /// <param name="ftphelper"></param>
        private static string FTPConstr = "ftp://10.109.171.54:21/";//FTP的服务器地址，格式为ftp://192.168.1.234:8021/
        private static string FTPUserName = "test";//FTP服务器的用户名
        private static string FTPPassword = "test";//FTP服务器的密码
        private static string IPAddress = "";//IP地址
        protected static readonly ILogManager log = NLogManager.Logger;


        private static readonly Lazy<FTPService> Lazy = new Lazy<FTPService>(() => new FTPService());
        public static FTPService Current
        {
            get
            {
                return Lazy.Value;
            }
        }

        public void CreatFile(FtpHelper ftphelper)
        {
            var FtpPath = ConfigurationManager.AppSettings["FtpPaths"];
            var LineID = ftphelper.EQPID;
            string cstSeqNo = ftphelper.CASSETTESEQNO;
            if (!(string.IsNullOrWhiteSpace(LineID)))
            {
                var PanelID = ftphelper.PANELID;
                //FtpPath = FtpPath + LineID + "\\" + PanelID[0] + PanelID[4] + "\\" + PanelID[1] + PanelID[2] + PanelID[3] + "\\" + PanelID[5] + PanelID[6] + "\\" + PanelID[7] + PanelID[8];
                FtpPath = FtpPath + LineID + "\\" + cstSeqNo;

                if (!Directory.Exists(FtpPath))
                {
                    Directory.CreateDirectory(FtpPath);
                }
                var name = FtpPath + "\\" + PanelID + ".dat";
                //如果文档存在删除，不存在则新建
                if (!File.Exists(name))
                {
                    File.Create(name).Close();
                }
                else
                {
                    File.Delete(name);
                }
                try
                {
                    using (StreamWriter txt = new StreamWriter(name, true, Encoding.Default))
                    {
                        txt.Flush();
                        txt.WriteLine(
                            makeFTPFileCommonString("Panel_ID", ftphelper.PANELID, 20) +
                            makeFTPFileCommonString("FPC_ID", ftphelper.FPCID, 34) +
                            makeFTPFileCommonString("Product_ID", ftphelper.PRODUCTID, 14) +
                            makeFTPFileCommonString("Owner_ID", ftphelper.OWNERID, 14) +
                            makeFTPFileCommonString("Owner_Code", ftphelper.OWNERCODE, 4) +
                            makeFTPFileCommonString("Owner_Type", ftphelper.OWNERTYPE, 14) +
                            makeFTPFileCommonString("Lot_ID", ftphelper.LOTID, 12) +
                            makeFTPFileCommonString("Process_ID", ftphelper.PROCESSID, 4) +
                            makeFTPFileCommonString("Recipe_ID", ftphelper.RECIPEID, 40) +
                            makeFTPFileCommonString("SaleOrder", ftphelper.SALEORDER, 10) +
                            makeFTPFileCommonString("PreProcess_ID", ftphelper.PREPROCESSID, 4) +
                            makeFTPFileCommonString("Group_ID", ftphelper.GROUPID, 15) +
                            makeFTPFileCommonString("Product_Info", ftphelper.PRODUCTINFO, 50) +
                            makeFTPFileCommonString("LOT_Info", ftphelper.LOTINFO, 50) +
                            makeFTPFileCommonString("Product_Group", ftphelper.PRODUCTGROUP, 20) +
                            makeFTPFileCommonString("From_Site", ftphelper.FROMSITE, 5) +
                            makeFTPFileCommonString("Current_Site", ftphelper.CURRENTSITE, 5) +
                            makeFTPFileCommonString("From_Shop", ftphelper.FROMSHOP, 5) +
                            makeFTPFileCommonString("Current_Shop", ftphelper.CURRENTSHOP, 5) +
                            makeFTPFileCommonString("MMGFlag", ftphelper.MMGFLAG, 1) +
                            makeFTPFileCommonString("PANELSIZE", ftphelper.PANELSIZE, 4000)
                            );
                        txt.Close();
                    }
                }
                catch (Exception ex)
                {
                    log.LogErrorWrite("CommonService", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex);
                    //FlowLogHelper.HostLog.Error("CreatFile:" +ex.ToString());
                }
            }
            else
            {
                log.LogErrorWrite("CommonService", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", "LineID is null");
                //FlowLogHelper.HostLog.Error("WH.GETECH.EAP.Service.exe.config:"+ " Line value is NULL");
            }
        }

        private string makeFTPFileCommonString(string itemName, string targetValue, int length)
        {
            try
            {
                return string.Format("{0}={1}』\r\n", itemName, makeFTPFileDefaultString(targetValue, length));
            }
            catch (Exception ex)
            {
                log.LogErrorWrite("CommonService", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex);
                return "』\r\n";
            }
        }
        private string makeFTPFileDefaultString(string targetValue, int length)
        {
            try
            {
                if (targetValue == null)
                    targetValue = string.Empty;
                StringBuilder targetStringBuilder = new StringBuilder();

                for (int i = 0; i < length; i++)
                {
                    if (targetValue.Length - 1 >= i)
                    {
                        targetStringBuilder.Append(targetValue.ToCharArray()[i]);
                    }
                    else
                    {
                        targetStringBuilder.Append(" ");
                    }
                }

                return targetStringBuilder.ToString();
            }
            catch (Exception ex)
            {
                log.LogErrorWrite("CommonService", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex);
                return "";
            }


        }

        public void DeleteFile(FtpHelper ftphelper)
        {
            var FtpPath = ConfigurationManager.AppSettings["FtpPaths"];
            var LineID = ftphelper.EQPID;
            if (!(string.IsNullOrWhiteSpace(LineID)))
            {
                var PanelID = ftphelper.PANELID;
                FtpPath = FtpPath + LineID + "\\" + PanelID[0] + PanelID[4] + "\\" + PanelID[1] + PanelID[2] + PanelID[3] + "\\" + PanelID[5] + PanelID[6] + "\\" + PanelID[7] + PanelID[8];
                var name = FtpPath + "\\" + PanelID + ".dat";
                try
                {
                    File.Delete(name);
                }
                catch (Exception ex)
                {
                    log.LogErrorWrite("CommonService", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex);
                    //FlowLogHelper.HostLog.Error("DeleteFile:" + ex.ToString());
                }
            }
            else
            {
                log.LogErrorWrite("CommonService", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", "LineID is null");
                //FlowLogHelper.HostLog.Error("WH.GETECH.EAP.Service.exe.config:" + " Line value is NULL");
            }
        }
        public bool UploadFile(string ftpPath, string path, string name)
        {
            try
            {
                FileInfo f = new FileInfo(path);
                var date = DateTime.Now.ToString("yyyy-MM-dd");
                MakeDir(ftpPath + "//" + date);
                FtpWebRequest reqFtp = (FtpWebRequest)WebRequest.Create(new Uri(ftpPath + "//" + date + "//" + name));
                reqFtp.UseBinary = true;
                reqFtp.Credentials = new NetworkCredential(FTPUserName, FTPPassword);
                reqFtp.KeepAlive = false;
                reqFtp.Method = WebRequestMethods.Ftp.UploadFile;
                reqFtp.ContentLength = f.Length;
                int buffLength = 2048;
                byte[] buff = new byte[buffLength];
                int contentLen;
                FileStream fs = f.OpenRead();
                try
                {
                    Stream strm = reqFtp.GetRequestStream();
                    contentLen = fs.Read(buff, 0, buffLength);
                    while (contentLen != 0)
                    {
                        strm.Write(buff, 0, contentLen);
                        contentLen = fs.Read(buff, 0, buffLength);
                    }
                    strm.Close();
                    fs.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    log.LogErrorWrite("CommonService", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex);
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.LogErrorWrite("CommonService", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex);
                return false;

            }

        }
        public bool MakeDir(string dirName)
        {
            try
            {
                bool b = RemoteFtpDirExists(dirName);
                if (b)
                {
                    return true;
                }
                FtpWebRequest reqFtp = (FtpWebRequest)WebRequest.Create(new Uri(dirName));
                reqFtp.UseBinary = true;
                reqFtp.Method = WebRequestMethods.Ftp.MakeDirectory;
                reqFtp.Credentials = new NetworkCredential(FTPUserName, FTPPassword);
                FtpWebResponse response = (FtpWebResponse)reqFtp.GetResponse();
                response.Close();
                return true;
            }
            catch (Exception ex)
            {
                log.LogErrorWrite("CommonService", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex);
                return false;
            }

        }
        public bool RemoteFtpDirExists(string path)
        {
            try
            {
                path = FTPConstr + path;
                FtpWebRequest reqFtp = (FtpWebRequest)WebRequest.Create(new Uri(path));
                reqFtp.UseBinary = true;
                reqFtp.Credentials = new NetworkCredential(FTPUserName, FTPPassword);
                reqFtp.Method = WebRequestMethods.Ftp.ListDirectory;
                FtpWebResponse resFtp = null;
                try
                {
                    resFtp = (FtpWebResponse)reqFtp.GetResponse();
                    FtpStatusCode code = resFtp.StatusCode;//OpeningData
                    resFtp.Close();
                    return true;
                }
                catch
                {
                    if (resFtp != null)
                    {
                        resFtp.Close();
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                log.LogErrorWrite("CommonService", GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex);
                return false;
            }

        }

        public string GetIpAddress()
        {
            var str = string.Empty;
            string HostName = Dns.GetHostName();
            IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
            for (int i = 0; i < IpEntry.AddressList.Length; i++)
            {
                if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    str = IpEntry.AddressList[i].ToString();
                }
            }
            return str;
        }
    }
}
