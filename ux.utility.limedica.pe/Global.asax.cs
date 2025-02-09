using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ux.utility.limedica.pe
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
     
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            string logPath = Server.MapPath("~/Logs/miapp.log");
            FileInfo logFileInfo = new FileInfo(logPath);

            // Verifica si la carpeta existe, si no la crea
            if (!logFileInfo.Directory.Exists)
            {
                logFileInfo.Directory.Create();
            }

            // Configura log4net con la ruta correcta
            XmlConfigurator.Configure();

        }
    }
}
