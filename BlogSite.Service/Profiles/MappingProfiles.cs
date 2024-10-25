using AutoMapper;
using BlogSite.Models.Dtos.Category.Requests;
using BlogSite.Models.Dtos.Category.Responses;
using BlogSite.Models.Dtos.Comment.Requests;
using BlogSite.Models.Dtos.Comment.Responses;
using BlogSite.Models.Entities;
namespace BlogSite.Service.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreatePostRequest, Post>();
        CreateMap<UpdatePostRequest, Post>();
        CreateMap<Post, PostResponseDto>()
            .ForMember(x => x.Category, opt => opt.MapFrom(x => x.Category.Name));

        CreateMap<CreateCategoryRequest, Category>();
        CreateMap<UpdateCategoryRequest, Category>();
        CreateMap<Category, CategoryResponseDto>();

        CreateMap<CreateCommentRequest, Comment>();
        CreateMap<UpdateCommentRequest, Comment>();
        CreateMap<Comment, CommentResponseDto>()
            .ForMember(x => x.Post, opt => opt.MapFrom(x => x.Post.Title))
            .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.User.FirstName));
    }
}