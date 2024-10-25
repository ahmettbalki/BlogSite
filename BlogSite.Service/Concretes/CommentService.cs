using AutoMapper;
using BlogSite.DataAccess.Abstracts;
using BlogSite.Models.Dtos.Comment.Requests;
using BlogSite.Models.Dtos.Comment.Responses;
using BlogSite.Models.Entities;
using BlogSite.Service.Abstracts;
using Core.Responses;
namespace BlogSite.Service.Concretes;
public class CommentService : ICommentService
{
    private readonly ICommentRepository _commentRepository;
    private readonly IMapper _mapper;

    public CommentService(ICommentRepository commentRepository, IMapper mapper)
    {
        _commentRepository = commentRepository;
        _mapper = mapper;
    }

    public ReturnModel<CommentResponseDto> Add(CreateCommentRequest create)
    {
        var createdComment = _mapper.Map<Comment>(create);
        createdComment.Id = Guid.NewGuid();
        _commentRepository.Add(createdComment);
        var response = _mapper.Map<CommentResponseDto>(createdComment);
        return new ReturnModel<CommentResponseDto>
        {
            Data = response,
            Message = "Post Eklendi.",
            StatusCode = 200,
            Success = true
        };
    }
    public ReturnModel<CommentResponseDto> Remove(Guid id)
    {
        throw new NotImplementedException();
    }
    public ReturnModel<List<CommentResponseDto>> GetAll()
    {
        List<Comment> comments = _commentRepository.GetAll();
        List<CommentResponseDto> responses = _mapper.Map<List<CommentResponseDto>>(comments);
        return new ReturnModel<List<CommentResponseDto>>
        {
            Data = responses,
            Message = string.Empty,
            StatusCode = 200,
            Success = true
        };
    }
    public ReturnModel<CommentResponseDto?> GetById(Guid id)
    {
        var comment = _commentRepository.GetById(id);
        var response = _mapper.Map<CommentResponseDto?>(comment);
        return new ReturnModel<CommentResponseDto?>
        {
            Data = response,
            Message = string.Empty,
            StatusCode = 200,
            Success = true
        };
    }
    public ReturnModel<CommentResponseDto> Update(UpdateCommentRequest update)
    {
        throw new NotImplementedException();
    }
}
