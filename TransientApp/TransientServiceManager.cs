using AppRunner;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace TransientApp
{
    internal class TransientServiceManager : ServiceManager
    {
        protected override void ConfigurationServices(IServiceCollection services)
        {
            base.ConfigurationServices(services);

            Console.WriteLine("AddTransient");
            services.AddTransient<App>();
        }
    }
}
