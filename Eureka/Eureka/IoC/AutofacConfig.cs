using Autofac;
using Autofac.Integration.Mvc;
using Eureka.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eureka.IoC
{
    public static class AutofacConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            //Registra os controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);


            builder.RegisterType<MyDatabase>().AsSelf().InstancePerLifetimeScope();


            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}