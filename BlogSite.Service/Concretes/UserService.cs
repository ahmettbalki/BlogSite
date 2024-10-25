using BlogSite.Models.Dtos.Users.Requests;
using BlogSite.Models.Entities;
using BlogSite.Service.Abstracts;
using Core.Exceptions;
using Microsoft.AspNetCore.Identity;
namespace BlogSite.Service.Concretes;
public class UserService(UserManager<User> userManager) : IUserService
{
    public async Task<User> ChangePasswordAsync(string id, ChangePasswordRequestDto requestDto)
    {
        var user = await userManager.FindByIdAsync(id);
        if (user is null)
        {
            throw new NotFoundException("Kullanıcı bulunamadı");
        }
        if(requestDto.NewPassword.Equals(requestDto.NewPasswordAgain) is false)
        {
            throw new BusinessException("Parola Uyuşmuyor");
        }
        var result = await userManager.ChangePasswordAsync(user, requestDto.CurrentPassword, requestDto.NewPassword);
        if(result.Succeeded is false)
        {
            throw new BusinessException(result.Errors.ToList().First().Description);
        }
        return user;
    }
    public async Task<string> DeleteAsync(string id)
    {
        var user = await userManager.FindByIdAsync(id);
        if(user is null)
        {
            throw new NotFoundException("Kullanıcı bulunamadı");
        }
        var result = await userManager.DeleteAsync(user);
        if(result.Succeeded is false)
        {
            throw new BusinessException(result.Errors.ToList().First().Description);
        }
        return "Kullanıcı silindi.";
    }
    public async Task<User> GetByEmailAsync(string email)
    {
        var user = await userManager.FindByEmailAsync(email);
        if (user is null)
        {
            throw new NotFoundException("Kullanıcı bulunamadı");
        }
        return user;
    }
    public async Task<User> LoginAsync(LoginRequestDto dto)
    {
        var user = await userManager.FindByEmailAsync(dto.Email);
        if (user is null)
        {
            throw new NotFoundException("Kullanıcı bulunamadı");
        }
        bool checkPassword = await userManager.CheckPasswordAsync(user ,dto.Password);
        if (checkPassword is false)
        {
            throw new BusinessException("Parolanız yanlış");
        }
        return user;
    }
    public async Task<User> RegisterAsync(RegisterRequestDto dto)
    {
        var user = new User
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email,
            City = dto.City,
            UserName = dto.Username,
        };
        var result = await userManager.CreateAsync(user, dto.Password);
        if (!result.Succeeded)
        {
            throw new BusinessException(result.Errors.ToList().First().Description);
        }
        return user;
    }
    public async Task<User> UpdateAsync(string id, UserUpdateRequestDto dto)
    {
        var user = await userManager.FindByIdAsync(id);
        if (user is null)
        {
            throw new NotFoundException("Kullanıcı bulunamadı");
        }
        user.UserName = dto.Username;
        user.FirstName = dto.FirstName;
        user.LastName = dto.LastName;
        user.City = dto.City;
        var result = await userManager.UpdateAsync(user);
        if (result.Succeeded is false)
        {
            throw new BusinessException(result.Errors.ToList().First().Description);
        }
        return user;
    }
}