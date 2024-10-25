namespace BlogSite.Models.Dtos.Comment.Requests;
public sealed record UpdateCommentRequest(
    Guid Id,
    string Text);