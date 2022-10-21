using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.DataReportDTO
{
    public class ProcessDataObject
    {
        public ProcessDataObject() { }
        public string MachineID { get; set; }
        public string SUBCD { get; set; }
        public string MachineMode { get; set; }
        public string MachineStatus { get; set; }
        public string OperationID { get; set; }
        public string GlassID { get; set; }
        public string Slot { get; set; }
        public string PPID { get; set; }
        public string CassetteSeqNo { get; set; }
        public string UNIQUEID { get; set; }
        public string PPVER { get; set; }
        public string CARRIERID { get; set; }
        public string PROCESS_RESULT { get; set; }
    }
}
