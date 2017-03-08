using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MDMWCFService.Models
{
    [DataContract]
    public class Utenza
    {
        [DataMember]
        public string CodiceAzienda { get; set; }

        [DataMember]
        public string CodiceUtente { get; set; }
    }
}