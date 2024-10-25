using BlogSite.Models.Dtos.Users.Requests;
using BlogSite.Service.Abstracts;
using Microsoft.AspNetCore.Mvc;
namespace BlogSite.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthenticationsController(IAuthenticationService authenticationService) : ControllerBase
{
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody]LoginRequestDto dto)
    {
        var result = await authenticationService.LoginAsync(dto);
        return Ok(result);
    }
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody]RegisterRequestDto dto)
    {
        var result = await authenticationService.RegisterAsync(dto);
        return Ok(result);
    }
}
