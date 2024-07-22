using RealEstate_Depper_Api.Dtos.ServiceDtos;

namespace RealEstate_Depper_Api.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        Task CreateService(CreateServiceDto createServiceDto);
        Task DeleteService(int id);
        Task UpdateService(UpdateServiceDto updateServiceDto);
        Task<GetByIDServiceDto> GetService(int id);
    }
}

