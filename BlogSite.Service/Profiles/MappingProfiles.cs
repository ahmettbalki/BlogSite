using AutoMapper;
using BlogSite.Models.Dtos.Post.Requests;
using BlogSite.Models.Entities;
namespace BlogSite.Service.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreatePostRequest, Post>();
    }
}