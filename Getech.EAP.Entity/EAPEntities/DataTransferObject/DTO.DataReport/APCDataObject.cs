using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.DataReportDTO
{
    public class APCDataObject
    {
        public APCDataObject() { }
        public string SUBCD { get; set; }
        public string MachineMode { get; set; }
        public string MachineStatus { get; set; }
    }
    public class APCDataInfo
    {
        public string SUBMACHINEID { get; set; }
        public List<APCDataItem> DATALIST { get; set; }
    }
    public class APCDataItem
    {
        public APCDataItem() { }

        public string DCNAME { get; set; }
        public string DCTYPE { get; set; }
        public string DCVALUE { get; set; }
    }
}
