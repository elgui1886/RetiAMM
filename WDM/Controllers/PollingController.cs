using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WDM.Controllers
{
    public class PollingController : Controller
    {
        //
        // GET: /Polling/

        public ActionResult MDMClient()
        {
            return View();
        }

    }
}
