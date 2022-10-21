using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.DataReportDTO
{
    public class GlassHistoryDataItem
    {
        public GlassHistoryDataItem() { }
        public string UNITID { get; set; }
        public string PROCESS_RESULT { get; set; }
        public string UGSTARTIME { get; set; }
        public string UGPRENTIME { get; set; }
        public string UGPRODUCTIME { get; set; }
    }
}
