using Dapper;
using RealEstate_Depper_Api.Dtos.CategoryDtos;
using RealEstate_Depper_Api.Models.DapperContext;

namespace RealEstate_Depper_Api.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async Task CreatCategory(CreateCategoryDto categoryDto)
        {
            string query = " insert into Category (CategoryName,CategoryStatus) values (@categoryName,@categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDto.CategoryName);
            parameters.Add("@categoryStatus", true);
            using(var connection= _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteCategory(int id)
        {
            string query = "Delete From Category Where CategoryID = @categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryID",id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResaultCategoryDto>> GetAllCategory()
        {
            string query = "Select * From Category";
            using (var connection = _context.CreateConnection())
            {
                var values  = await connection.QueryAsync<ResaultCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDCategoryDto> GetCategory(int id)
        {
            string query = "Select * From Category Where CategoryID=@CategoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDCategoryDto>(query, parameters);
                return values;
            }
        }


        public async Task UpdateCategory(UpdateCategoryDto categoryDto)
        {
            string query = "Update Category set CategoryName=@categoryName,CategoryStatus=@categoryStatus where CategoryID=@categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName",categoryDto.CategoryName);
            parameters.Add("@categoryStatus",categoryDto.CategoryStatus);
            parameters.Add("@categoryID", categoryDto.CategoryID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }

        }
    }
}
