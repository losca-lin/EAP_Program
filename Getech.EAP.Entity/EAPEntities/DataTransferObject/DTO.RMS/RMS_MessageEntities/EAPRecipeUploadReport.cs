using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.RMS_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPRecipeUploadReport
    {
        /// <summary>
        /// 
        /// </summary>
        public string RecipeID { get;set;}

        /// <summary>
        /// 
        /// </summary>
        public string RecipeVersion { get;set;}

        [XmlArray("PARAMETERLISTLIST")] 
        [XmlArrayItem("PARAMETERLIST")] 
        public List<PARAMETERLIST> PARAMETERLISTLIST { get; set; } 

    }
    public class PARAMETERLIST
    {
        /// <summary>
        /// 码垛PORT[1-20,21-24]
        /// </summary>
        public string ParameterName { get;set;}
        /// <summary>
        /// [Available，NotAvailable]
        /// </summary>
        public string Value { get;set;}
    }
}
