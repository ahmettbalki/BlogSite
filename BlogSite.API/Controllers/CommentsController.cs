using BlogSite.Models.Dtos.Comment.Requests;
using BlogSite.Service.Abstracts;
using Microsoft.AspNetCore.Mvc;
namespace BlogSite.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CommentsController(ICommentService commentService) : ControllerBase
{
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = commentService.GetAll();
        return Ok(result);
    }
    [HttpPost("add")]
    public IActionResult Add([FromBody] CreateCommentRequest dto)
    {
        var result = commentService.Add(dto);
        return Ok(result);
    }
    [HttpGet("getbyid/{id}")]
    public IActionResult GetById([FromRoute] Guid id)
    {
        var result = commentService.GetById(id);
        return Ok(result);
    }
    [HttpDelete("delete")]
    public IActionResult Delete([FromQuery] Guid id)
    {
        var result = commentService.Remove(id);
        return Ok(result);
    }
    [HttpPut("update")]
    public IActionResult Update([FromBody] UpdateCommentRequest dto)
    {
        var result = commentService.Update(dto);
        return Ok(result);
    }
}
