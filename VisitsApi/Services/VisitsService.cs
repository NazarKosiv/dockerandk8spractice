namespace VisitsApi.Services;

public class VisitsService : IVisitsService
{
    private const string VisitsKey = "visitsCounter";
    private readonly ICacheService _cacheService;

    public VisitsService(ICacheService cacheService)
    {
        _cacheService = cacheService;
    }

    public async Task IncrementVisits()
    {
        var visits = await _cacheService.GetRecordAsync<int>(VisitsKey);
        await _cacheService.SetRecordAsync(VisitsKey, visits + 1);
    }

    public async Task<int> GetVisits()
    {
        return await _cacheService.GetRecordAsync<int>(VisitsKey);
    }
}
