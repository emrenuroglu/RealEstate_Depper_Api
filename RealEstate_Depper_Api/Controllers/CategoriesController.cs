﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Depper_Api.Dtos.CategoryDtos;
using RealEstate_Depper_Api.Repositories.CategoryRepository;
namespace RealEstate_Depper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryRepository.GetAllCategory();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreatCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryRepository.CreatCategory(createCategoryDto);
            return Ok("Kategori Başarılı Bir Şekilde Eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult>DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
            return Ok("Kategori Başarılı Bir Şekilde Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryRepository.UpdateCategory(updateCategoryDto);
            return Ok("Kategori Başarılı Bir Şekilde Güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var value = await _categoryRepository.GetCategory(id);
            return Ok(value);
        }



    }
}