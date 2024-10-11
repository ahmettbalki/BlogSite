namespace BlogSite.Models.Dtos.Post.Requests;
public sealed record CreatePostRequest(
    string Title,
    string Content);