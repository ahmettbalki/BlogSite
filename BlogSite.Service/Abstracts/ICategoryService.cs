using BlogSite.Models.Dtos.Category.Responses;
using BlogSite.Models.Dtos.Category.Requests;
using Core.Responses;
namespace BlogSite.Service.Abstracts;
public interface ICategoryService
{
    ReturnModel<List<CategoryResponseDto>> GetAll();
    ReturnModel<CategoryResponseDto?> GetById(int id);
    ReturnModel<CategoryResponseDto> Add(CreateCategoryRequest create);
    ReturnModel<CategoryResponseDto> Update(UpdateCategoryRequest update);
    ReturnModel<CategoryResponseDto> Remove(int id);
}