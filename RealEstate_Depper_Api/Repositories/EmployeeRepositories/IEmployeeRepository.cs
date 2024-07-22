using RealEstate_Depper_Api.Dtos.CategoryDtos;
using RealEstate_Depper_Api.Dtos.EmployeeDtos;

namespace RealEstate_Depper_Api.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
        Task CreateEmployee(CreateEmployeeDto createEmployeeDto);
        Task DeleteEmployee(int id);
        Task UpdateEmployee(UpdateEmployeeDto updateEmployeeDto);
        Task<GetbyIDEmployeeDto> GetEmployee(int id);
    }
}
