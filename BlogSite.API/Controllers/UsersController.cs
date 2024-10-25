using BlogSite.Models.Dtos.Users.Requests;
using BlogSite.Service.Abstracts;
using Microsoft.AspNetCore.Mvc;
namespace BlogSite.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsersController(IUserService userService) : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequestDto dto)
    {
        var result = await userService.RegisterAsync(dto);
        return Ok(result);
    }
    [HttpGet("getbyemail")]
    public async Task<IActionResult> GetByEmail(string email)
    {
        var result = await userService.GetByEmailAsync(email);
        return Ok(result);
    }
}