namespace VisitsApi.Services;

public interface ICacheService
{
    Task<T?> GetRecordAsync<T>(string key);
    Task SetRecordAsync<T>(string key, T record);
}
