using Dinner.Api.Common.Errors;
using Dinner.Api.Common.Mapping;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Dinner.Api;

public static class DependencyInjection 
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, DinnerProblemDetailsFactory>();
        services.AddMappings();
        return services;
    }
}