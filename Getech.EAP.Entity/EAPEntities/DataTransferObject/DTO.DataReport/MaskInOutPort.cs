using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.DataReportDTO
{
    public class MaskInOutPort
    {
        public string MACHINEID { get; set; }
        public string UNITID { get; set; }
        public string INOUTPUT_SLOTNO { get; set; }
        public string CSTSEQ { get; set; }
        public string SLOT { get; set; }
        public string MASKID { get; set; }
        public string MASKSPECNAME { get; set; }
        public string MASKGROUPNAME { get; set; }
        public string PPID { get; set; }
        public string MASKCLEANSTATE { get; set; }
        public string MATERIAL_TYPE { get; set; }
        public string MATERIAL_THICKNESS { get; set; }
        public string PROCESSING_COUNT { get; set; }
        public string REMAIN_COUNT { get; set; }
        public string LIMIT_COUNT { get; set; }
        public string MATERIAL_JUDGE { get; set; }
        public string LOADING_CHAMBERID { get; set; }
        public string MASK_OFFSETX { get; set; }
        public string MASK_OFFSETY { get; set; }
        public string MASK_OFFSETT { get; set; }
        public string TIME { get; set; }
    }
}
