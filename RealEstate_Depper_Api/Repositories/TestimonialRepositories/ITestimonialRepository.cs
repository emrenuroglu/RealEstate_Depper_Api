using RealEstate_Depper_Api.Dtos.TestimonialDtos;

namespace RealEstate_Depper_Api.Repositories.TestimonialRepository
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
    }
}
