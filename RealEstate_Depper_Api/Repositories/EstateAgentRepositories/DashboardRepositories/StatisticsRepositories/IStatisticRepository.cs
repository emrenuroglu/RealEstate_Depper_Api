namespace RealEstate_Depper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticsRepositories
{
    public interface IStatisticRepository
    {
        int ProductCountByEmployeeId(int id);
        int ProductCountByStatusTrue(int id);
        int ProductCountByStatusFalse(int id);
        int AllProductCount();
    }
}
