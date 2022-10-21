using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.DataReportDTO
{
    public class DailyDataInfo
    {
        public string SUBMACHINEID { get; set; }
        public List<DailyDataItem> DATALIST { get; set; }
    }
}
