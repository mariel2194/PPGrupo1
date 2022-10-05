using PPGrupo1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PPGrupo1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer<FacturacionProdDbContext>(new System.Data.Entity.DropCreateDatabaseIfModelChanges<FacturacionProdDbContext>());
            //Database.SetInitializer<ClientesProdDbContext>(new System.Data.Entity.DropCreateDatabaseIfModelChanges<ClientesProdDbContext>());
            //use this when you need to restore the dbcontext and add new columns or constraints
        }
    }
}


