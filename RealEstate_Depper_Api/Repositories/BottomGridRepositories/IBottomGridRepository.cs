using RealEstate_Depper_Api.Dtos.BottomGridDtos;

namespace RealEstate_Depper_Api.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {
        Task<List<ResultbottomGridDto>> GetAllBottomGridAsync();
        Task CreateBottomGrid(CreatBottomGridDto createBottomGridDto);
        Task DeleteBottomGrid(int id);
        Task UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
        Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}
