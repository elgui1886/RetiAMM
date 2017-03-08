using MDMWCFService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MDMWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MDMService : IMDMService
    {
        public List<Utenza> ListaUtenze()
        {
            List<Utenza> fromDB = new List<Utenza>();
            fromDB.Add(new Utenza { CodiceAzienda = "189", CodiceUtente = "12345678909876" });
            fromDB.Add(new Utenza { CodiceAzienda = "334", CodiceUtente = "98765432101234" });
            return fromDB;

            //devi impostare il webConfig
                
        }


        public string Notify()
        {
            return "ok";
        }
    }
}
