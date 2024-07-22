using RealEstate_Depper_Api.Dtos.ChartDto;

namespace RealEstate_Depper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories
{
    public interface IChartRepository
    {
        Task<List<ResultChartDto>> Get5CityForChart();
    }
}
