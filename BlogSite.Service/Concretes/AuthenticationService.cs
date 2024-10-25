using BlogSite.Models.Dtos.Tokens.Responses;
using BlogSite.Models.Dtos.Users.Requests;
using BlogSite.Service.Abstracts;
using Core.Responses;
namespace BlogSite.Service.Concretes;
public class AuthenticationService(IUserService userService, IJwtService jwtService) : IAuthenticationService
{
    public async Task<ReturnModel<TokenResponseDto>> LoginAsync(LoginRequestDto dto)
    {
        var user = await userService.LoginAsync(dto);
        var tokenResponse = jwtService.CreateJwtToken(user);
        return new ReturnModel<TokenResponseDto>
        {
            Data = tokenResponse,
            Message = "Giriş başarılı",
            StatusCode = 200,
            Success = true
        };
    }
    public async Task<ReturnModel<TokenResponseDto>> RegisterAsync(RegisterRequestDto dto)
    {
        var user = await userService.RegisterAsync(dto);
        var tokenResponse = jwtService.CreateJwtToken(user);
        return new ReturnModel<TokenResponseDto>
        {
            Data = tokenResponse,
            Message = "Kayıt başarılı",
            StatusCode = 200,
            Success = true
        };
    }
}
