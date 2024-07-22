using RealEstate_Depper_Api.Dtos.SubFeatureDtos;

namespace RealEstate_Depper_Api.Repositories.SubFeatureRepositories
{
    public interface ISubFeatureRepository
    {
        Task<List<ResultSubFeatureDto>> GetAllSubFeatureAsync();
    }
}
