using AutoMapper;
using BlogSite.DataAccess.Abstracts;
using BlogSite.Models.Dtos.Category.Requests;
using BlogSite.Models.Dtos.Category.Responses;
using BlogSite.Models.Entities;
using BlogSite.Service.Abstracts;
using Core.Responses;
namespace BlogSite.Service.Concretes;
public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }
    public ReturnModel<CategoryResponseDto> Add(CreateCategoryRequest create)
    {
        var createdCategory = _mapper.Map<Category>(create);
        _categoryRepository.Add(createdCategory);
        var response = _mapper.Map<CategoryResponseDto>(createdCategory);
        return new ReturnModel<CategoryResponseDto>
        {
            Data = response,
            Message = "Post Eklendi.",
            StatusCode = 200,
            Success = true
        };
    }
    public ReturnModel<CategoryResponseDto> Remove(int id)
    {
        throw new NotImplementedException();
    }
    public ReturnModel<List<CategoryResponseDto>> GetAll()
    {
        List<Category> categories = _categoryRepository.GetAll();
        List<CategoryResponseDto> responses = _mapper.Map<List<CategoryResponseDto>>(categories);
        return new ReturnModel<List<CategoryResponseDto>>
        {
            Data = responses,
            Message = string.Empty,
            StatusCode = 200,
            Success = true
        };
    }
    public ReturnModel<CategoryResponseDto?> GetById(int id)
    {
        var category = _categoryRepository.GetById(id);
        var response = _mapper.Map<CategoryResponseDto?>(category);
        return new ReturnModel<CategoryResponseDto?>
        {
            Data = response,
            Message = string.Empty,
            StatusCode = 200,
            Success = true
        };
    }
    public ReturnModel<CategoryResponseDto> Update(UpdateCategoryRequest update)
    {
        throw new NotImplementedException();
    }
}