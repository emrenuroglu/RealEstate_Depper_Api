using RealEstate_Depper_Api.Dtos.ProductImageDtos;

namespace RealEstate_Depper_Api.Repositories.ProductImageRepositories
{
    public interface IProductImageRepository
    {
        Task<List<GetProductImageByProductIdDto>> GetProductImageByProductId(int id);
    }
}
