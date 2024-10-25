using BlogSite.Models.Dtos.Category.Requests;
using BlogSite.Service.Abstracts;
using Microsoft.AspNetCore.Mvc;
namespace BlogSite.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoriesController(ICategoryService categoryService) : ControllerBase
{
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = categoryService.GetAll();
        return Ok(result);
    }
    [HttpPost("add")]
    public IActionResult Add([FromBody] CreateCategoryRequest dto)
    {
        var result = categoryService.Add(dto);
        return Ok(result);
    }
    [HttpGet("getbyid/{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var result = categoryService.GetById(id);
        return Ok(result);
    }
    [HttpDelete("delete")]
    public IActionResult Delete([FromQuery] int id)
    {
        var result = categoryService.Remove(id);
        return Ok(result);
    }
    [HttpPut("update")]
    public IActionResult Update([FromBody] UpdateCategoryRequest dto)
    {
        var result = categoryService.Update(dto);
        return Ok(result);
    }
}