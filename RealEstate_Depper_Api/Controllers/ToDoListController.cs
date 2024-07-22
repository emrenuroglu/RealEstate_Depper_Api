using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Depper_Api.Repositories.ToDoListRepositories;

namespace RealEstate_Depper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase

    {
        private readonly IToDoListRepository _ToDoListRepository;
        public ToDoListController(IToDoListRepository ToDoListRepository)
        {
            _ToDoListRepository = ToDoListRepository;
        }
        [HttpGet]
        public async Task<IActionResult> ToDoListList()
        {
            var values = await _ToDoListRepository.GetAllToDoList();
            return Ok(values);
        }


    }
}
