namespace BlogSite.Models.Dtos.Post.Responses;
public sealed record PostResponseDto(
    Guid Id,
    string Title,
    string Content,
    DateTime CreatedDate);
