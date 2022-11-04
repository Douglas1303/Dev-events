using dev_events_service.ExternalServices.Cep.Service;
using dev_events_service.Interface;
using dev_events_service.Mapping;
using dev_events_service.Service;
using Microsoft.Extensions.DependencyInjection;

namespace dev_events_ioc
{
    public static class Bootstrap
    {
        public static IServiceCollection RegisterService(this IServiceCollection services)
        {
            services.AddScoped<ICepService, CepService>();

            //ExternalService
            services.AddScoped<ICepExternalService, CepExternalService>();

            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
