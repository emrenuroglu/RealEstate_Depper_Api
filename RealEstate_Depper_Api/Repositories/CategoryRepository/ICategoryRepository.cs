using RealEstate_Depper_Api.Dtos;
using RealEstate_Depper_Api.Dtos.CategoryDtos;

namespace RealEstate_Depper_Api.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResaultCategoryDto>> GetAllCategory();
        Task CreatCategory(CreateCategoryDto categoryDto);
        Task DeleteCategory(int id );
        Task UpdateCategory(UpdateCategoryDto categoryDto);
        Task<GetByIDCategoryDto> GetCategory(int id);
    }
}
