using AppRunner;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace ScopedApp
{
    /*
     * 使用 AddScoped 方法注入
     *      在每次的 Scope 階段中物件並不會被重新初始化
     *      ASP.NET Core WebApplication 中 Scoped 定義為每一次的 Request
     */
    class Program
    {

        static async Task Main(string[] args)
        {
            ServiceManager _manager;
            ServiceProvider _serviceProvider;

            _manager = new ScopedServiceManager();
            _serviceProvider = _manager.ServiceProvider;

            int _provider_count = 3;
            int _service_count = 3;

            for (int i = 0; i < _provider_count; i++)
            {
                Console.WriteLine("Scope 1");
                using (var _scope = _serviceProvider.CreateScope())
                {
                    for (int j = 0; j < _service_count; j++)
                    {
                        await _scope.ServiceProvider.GetService<App>().Run(i, j);
                    }
                }

                Console.WriteLine("Scope 2");
                using (var _scope = _serviceProvider.CreateScope())
                {
                    for (int j = 0; j < _service_count; j++)
                    {
                        await _scope.ServiceProvider.GetService<App>().Run(i, j);
                    }
                }
            }

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
