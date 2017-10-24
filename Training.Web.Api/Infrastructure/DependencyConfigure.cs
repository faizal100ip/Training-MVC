using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Configuration;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Integration.WebApi;
using System.Web.Mvc;
using Training.Data;
using Training.Services.Customers;
using System.Web.Http;

namespace Training.Web.Api.Infrastructure
{
    /// <summary>
    /// Dependency registrar
    /// </summary>
    internal class DependencyConfigure
    {
        public static void Initialize()
        {
            var builder = new ContainerBuilder();
            var container = RegisterServices(builder);
            DependencyResolver.SetResolver(
                new Dependency(container)
                );

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);

        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());


            builder.RegisterType<DataContext>().As<IDbContext>().InstancePerDependency();
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();


            //Register Services
            builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerLifetimeScope();


            return builder.Build();
        }
    }
}
