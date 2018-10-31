using AppRunner;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace SingletonApp
{
    /*
     * 使用 AddSingleton 方法注入
     *      注入的物件只會在生命週期中初始化一次
     */
    class Program
    {
        static async Task Main(string[] args)
        {
            ServiceManager _manager;
            ServiceProvider _serviceProvider;

            _manager = new SingletonServiceManager();
            _serviceProvider = _manager.ServiceProvider;

            int _provider_count = 3;
            int _service_count = 3;

            for (int i = 0; i < _provider_count; i++)
            {
                for (int j = 0; j < _service_count; j++)
                {
                    await _serviceProvider.GetService<App>().Run(i, j);
                }
            }

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
