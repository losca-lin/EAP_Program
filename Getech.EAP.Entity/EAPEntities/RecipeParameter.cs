using System;
using System.Collections.Generic;

namespace Getech.EAP.Entity
{
    public class RecipeParameterObject
    {
        public RecipeParameterObject() { }
        public string MachineID { get; set; }
        public string MachindeMode { get; set; }
        public string MachineStatus { get; set; }
        public string PPID { get; set; }
        public string PPVer { get; set; }

    }
    public class RecipeparameterInfo
    {
        public string SubRPID { get; set; }
        public List<RecipeparameterItem> RecipeParameterItemList { get; set; }
    }
    public class RecipeparameterItem
    {
        public string PARAMNAME { get; set; }
        public string PARAMVALUE { get; set; }
    }
}
