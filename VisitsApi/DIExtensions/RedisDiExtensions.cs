using StackExchange.Redis;
using VisitsApi.Constants;
using VisitsApi.Services;

namespace VisitsApi.DIExtensions;

public static class RedisDiExtensions
{
    public static IServiceCollection AddRedis(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        // Default port is 6379
        var redisConnectionString = configuration.GetValue<string>(nameof(ConfigurationTokens.RedisConnectionString));
        serviceCollection.AddSingleton<IConnectionMultiplexer>(
            x => ConnectionMultiplexer.Connect(redisConnectionString));
        serviceCollection.AddSingleton<ICacheService, RedisCacheService>();
        return serviceCollection;
    }
}
