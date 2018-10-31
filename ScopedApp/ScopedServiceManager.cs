using AppRunner;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ScopedApp
{
    internal class ScopedServiceManager : ServiceManager
    {
        protected override void ConfigurationServices(IServiceCollection services)
        {
            base.ConfigurationServices(services);

            Console.WriteLine("AddScoped");
            services.AddScoped<App>();
        }
    }
}