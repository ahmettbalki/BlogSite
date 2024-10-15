using BlogSite.Models.Dtos.Post.Requests;
using BlogSite.Models.Dtos.Post.Responses;
using BlogSite.Models.Entities;
using Core.Responses;
namespace BlogSite.Service.Abstracts;
public interface IPostService
{
    ReturnModel<List<PostResponseDto>> GetAll();
    ReturnModel<PostResponseDto?> GetById(Guid id);
    ReturnModel<PostResponseDto> Add(CreatePostRequest create);
}