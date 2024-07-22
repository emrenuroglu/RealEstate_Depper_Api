using RealEstate_Depper_Api.Dtos.AppUserDtos;

namespace RealEstate_Depper_Api.Repositories.AppUserRepositories
{
    public interface IAppUserRepository
    {
        Task<GetAppUserByProductIdDto> GetAppUserByProductId(int id);

    }
}
