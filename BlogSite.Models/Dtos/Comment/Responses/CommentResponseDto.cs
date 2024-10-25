namespace BlogSite.Models.Dtos.Comment.Responses;
public sealed record CommentResponseDto
{
    public Guid Id { get; set; }
    public string Text { get; set; }
    public DateTime CreatedDate { get; init; }
    public string UserName { get; init; }
    public string Post { get; set; }
}