using Getech.EAP.Entity.DBEntities.DBEntity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using Workbench.Contract;

namespace Getech.EAP.Entity
{
    public class HostInfo : INotifyPropertyChanged
    {
        public static int Quanjuid = 0;
        public event PropertyChangedEventHandler PropertyChanged;
        protected void Notify(string propertyName)
        {
            if (PropertyChanged == null)
            {
                return;
            }
            var e = new PropertyChangedEventArgs(propertyName);
            PropertyChanged(this, e);
        }
        #region 单例模式
        private static readonly Lazy<HostInfo> Lazy = new Lazy<HostInfo>(() => new HostInfo());
        public static HostInfo Current
        {
            get
            {
                return Lazy.Value;
            }
        }
        private HostInfo()
        {
            EquipmentStatus = EquipmentStatus.Idle;
        }
        #endregion
    
        private Dictionary<string, string> ppidValidationResult = new Dictionary<string, string>();
        public Dictionary<string, string> PPIDValidationResult
        {
            get
            {
                return ppidValidationResult;
            }
            set
            {
                if (ppidValidationResult != value)
                {
                    ppidValidationResult = value;
                }
            }
        }
        private string eapId;
        public string EapId
        {
            get
            {
                return eapId;
            }
            set
            {
                if (eapId != value)
                {
                    eapId = value;
                    Notify("LineID");
                }
            }
        }

        //private string mesAlarmPath = ConfigurationManager.AppSettings["MESAlarmMsg"].ToString();
        //public string MESAlarmPath
        //{
        //    get
        //    {
        //        return mesAlarmPath;
        //    }
        //    set
        //    {
        //        if (mesAlarmPath != value)
        //        {
        //            mesAlarmPath = value;
        //            Notify("MESAlarmPath");
        //        }
        //    }
        //}

        private ObservableCollection<object> inlineToolList = new ObservableCollection<object>();
        public ObservableCollection<object> InlineToolList
        {
            get
            {
                return inlineToolList;
            }
            set
            {
                if (inlineToolList != value)
                {
                    inlineToolList = value;
                }
            }
        }
        private Dictionary<string, string> mesMessageList = new Dictionary<string, string>();
        public Dictionary<string, string> MESMessageList
        {
            get
            {
                return mesMessageList;
            }
            set
            {
                if (mesMessageList != value)
                {
                    mesMessageList = value;
                }
            }
        }
        private ControlState controlState;
        public ControlState ControlState
        {
            get
            {
                return controlState;
            }
            set
            {
                if (controlState != value)
                {
                    controlState = value;
                    Notify("ControlState");
                }
            }
        }
        public EquipmentStatus EquipmentStatus { get; set; }

        private bool isHostConnect;
        public bool IsHostConnect
        {
            get { return isHostConnect; }
            set
            {
                if (isHostConnect != value)
                {
                    isHostConnect = value;
                    Notify("IsHostConnect");
                }
            }
        }

        private ObservableCollection<string> msgList = new ObservableCollection<string>();
        public ObservableCollection<string> MsgList
        {
            get
            {
                return msgList;
            }
            set
            {
                msgList = value;
                Notify("MsgList");
            }
        }
        public string PPIDValidationMessage { get; set; }
        #region[新]
        // Add Yangzhenteng
        private Dictionary<string, EapMachine> machineList = new Dictionary<string, EapMachine>();
        public Dictionary<string, EapMachine> MachineList
        {
            get { return machineList; }
            set
            {
                if (machineList != value)
                {
                    machineList = value;
                    Notify("MachineList");
                }
            }
        }
        //private Dictionary<string, DCRInfo> dcrlist = new Dictionary<string, DCRInfo>();
        //public Dictionary<string, DCRInfo> DCRList
        //{
        //    get { return dcrlist; }
        //    set
        //    {
        //        if (dcrlist != value)
        //        {
        //            dcrlist = value;
        //            Notify("DCRList");
        //        }
        //    }
        //}
        //private Dictionary<string, MaterialInfo2> materiallist = new Dictionary<string, MaterialInfo2>();
        //public Dictionary<string, MaterialInfo2> MaterialList
        //{
        //    get { return materiallist; }
        //    set
        //    {
        //        if (materiallist != value)
        //        {
        //            materiallist = value;
        //            Notify("MaterialList");
        //        }
        //    }
        //}
        //private Dictionary<string, PortInfo2> portinfolist = new Dictionary<string, PortInfo2>();
        //public Dictionary<string, PortInfo2> PortInfoList
        //{
        //    get { return portinfolist; }
        //    set
        //    {
        //        if (portinfolist != value)
        //        {
        //            portinfolist = value;
        //            Notify("PortInfoList");
        //        }
        //    }
        //}
        private Dictionary<string, string> secsCmdtimekey = new Dictionary<string, string>();
        public Dictionary<string, string> SECSCMDTimeKey
        {
            get
            {
                return secsCmdtimekey;
            }
            set
            {
                if (secsCmdtimekey != value)
                {
                    secsCmdtimekey = value;
                }
            }
        }

        #endregion

        public string EQPCurrentTime = "";
    }
}
