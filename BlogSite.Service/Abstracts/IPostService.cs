using BlogSite.Models.Dtos.Post.Requests;
using BlogSite.Models.Dtos.Post.Responses;
using BlogSite.Models.Entities;
namespace BlogSite.Service.Abstracts;
public interface IPostService
{
    List<PostResponseDto> GetAll();
    PostResponseDto? GetById(Guid id);
    Post Add(CreatePostRequest create);
}
