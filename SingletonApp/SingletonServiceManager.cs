using AppRunner;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SingletonApp
{
    internal class SingletonServiceManager : ServiceManager
    {
        protected override void ConfigurationServices(IServiceCollection services)
        {
            base.ConfigurationServices(services);

            Console.WriteLine("AddSingleton");
            services.AddSingleton<App>();
        }
    }
}