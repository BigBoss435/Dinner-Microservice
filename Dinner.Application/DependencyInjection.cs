
using Dinner.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Dinner.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}