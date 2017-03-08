using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Cors;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(MDMWCFService.Startup))]

namespace MDMWCFService
{
    //Owin da la possibilita di astrarre il comportamento di un WebService (puo girare su IIS ma anche su altri Web server Owin compatibile) 
    //Owin è per le web application
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            app.Map("/signalr", map =>
            {
                map.UseCors(CorsOptions.AllowAll);
                var hubConfiguration = new HubConfiguration { };

                map.RunSignalR(hubConfiguration);
            });
        }
    }
}