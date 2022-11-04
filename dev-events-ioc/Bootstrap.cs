using Microsoft.Extensions.DependencyInjection;
using System;

namespace dev_events_ioc
{
    public static class Bootstrap
    {
        public static ServiceProvider ServiceProvider { get; private set; }

        public static void RegisterService(IServiceCollection services)
        {


            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
