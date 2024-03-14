using Foodle.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Foodle.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IauthenticationService, AuthenticationService>();
        return services;
    }
}