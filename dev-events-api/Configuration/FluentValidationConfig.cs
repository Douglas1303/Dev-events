using dev_events_service.Validator;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace dev_events_api.Configuration;

public static class FluentValidationConfig
{
    public static void AddFluentValidationConfiguration(this IServiceCollection services)
    {
        services.AddFluentValidationAutoValidation();
        services.AddFluentValidationClientsideAdapters();
        services.AddValidatorsFromAssemblyContaining<AddPatrocinadorVmValidator>();
    }
}
