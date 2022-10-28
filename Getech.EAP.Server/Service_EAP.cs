using Workbench.Contract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Xml;
using Workbench.Framework;
using System.ServiceProcess;
using Getech.EAP.Entity;
using System.Configuration;
using Workbench.Contract.RuleProxy;
using Getech.EAP.Entity.DBEntities.EntityManger;
using System.Reflection;
using Getech.EAP.TCP.Contract;
using Getech.EAP.Entity.DBEntities.DBEntity;
using Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities;
using System.Runtime.InteropServices;

namespace Getech.EAP.Service
{
    public partial class Service_EAP : ServiceBase
    {        
        public static List<IConnectionContext> ConnectionContexts { get; set; }
        private static IApplicationContext appContext;
        public bool OpenSuccessed=true;
        public Service_EAP()
        {
            InitializeComponent();
            var xx1 = ConfigurationManager.AppSettings["EapId"].Replace(" ", "").ToString();
            var proExe = Process.GetProcessesByName("Getech.EAP.Server." + ConfigurationManager.AppSettings["EapId"].Replace(" ","").ToString());
            if (proExe.Length > 1)
            {
                Console.WriteLine("Already Exist");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
        }
 ///* 
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("kernel32")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("Kernel32")]
        private static extern bool SetConsoleCtrlHandler(EventHandler handler, bool add);
 //*/
        protected override void OnStart(string[] args)
        {
            try
            {
                ConnectionContexts = new List<IConnectionContext>();
                Startup applicationStartup = new Startup();
                applicationStartup.Initialization();
                appContext = CommonContexts.ApplicationContext;
                Console.WriteLine("Auto.Framework Success!");
                Console.WriteLine(DateTime.Now);            
                //初始化数据
                // ObjectInitialize();
                //  Console.WriteLine("DB Intialize Success!");

                //rule config file initialization
                // ruleXmlInit();
                InitConnections(out OpenSuccessed);

                
                if (OpenSuccessed)
                {
                    Console.WriteLine("EAP Server Started!");
                }
                else
                {
                    Console.WriteLine("EAP Server Started Error,Please Check Connections!");
                    Console.ReadLine();

                }
                Console.ReadLine();
                IntPtr hConsole = GetConsoleWindow();
                if (IntPtr.Zero != hConsole)
                {
                    ShowWindow(hConsole, 0);
                }

                //new ManualResetEvent(false).WaitOne();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }
        protected override void OnStop()
        {
            appContext.CloseAllConnectionContext();
        }
        private void ObjectInitialize()
        {
            ObjectManager om = new ObjectManager();
            Type t = om.GetType();
            var propterties = t.GetProperties(BindingFlags.Static | BindingFlags.Public);
            foreach (PropertyInfo pi in propterties)
            {
                var o = Activator.CreateInstance(pi.PropertyType);
                pi.SetValue(om, o);
            }         
            var eapId = ConfigurationManager.AppSettings["EapId"].Replace(" ","");
            List<EapLine> Lineinfolist = new List<EapLine>();
            Console.WriteLine("\nEapId:    " + eapId);
            var lineList = ObjectManager.LineManager.ViewLineList(eapId);
            HostInfo.Current.EapId = eapId;
            if (lineList != null)
            {
                foreach(var EapLine in lineList)
                {
                    string lineid = EapLine.LineId;
                    InlineTool inlineTool = new InlineTool
                    {
                        LineID = EapLine.LineId
                    };
                    if ("Offline".Equals(EapLine.OnlineControlStatus))
                    {
                        inlineTool.ControlState = ControlState.OffLine;
                    }
                    else if ("OnLineRemote".Equals(EapLine.OnlineControlStatus) || "Online".Equals(EapLine.OnlineControlStatus))
                    {
                        inlineTool.ControlState = ControlState.OnLineRemote;
                    }
                    else
                    {
                        inlineTool.ControlState = ControlState.OnLineLocal;
                    }
                    HostInfo.Current.InlineToolList.Add(inlineTool);
                    var list = ObjectManager.MachineManager.ViewMachineListbyLineId(lineid);
                    if (list != null)
                    {
                        foreach (var item in list)
                        {
                            HostInfo.Current.MachineList.Add(item.MachineId, item);
                            Console.WriteLine("Machine: " + item.MachineId);
                        }
                    }
                    var unitlist = ObjectManager.UnitManager.ViewUnitListByLineId(lineid);
                    if (unitlist != null)
                    {
                        foreach (var item in unitlist)
                        {
                            Console.WriteLine("Unit:    " + lineid + "-" + item.UnitId);
                        }
                    }
                    var dcrlist = ObjectManager.DCRManager.ViewDCRListByLineID(lineid);
                    if (dcrlist != null)
                    {
                        foreach (var item in dcrlist)
                        {
                            Console.WriteLine("DCR:     " + item.DcrName);
                        }
                    }
                }
            }
        }


        internal void TryStop()
        {

        }
        public static void InitConnections(out bool OpenSuccessed)
        {
            OpenSuccessed = true;
            try
            {
              var connections=  appContext.OpenAllConnectionContext();
               foreach (var connectionname in connections)
               {
                    if (connectionname.IsConnected)
                    {
                        Console.WriteLine(string.Format("Connection:{0},Open Successed...", connectionname.Name));
                    }
                    else
                    {
                        OpenSuccessed = false;
                        Console.WriteLine(string.Format("Connection:{0},Open Failed...", connectionname.Name));
                    }
               }
            }
            catch (Exception ex)
            {
                OpenSuccessed = false;
                Console.WriteLine(ex.ToString());
            }
        }
        internal void TestStartupAndStop(string[] args)
        {
            this.OnStart(args);
            //Console.ReadLine();
            //this.OnStop();
        }
        private void ruleXmlInit()
        {
            try
            {
                RuleManagerImpl.Current.init();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    
    }
}
