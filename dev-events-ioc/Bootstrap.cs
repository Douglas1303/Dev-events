using dev_events_domain.Interfaces;
using dev_events_repository.Repository;
using dev_events_repository.Repository.UnitOfWork;
using dev_events_service.ExternalServices.Cep.Service;
using dev_events_service.Interface;
using dev_events_service.Mapping;
using dev_events_service.Service;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using System.Data;

namespace dev_events_ioc
{
    public static class Bootstrap
    {
        public static IServiceCollection RegisterService(this IServiceCollection services)
        {
            //Service
            services.AddScoped<IPatrocinadorService, PatrocinadorService>();
            services.AddScoped<ICepService, CepService>();

            //Repository
            services.AddScoped<IPatrocinadorRepository, PatrocinadorRepository>();

            //ExternalService
            services.AddScoped<ICepExternalService, CepExternalService>();

            //Postgres
            services.AddTransient<IDbConnection>((sp) => new NpgsqlConnection("connectionString"));

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
