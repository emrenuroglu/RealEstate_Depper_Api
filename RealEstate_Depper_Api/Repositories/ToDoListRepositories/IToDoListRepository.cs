using RealEstate_Depper_Api.Dtos.ToDoListDtos;

namespace RealEstate_Depper_Api.Repositories.ToDoListRepositories
{
    public interface IToDoListRepository
    {
        Task<List<ResultToDoListDto>> GetAllToDoList();
        Task CreateToDoList(CreateToDoListDto ToDoListDto);
        Task DeleteToDoList(int id);
        Task UpdateToDoList(UpdateToDoListDto ToDoListDto);
        Task<GetByIDToDoListDto> GetToDoList(int id);
    }
}
