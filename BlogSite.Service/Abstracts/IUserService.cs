using BlogSite.Models.Dtos.Users.Requests;
using BlogSite.Models.Entities;
namespace BlogSite.Service.Abstracts;
public interface IUserService
{
    Task<User> RegisterAsync(RegisterRequestDto dto);
    Task<User> LoginAsync(LoginRequestDto dto);
    Task<User> GetByEmailAsync(string email);
    Task<User> UpdateAsync(string id, UserUpdateRequestDto dto);
    Task<string> DeleteAsync(string id);
    Task<User> ChangePasswordAsync(string id, ChangePasswordRequestDto requestDto);
}