﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.DataReportDTO
{
    public class DailyDataObject
    {
        public DailyDataObject() { }
        public string SUBCD { get; set; }
        public string MachineMode { get; set; }
        public string MachineStatus { get; set; }
    }
}
