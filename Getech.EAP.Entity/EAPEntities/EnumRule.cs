using System;

namespace Getech.EAP.Entity
{
    //[料座：MaterialBase，水箱：Tank，片篮：WaferBasket]
    public enum CarrierType
    {
        MaterialBase,
        Tank,
        WaferBasket
    }
    public enum OperationType
    {
        TJ,
        QX
    }
    //[LR: LoadRequest，LC:LoadComplete，UR:UnloadRequest]
    public enum PortStatus
    {
        LR,
        LC,
        UR
    }

    public enum InOrOut
    {
        In,
        Out

    }
    public enum EnableOrDisable
    {
        None,
        Disable,
        Enable
    }
    public enum OnOrOff
    {
        On,
        Off
    }
    public enum InOrOutBoxOrPallet
    {
        InBox,
        OutBox,
        Pallet
    }

    public enum OkOrNg
    {
        OK,
        NG
    }

    public enum SetOrRelease
    {
        Set,
        Release
    }

    public enum UsedByGlassID
    {
        UsedByGlassID,
        UsedByFPCID
    }

    public enum AlarmStatus
    {
        Clear,
        Set
    }

    public enum ChangePlanType
    {
        Auto,
        Manual
    }
    public enum MachineAlive
    {
        Down,
        Alive
    }

    public enum MachineStatus
    {
        RUN,
        IDEL,
        STOP,
        DOWN
    }

    public enum AlarmCode
    {
        None,
        DangerForHuman,
        EquipmentError,
        ParameterOverflowCausedProcessError,
        ParameterOverflowCausedEquipmentCannotWork,
        CannotRecoverTrouble,
        EquipmentStatusWarning,
        ProcessReachedToPredefinedStatus,
        BCCaused
    }

    public enum AlarmLevel
    {
        Warning,
        Error
    }

    public enum AlarmTextUsingFlag
    {
        UsingEQPReportAlarmText,
        UsingBCAlarmText
    }

    public enum CassetteStatus
    {
        NoCassetteExist,
        WaitingForCassetteData,
        WaitingForStartCommand,
        WaitingForProcessing,
        InProcessing,
        ProcessPaused,
        ProcessCompleted,
        CassetteReMap,
        InAborting

    }
    public enum ControlState
    {
        OffLine,
        OnLineRemote,
        OnLineLocal
    }

    public enum CompletedCassetteData
    {
        None,
        NormalComplete,
        OperatorForcedtoCancel,
        OperatorForcedtoAbort,
        BCForcedtoCancel,
        BCForcedtoAbort,
        EQAutoCancel,
        EQAutoAbort
    }
    public enum PortSamplineFlag
    {
        Y, N
    }

    public enum CassetteControlCommand
    {
        CassetteProcessStart,
        CassetteProcessStartByCount,
        CassetteProcessPause,
        CassetteProcessResume,
        CassetteProcessAbort,
        CassetteProcessCancel,
        CassetteReload,
        CassetteLoad,
        CassetteRe_Map,
        CassetteProcessEnd,
        CassetteMapDownload,
        CassetteAborting,
    }
    public enum ProcessDataType
    {
        APC,
        Daily,
        Energy,
        Glass
    }
    public enum ProcessPauseCommand
    {
        Pause, Resume
    }
    public enum ProcessStopCommand
    {
        Stop, Run
    }
    public enum TransferStopCommand
    {
        Stop, Resume
    }
    public enum PortControlCommand
    {
        CassetteMapDownload,
        CassetteChuck,
        CassetteUnChuck,
        CassetteReChuck,
        CassetteProcessEnd
    }

    public enum CassetteControlCommandReturnCode
    {
        CommandOK,
        CommandError,
        CSTIDisInvalid,
        RecipeMismatch,
        SlotInformationMismatch,
        JobTypeMismatch,
        CassetteSettingCodeMismatch,
        AlreadyReceived,
        OtherError,
        ProductTypeMismatch,
        GroupIndexMismatch,
        ProductIDMismatch
    }

    public enum CassetteMappingState
    {
        MappingUse, MappingNotUse
    }

    public enum PortControlCommandReturnCode
    {
        CommandOK,
        CommandError,
        SlotInformationMismatch,
        JobTypeMismatch,
        DummyTypeMismatch,
        AlreadyReceived,
        OtherError,
        ProductTypeMismatch,
        GroupIndexMismatch,
        ProductIDMismatch
    }

    public enum EquipmentStatus
    {
        Idle,
        Run,
        Down,
        PM,
        Setup,
        Pause,
        Stop
    }
    public enum LoadingCassetteType
    {
        None, ActualCassette, EmptyCassette
    }

    public enum QTimeFlag
    {
        None, NormalUnloading, QTimeOverAndUnloading
    }

    public enum WIPSlotProcessingState
    {
        WaitingProcess,
        ProcessCompleted,
        Processing
    }

    public enum SubstrateType
    {
        Glass,
        Half,
        Chip,
        Cassette
    }

    public enum CstOperationMode
    {
        KindToKind,
        CassetteToCassette,
        LotToLot
    }
    public enum PanelType
    {
        Normal,
        MMG,
        QNormal,
        QMMG
    }
    public enum DummyType
    {
        NotUsed,
        General,
        QC,
        Through,
        Mask,
        Screen,
        ODFSeal,
        VAS,
        LaserSeal,
        ITO,
        Photo,
        TPCD,
        Monitor,
        Thickness,
        RubbingMonitor,
        RubbingAging,
        MM,
        Bare,
        ODFUVMask,
        ODFBare,
        ODFLC,
        PIInkjet,
        ParticleBare
    }
    public enum JobJudge
    {
        OK,
        NG,
        PD,
        RW,
        RP
    }
    public enum VCRResult
    {
        VCRReadingOKAndMatchWithJobDataGlassID,
        VCRReadingOKAndMismatchWithJobDataGlassID,
        VCRReadingFailAndKeyInAndMatchWithJobDataGlassID,
        VCRReadingFailAndKeyInAndMismatchWithJobDataGlassID
    }



    public enum PortType
    {
        None,
        Loading,
        Unloading,
        Both,
        Buffer,
        LoaderInBuffer,
        UnloaderInBuffer,
        AGVLoadingFull,
        AGVLoadingEmpty,
        AGVUnloadingFull,
        AGVUnloadingEmpty,
    }
    public enum PortOperationMode
    {
        AutoMode,
        SemiAutoMode,
        ManualMode
    }
    public enum PortTransferMode
    {
        None,
        MGV,
        AGV,
        StockerInline,
        OHT
    }
    public enum PortMode
    {
        None,
        TFT,
        HF,
        MQC,
        Dummy,
        OLED,
        HT,
        LT,
        ENG,
        ILC,
        FLC,
        ThroughDummy,
        ThicknessDummy,
        UVMask,
        ByGrade,
        OK,
        NG,
        MIX,
        EMP,
        RW,
        Mismatch,
        PD,
        IR,
        RP,
        ReJudge,
        TFTDense,
        TFTCassette,
    }

    public enum PortDown
    {
        None, Normal, Down
    }

    public enum JobGade
    {
        InspectSkiporNoJudge,
        OK,
        NG,
        RP,
        RD,
        RL,
        RC,
        RJ
    }

    public enum JobType
    {
        NotUsed,
        TFT,
        HF,
        NormalDummy,
        OLED,
        Reserved,

        TEGDummy,
        ToolingDummy,
        OffsetDummy,
        PIDummy,
        KeyDummy,
        TFECVDDummy,
        TFEInkjetDummy,
        ITODummy,
        IGZODummy,
    }

    public enum ProcessReasonCode
    {
        NoError,
        StopByOP,
        MaterialProblem,
        AbortByEQP,
        AbortByOP,
    }

    public enum ReprocessFlag
    {
        Default,
        SetReprocess,
        ReprocessDone,
    }
    public enum EXPOProcess
    {
        NeedFront,
        NeedBack
    }

    public enum MuraRiskFlag
    {
        MuraRiskFlag
    }

    public enum CuttingGlassType
    {
        None,
        AType,
        BType
    }
    public enum VIMaskInspectionResult
    {
        Default,
        GoToMaskBuff,
        GoToUnloader,
        Scrap,
    }

    public enum CimModeCommandReturnCode
    {
        Accept,
        AlreadyInDesiredStatus,
        EquipmentReject,
    }
    public enum UnitorPort
    {
        Equipment,
        Unit,
        Port,
    }
    public enum RecipeRegisterReturnCode
    {
        AllRecipeRegistered,
        RecipeNotRegistered

    }
    public enum LoaderOperationMode
    {
        LTPS, Encap
    }
    public enum EqpAutoMode
    {
        Invalid,
        MANUAL,
        AUTO,
        SEMIAUTP,
        Auto,
        Manual

    }
    public enum DCREnableMode
    {
        Enable,
        Disable
    }
    public enum PortEnableMode
    {
        Unknown,
        Enable,
        Disable
    }
    public enum EqpRunMode
    {
        Normal,
        TFEMode,
        HFMode,
        CoolRunMode,
        ForceCleanMode,
        MIXRunMode
    }
    public enum CimMode
    {
        On,
        Off
    }
    public enum MesPortType
    {
        Unknown,
        PL,
        PU,
        PB,
        Buffer,
        LoaderInBuffer,
        UnloaderInBuffer,
        AGVLoadingEmpty,
        AGVLoadingFull,
        AGVUnloadingEmpty,
        AGVUnloadingFull
    }
    public enum MesMachnieCIMMode
    {
        Unknown,
        N,
        Y
    }
    public enum MachineRunMode
    {
        Unknown,
        PASS,
        APAS,
        CVD2S,
        CVD2D,
        CVD4P1,
        CVD4P2,
        CVD2O,
        CVD2Q,
        CVD4Q,
        DRYENG,
        DRYMQC,
        DRYIGZO,
        DRYA,
        DRYB,
        MIX
    }
    public enum Materialstatus
    {
        INUSE,
        MOUNT,
        DISMOUNT,
        PREPARE,
    }
    public enum SecsMachineStatus
    {
        Unkown ,
        T,
        S,
        P,
        I,
        R
    }
    public enum ItemExpressionEnum
    {
        NONE,
        I,
        SI,
        LONG,
        SINT,
        EXP,
        A,
        HEX,
        BIT,
        BIN,
        H 
    }
    public enum JobStatus
    {
        None,
        Nothing,
        Ready,
        Idle,
        Reserved,
        Processing,
        Done,
        Aborted,
        Canceled,
        Completed,
    }
    public enum MesMaterialJudge
    {
        NotUsed,
        OK,
        NG,
        Rework,
        Reprocess,
        Scrap,
        ReTest,
        Repair,
        CutRepair,
        CVDRepair
    }
    public enum MesMaskType
    {
        FMM,
        MMM,
        CMM
    }
    public enum PortUseType
    {
        Invalid,
        O,
        G,
        N,
        R,
        P,
        D,
        M,
        EU,
        EL
    }
    public enum UnitType
    {
        Invalid,
        Normal,
        Port,
        Buffer,
        VCR
    }
    public enum UnitStatus
    {
        Setup,
        Pause,
        Stop,
        Idle,
        Run
    }
    public enum OnlineControlStatus
    {
        Online,
        Local,
        Offline
    }
}
