﻿using BlogSite.Models.Dtos.Category.Requests;
using BlogSite.Service.Abstracts;
using BlogSite.Service.Concretes;
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
    [HttpGet("getbyid/{id}")]
    public IActionResult GetById([FromRoute] Guid id)
    {
        var result = postService.GetById(id);
        return Ok(result);
    }
    [HttpDelete("delete")]
    public IActionResult Delete([FromQuery] Guid id)
    {
        var result = postService.Remove(id);
        return Ok(result);
    }
    [HttpPut("update")]
    public IActionResult Update([FromBody] UpdatePostRequest dto)
    {
        var result = postService.Update(dto);
        return Ok(result);
    }
}
