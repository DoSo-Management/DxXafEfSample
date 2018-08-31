using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using MySolution.Api.App_Start;
using MySolution.D2.Data;
using MySolution.Service;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.WebApi;
using System;
using System.Configuration;
using System.Web;
using System.Web.Http;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(NinjectWebCommon), "Stop")]


namespace MySolution.Api.App_Start
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            RegisterServices(kernel);
            return kernel;
        }

        private static void RegisterServices(IKernel kernel)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Model4"].ConnectionString;
            kernel.Bind<Model1>().ToSelf().WithConstructorArgument("connectionString", connectionString); ;
            kernel.Bind<IEmployeeRepository>().To<EmployeeRepository>();
        }
    }
}