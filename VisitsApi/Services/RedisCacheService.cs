using System.Text.Json;
using StackExchange.Redis;

namespace VisitsApi.Services;

public class RedisCacheService : ICacheService
{
    private const string RedisPrefix = "VisitsService";
    private readonly IConnectionMultiplexer _connectionMultiplexer;

    public RedisCacheService(IConnectionMultiplexer connectionMultiplexer)
    {
        _connectionMultiplexer = connectionMultiplexer;
    }

    private string GetKey(string key)
    {
        return $"{RedisPrefix}_{key}";
    }

    public async Task<T?> GetRecordAsync<T>(string key)
    {
        var db = _connectionMultiplexer.GetDatabase();

        string value = await db.StringGetAsync(GetKey(key));

        return value is null ? default : JsonSerializer.Deserialize<T>(value);
    }

    public async Task SetRecordAsync<T>(string key, T record)
    {
        var value = JsonSerializer.Serialize(record);
        var db = _connectionMultiplexer.GetDatabase();

        await db.StringSetAsync(GetKey(key), value);
    }
}
