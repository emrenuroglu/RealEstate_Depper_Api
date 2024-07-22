using RealEstate_Depper_Api.Dtos.PropertyAmenityDtos;

namespace RealEstate_Depper_Api.Repositories.PropertyAmenityRepositories
{
    public interface IPropertyAmenityRepository
    {
        Task<List<ResultPropertyAmenityByStatusTrueDto>> ResultPropertyAmenityByStatusTrue(int id);
    }

}
