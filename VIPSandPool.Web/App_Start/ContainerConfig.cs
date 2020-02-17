using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using VIPSandPool.Data.Services;

namespace VIPSandPool.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguratiom)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<SqlVirtualServerData>()
                   .As<IVirtualServerData>()
                   .InstancePerRequest();
            builder.RegisterType<VIPSandPoolDbContext>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            httpConfiguratiom.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}