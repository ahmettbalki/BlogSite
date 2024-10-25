namespace BlogSite.Models.Dtos.Category.Requests;
public sealed record UpdatePostRequest(
    Guid Id,
    string Title,
    string Content);