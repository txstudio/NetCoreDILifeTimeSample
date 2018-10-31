using System;
using System.Threading;
using System.Threading.Tasks;

namespace AppRunner
{
    public sealed class App
    {
        private readonly Nullable<DateTime> _eventDateTime;

        public App()
        {
            this._eventDateTime = DateTime.Now;
        }

        public async Task Run(int providerCount, int serviceCount)
        {
            Console.Write("ProviderCount:{0}\tServiceCount:{1}\t"
                            , providerCount
                            , serviceCount);

            Console.Write("EventDateTime");

            if (this._eventDateTime.HasValue == true)
            {
                Console.WriteLine(":{0:HH:mm:ss}"
                                    , this._eventDateTime.Value);
            }
            else
            {
                Console.WriteLine(" is null");
            }

            Thread.Sleep(1000);

            await Task.CompletedTask;
        }
    }
}
