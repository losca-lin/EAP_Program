using System;
using System.Reflection;

namespace Getech.EAP.Entity
{
    public class LogData_ZH
    {
        public LogData_ZH() { }
        public string ProductSpec;
        public string Mode { get; set; }
        public string Flow { get; set; }
        public string EventName { get; set; }
        public string LineId { get; set; }
        public string MachineID { get; set; }

        public string MachineStatus { get; set; }

        public string ProductCountByHour { get; set; }

        public string PortId { get; set; }
        public string PortState { get; set; }
        public string PortType { get; set; }
        public string PortUseType { get; set; }
        public string TransferMode { get; set; }
        public string CarrierId { get; set; }
        public string CSTID { get; set; }
        public string RecipeId { get; set; }
        public string ValidationResult { get; set; }
        public string TrayId { get; set; }
        public string CassetteStatus { get; set; }
        public string TrayGroupId { get; set; }
        public string SlotInfo { get; set; }
        public string PPID { get; set; }
        public string ControlCommand { get; set; }
        public string EnableMode { get; set; }
        public string CurrentRecipeID { get; set; }
        public string ReturnCode { get; set; }
        public string CIMMessage { get; set; }
        public string Action { get; set; }
        public string WorkOrder { get; set; }
        public string FromPortId { get; set; }
        public string ToPortId { get; set; }
        public string GlassId { get; set; }
        public string IsLastGlass { get; set; }
        public string CompleteCode { get; set; }
        public string LotId { get; set; }
        public string DateTime { get; set; }
        public string VcrNo { get; set; }
        public string VcrStatus { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string PanelId { get; set; }
        public string UnitGroupId { get; set; }
        public string MaterialId { get; set; }
        public string Version { get; set; }
        public string State { get; set; }
        public string RunningMode { get; set; }
        public string MachineCimMode { get; set; }
        public string ConmmunicationStatus { get; set; }
        public string AlarmId { get; set; }
        public string AlarmState { get; set; }
        public string AlarmText { get; set; }
        public string AlarmLevel { get; set; }
        public string AlarmEnable { get; set; }
        public string CellId { get; set; }
        public string ComponentType { get; set; }
        public string RemoveFlag { get; set; }
        public string InOutType { get; set; }
        public string ChangeType { get; set; }
        public string Permission { get; set; }
        public string LabelCode { get; set; }
        public string UseFlag { get; set; }
        public string LabelType { get; set; }
        public string CardID { get; set; }
        public string CleanerMode { get; set; }
        public string EmpName { get; set; }
        public string ErrorCode { get; set; }
        public string ReasonCodeType { get; set; }
        public string PanelJudge { get; set; }
        public string DutyUser { get; set; }
        public string Position { get; set; }
        public string Size { get; set; }
        public string BoxID { get; set; }
        public string StickID { get; set; }
        public string VendorName { get; set; }
        public string VendorLotNumber { get; set; }
        public string productRequestName { get; set; }
        public string ConsumableSpecName { get; set; }
        public string LensQuantity { get; set; }

        public string MachineDateTime { get; set; }
        public override string ToString()
        {
            var str = string.Empty;
            PropertyInfo[] propertys = this.GetType().GetProperties();
            foreach (PropertyInfo property in propertys)
            {
                var value = property.GetValue(this);
                if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
                {
                    str += property.Name + ":" + value.ToString() + " , ";
                }
            }
            return str;
        }
        public string LineOperMode { get; set; }
        public string TimeStamp { get; set; }
        public string ValiResult { get; set; }
        public string ControlStateName { get; set; }
        public string LineRecipeName { get; set; }
        public string CheckEQPFlag { get; set; }

        public string AutoRecipeChangeMode { get; set; }

        public string OperationMode { get; set; }
        public string LocalNo { get; set; }

        public string CIMMessageID { get; set; }

        public string LocalAlarmState { get; set; }

        public string PortEnable { get; set; }
        public string PreviousRecipeID { get; set; }
        public string ModifyRecipeID { get; set; }
        public string ModifyFlag { get; set; }
        public string VersionNo { get; set; }
        public string ProductName { get; set; }

        public string Status { get; set; }

        public string WorkID { get; set; }

        public string LotID { get; set; }

        public string TimeKey { get; set; }

        public string ModifyType { get; set; }

        public string RecipeID { get; set; }

        public string RecipeVersion { get; set; }

        public string BasketID { get; set; }

        //Box Status Request
        public string Level { get; set; }
        public string Binsum { get; set; }
        public string BinID01 { get; set; }
        public string BinID02 { get; set; }
        public string BinID03 { get; set; }
        public string BinID04 { get; set; }
        public string BinID05 { get; set; }
        public string BinID06 { get; set; }
        public string BinID07 { get; set; }
        public string BinID08 { get; set; }
        public string BinID09 { get; set; }
        public string BinID10 { get; set; }
        public string BinID11 { get; set; }
        public string BinID12 { get; set; }
        public string BinID13 { get; set; }
        public string BinID14 { get; set; }
        public string BinID15 { get; set; }
        public string BinID16 { get; set; }
        public string BinID17 { get; set; }
        public string BinID18 { get; set; }
        public string BinID19 { get; set; }
        public string BinID20 { get; set; }

        //BufferlineNextfreecommand
        public string BufferBlock { get; set; }
        public string PreFreeFlag { get; set; }

        //BufferlineOutReport
        public string BufferLineID { get; set; }

        public string BlockNo { get; set; }

        public string RobotNo { get; set; }

        public string ScanPointNo { get; set; }

        //BufferOutReport
        public string BufferID { get; set; }

        public string BufferFullFlag { get; set; }


        #region
        public string SLOT { get; set; }
        public string CSTSEQNO { get; set; }
        public string PPVEER { get; set; }
        public string CARRIERID { get; set; }
        public string PROCESS_RESULT { get; set; }
        public string PDCNAME { get; set; }
        public string PDCTYPE { get; set; }
        public string PDCVALUE { get; set; }
        public string Result { get; set; }
        public string Resultdescription { get; set; }
        public string AGVName { get; set; }
        #endregion
    }
}
