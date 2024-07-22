﻿using Dapper;
using RealEstate_Depper_Api.Dtos.ProductImageDtos;
using RealEstate_Depper_Api.Models.DapperContext;

namespace RealEstate_Depper_Api.Repositories.ProductImageRepositories
{
    public class ProductImageRepository:IProductImageRepository
    {
        private readonly Context _context;
        public ProductImageRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<GetProductImageByProductIdDto>> GetProductImageByProductId(int id)
        {
            string query = "Select * From ProductImages Where ProductID=@ProductID";
            var parameters = new DynamicParameters();
            parameters.Add("@ProductID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<GetProductImageByProductIdDto>(query, parameters);
                return values.ToList();
            }
        }

    }
}
