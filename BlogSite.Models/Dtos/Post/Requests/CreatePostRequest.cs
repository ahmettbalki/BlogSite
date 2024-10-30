namespace BlogSite.Models.Dtos.Category.Requests;
public sealed record CreatePostRequest(
    string Title,
    string Content,
    int CategoryId);