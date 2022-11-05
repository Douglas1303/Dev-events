using dev_events_service.Validator;
using FluentValidation.AspNetCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;
using System.Text.Json.Serialization;

namespace dev_events_api.Configuration;

public static class FluentValidationConfig
{
    public static void AddFluentValidationConfiguration(this IServiceCollection services)
    {
        services.AddControllers()
            .AddNewtonsoftJson(x =>
            {
                x.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                x.SerializerSettings.Converters.Add(new StringEnumConverter());
            })
            .AddJsonOptions(p => p.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()))
            .AddFluentValidation(p =>
            {
                p.RegisterValidatorsFromAssemblyContaining<AddPatrocinadorViewModelValidator>();
                p.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");
            });
    }
}
