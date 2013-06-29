using Microsoft.AspNet.SignalR;
using Owin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SignalRSelfHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HubConfiguration { EnableCrossDomain = true };
            app.MapHubs(config);
            string exeFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string webFolder = Path.Combine(exeFolder, "Web");
            app.UseStaticFiles(webFolder);
        }
    }
}
