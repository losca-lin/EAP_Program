using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.DataReportDTO
{
    public class GlassHistoryDataObject
    {
        public GlassHistoryDataObject() { }
        public string GlassID { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string OCTime { get; set; }
        public string OperationID { get; set; }
    }
}
