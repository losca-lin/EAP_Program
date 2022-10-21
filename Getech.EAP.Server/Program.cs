using Getech.EAP.Service;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;
using Workbench.Contract.Log;

namespace Getech.EAP.Server
{
    static class Program
    {
        static void command(string path, string args)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.Arguments = args;
            p.StartInfo.FileName = path;
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p.StartInfo.CreateNoWindow = true;//重定向标准错误输出
            p.Start();//启动程序
            p.OutputDataReceived += (s, _e) => { Console.WriteLine(_e.Data); };
            p.ErrorDataReceived += (s, _e) => { Console.WriteLine(_e.Data); };
            p.Exited += (s, _e) => { Console.WriteLine("Exit With " + p.ExitCode); };
            p.BeginErrorReadLine();
            p.BeginOutputReadLine();
            //向cmd窗口发送输入信息
            p.StandardInput.AutoFlush = true;
            p.WaitForExit();
        }
        private static void UnhandledExceptionEventHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Exception error = (Exception)e.ExceptionObject;
            try
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UnhandledException.log"), true))
                {
                    string data = DateTime.Now.ToString("yyyyMMddHHmmssfff") + "\t\t" + error.Message + Environment.NewLine;
                    data += error.GetType().ToString() + Environment.NewLine;
                    data += error.ToString() + Environment.NewLine + Environment.NewLine;
                    sw.WriteLine(data);
                    sw.Close();
                    sw.Dispose();
                }
            }
            catch
            {

            }
        }
        private static Service_EAP service1;
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(UnhandledExceptionEventHandler);
            bool createNew;
            using (Mutex mutex = new Mutex(true, "Service", out createNew))
            {
                if (true)  // createNew
                {
                    if (Environment.UserInteractive)
                    {
                        service1 = new Service_EAP();
                        string DotNetFolder = @"C:\Windows\Microsoft.NET\Framework64\";
                        if (!System.IO.Directory.Exists(DotNetFolder))
                        {
                            DotNetFolder = @"C:\Windows\Microsoft.NET\Framework\";
                        }
                        if (args.Count() > 0)
                        {
                            switch (args[0])
                            {
                                case "-c":
                                    _handler += new EventHandler(OnExit);
                                    SetConsoleCtrlHandler(_handler, true);
                                    service1.TestStartupAndStop(args);
                                    break;
                                case "-i":
                                    command(DotNetFolder + @"v4.0.30319\installutil.exe", "\"" + System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Getech.EAP.Service.exe") + "\"");
                                    break;
                                case "-u":
                                    command(DotNetFolder + @"v4.0.30319\installutil.exe", "/u \"" + System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Getech.EAP.Service.exe") + "\"");
                                    break;
                                case "-s":
                                    try
                                    {
                                        command(DotNetFolder + @"\v4.0.30319\installutil.exe", "\"" + System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Getech.EAP.Service.exe") + "\"");
                                    }
                                    catch
                                    {

                                    }
                                    command("net.exe", "start Getech.EAP.Service");
                                    break;
                                default:
                                    Console.WriteLine(@"[ -i | -install ] Install as a Windows Service.
                                                        [ -u | -uninstall ] Uninstall the Windows Service.
                                                        [ -s | -start ]  Start or install and start the service.
                                                        [ -c | -console ] Run as a console application.
                                                        [ -h | -help | -? ] Display list of arguments");
                                    Console.ReadLine();
                                    break;
                            }
                        }
                        else
                        {

                            _handler += new EventHandler(OnExit);
                            SetConsoleCtrlHandler(_handler, true);
                            service1.TestStartupAndStop(args);
                        }
                    }
                    else
                    {
                        ServiceBase[] ServicesToRun;
                        ServicesToRun = new ServiceBase[]
                        {
                                 new Service_EAP()
                        };
                        ServiceBase.Run(ServicesToRun);
                    }
                }
                else
                {
                    Console.WriteLine("Already Running");
                    Console.ReadLine();
                }
            }
        }

        [DllImport("Kernel32")]
        private static extern bool SetConsoleCtrlHandler(EventHandler handler, bool add);
        private delegate bool EventHandler(CtrlType sig);
        static EventHandler _handler;
        enum CtrlType
        {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT = 1,
            CTRL_CLOSE_EVENT = 2,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT = 6
        }

        private static bool OnExit(CtrlType sig)
        {
            switch (sig)
            {
                case CtrlType.CTRL_C_EVENT:
                case CtrlType.CTRL_LOGOFF_EVENT:
                case CtrlType.CTRL_SHUTDOWN_EVENT:
                case CtrlType.CTRL_CLOSE_EVENT:
                    if (service1 != null)
                        service1.TryStop();
                    return true;
                default:
                    return false;
            }
        }
    }
}
