using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Depper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;

namespace RealEstate_Depper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentLastProductController : ControllerBase
    {
        private readonly ILast5ProductsRepository _lastProductRepository;
        public EstateAgentLastProductController(ILast5ProductsRepository lastProductRepository)
        {
            _lastProductRepository = lastProductRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetLast5ProductAsync(int id)
        {
            var values = await _lastProductRepository.GetLast5ProductAsync(id);
            return Ok(values);
        }

    }
}
