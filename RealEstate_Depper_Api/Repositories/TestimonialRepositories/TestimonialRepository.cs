using Dapper;
using RealEstate_Depper_Api.Dtos.TestimonialDtos;
using RealEstate_Depper_Api.Models.DapperContext;

namespace RealEstate_Depper_Api.Repositories.TestimonialRepository
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly Context _context;
        public TestimonialRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultTestimonialDto>> GetAllTestimonialAsync()
        {
            string query = "Select * From Testimonial";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultTestimonialDto>(query);
                return values.ToList();
            }

        }
    }
}
