using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.EAPEntities
{
    public enum EnumCimMode
    {
        On,Off
    }
    public enum EnumAlarmLevel
    {
        Warring,Error,
    }

    public enum EnumUnitType
    {
        Process, Transfer
    }

    public enum EnumUnitStatus
    {
        Run, Idle, Pause, Down, PM
    }

    public enum EnumDCREnableMode
    {
        Enable, Disable
    }
    public enum EnumPortStatus2
    {
        LR, LC,UR,UC
    }
    public enum EnumMachineStatus
    {
        NONE,RUN,DOWN,IDLE,STOP,OTHERS,PAUSE,PM
    }
    public enum EnumPortUseType
    {
        WorkJoob, Material
    }
    public enum EnumPortType
    {
        Loading, Unloading
    }
    public enum EnumPortMode
    {
        OK, NG    }

}
