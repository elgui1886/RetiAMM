using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Timers;
using MDMWCFService.Models;

namespace MDMWCFService.Hubs
{
    public class MDMHub : Hub
    {
        //L'hub riceve le connessione dagli altri client

        static Timer _timer;


        //constructor
        public MDMHub()
        {
            _timer = new Timer(3000); //imposto il timer a 3 secondi
            _timer.Elapsed += _timer_Elapsed;
            _timer.Enabled = true;
        }

        void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            RealTimeInfo info = new RealTimeInfo();
            info.CodiceUtenza = "1234";
            info.Portata = 1213.14;
            info.Pressione = 2133.44;
            info.SetPoint = 6544.323;
            info.Allarmi = new List<string>() { "muffa", "aiuto", "aaaa" };
            info.TimeStamp = DateTime.Now.ToLongTimeString();


            //Attualmente il nostro hub (se non modifico il webConfig, puo ricevere connessioni solo IntraDomani e non ExtraDomain. 
            //ToAdd -> Policy core
            Clients.All.notifyme(info);
        }

        public void Hello()
        {
            Clients.All.hello();
        }
    }
}