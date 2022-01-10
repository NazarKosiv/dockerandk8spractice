namespace VisitsApi.Services;

public interface IVisitsService
{
    Task IncrementVisits();
    Task<int> GetVisits();
}
