using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.DataReportDTO
{
    public class PlcDataInfo
    {
        public string name { get; set; }
        public List<PlcDataItem> PlcdataItemlist { get; set; }

    }
}
