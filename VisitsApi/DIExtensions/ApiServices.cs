using VisitsApi.Services;

namespace VisitsApi.DIExtensions;

public static class ApiServices
{
    public static IServiceCollection AddApiServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IVisitsService, VisitsService>();
        return serviceCollection;
    }
}