using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDMWCFService.Models
{
    public class RealTimeInfo
    {
        public String CodiceUtenza { get; set; }

        public double Pressione { get; set; }

        public double Portata { get; set; }

        public double SetPoint { get; set; }

        public List<String> Allarmi { get; set; }

        public String TimeStamp { get; set; }
    }

}