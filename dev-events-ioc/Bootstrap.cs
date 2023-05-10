using AutoMapper;
using dev_events_domain.Interfaces;
using dev_events_repository.Repository;
using dev_events_repository.Repository.UnitOfWork;
using dev_events_service.ExternalServices.Cep.Service;
using dev_events_service.Interface;
using dev_events_service.Mapping;
using dev_events_service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using System.Data;
using System.Data.Common;

namespace dev_events_ioc
{
    public static class Bootstrap
    {
        public static IServiceCollection RegisterService(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Service
            services.AddScoped<IPatrocinadorService, PatrocinadorService>();
            services.AddScoped<ICepService, CepService>();

            //Repository
            services.AddScoped<IPatrocinadorRepository, PatrocinadorRepository>();

            //ExternalService
            services.AddScoped<ICepExternalService, CepExternalService>();

            //Postgres
            services.AddTransient<DbConnection>((sp) => new NpgsqlConnection("connectionString"));

            //services.AddScoped<DbConnection>(provider =>
            //{
            //    return new NpgsqlConnection("connectionString");
            //});
            //Automapper
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }
    }
}
