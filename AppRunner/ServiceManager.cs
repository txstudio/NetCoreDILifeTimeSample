using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppRunner
{
    public abstract class ServiceManager
    {
        private readonly ServiceCollection _services;

        public ServiceManager()
        {
            this._services = new ServiceCollection();

            this.ConfigurationServices(_services);
        }

        protected virtual void ConfigurationServices(IServiceCollection services)
        {
            services.AddOptions();
        }

        public ServiceProvider ServiceProvider
        {
            get
            {
                return this._services.BuildServiceProvider();
            }
        }
    }
}
