using BlogSite.Models.Dtos.Post.Requests;
using BlogSite.Service.Abstracts;
using Microsoft.AspNetCore.Mvc;
namespace BlogSite.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PostsController(IPostService postService) : ControllerBase
{
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = postService.GetAll();
        return Ok(result);
    }
    [HttpPost("add")]
    public IActionResult Add([FromBody] CreatePostRequest dto)
    {
        var result = postService.Add(dto);
        return Ok(result);
    }
}
