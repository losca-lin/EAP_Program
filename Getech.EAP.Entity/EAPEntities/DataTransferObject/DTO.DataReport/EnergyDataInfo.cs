using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.DataReportDTO
{
    public class EnergyDataInfo
    {
        public string SUBMACHINEID { get; set; }
        public List<EnergyDataItem> DATALIST { get; set; }
    }
}
