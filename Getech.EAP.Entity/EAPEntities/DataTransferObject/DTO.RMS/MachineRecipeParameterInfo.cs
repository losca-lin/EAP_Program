using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getech.EAP.Entity.RMSDTO
{
    public class MachineRecipeParameterInfo
    {
        public string MachineName { get; set; }
        public string RecipeID { get; set; }
        public string RecipeVersion { get; set; }
        public List<RecipeParameterInfo> ParameterList { get; set; }
    }
}
