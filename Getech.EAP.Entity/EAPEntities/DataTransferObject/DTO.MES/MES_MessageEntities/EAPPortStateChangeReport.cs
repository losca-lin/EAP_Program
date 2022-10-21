using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.MES_MessageEntities
{
    [Serializable]
    [XmlRoot("BODY")]
    public class EAPPortStateChangeReport
    {
        /// <summary>
        public string EQPID {get;set;}

        public string PORTID {get;set;}
        public string PORTSTATE { get; set; }
        /// [LR:LoadRequest，LC:LoadComplete，UR:UnloadRequest]
        public string CARRIERID { get; set; }
        /// </载具ID>
        public string CARRIERTYPE { get; set; }
        /// </载具类型>
        public string MATERIALBASEID { get; set; }
        /// </料座ID>
        public string TARGETTANKSTATE { get;set;}
        /// FULL/EMPTY, (LoadRequest时，FULL叫料满水箱，EMPTY叫料空水箱 <summary>

        //料框ID Add by lb 220930

        public string FRAMENAME { get; set; }

    }
}
