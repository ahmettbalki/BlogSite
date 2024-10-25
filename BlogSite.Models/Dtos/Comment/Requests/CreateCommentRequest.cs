namespace BlogSite.Models.Dtos.Comment.Requests;
public sealed record CreateCommentRequest(
    string Text,
    long UserId,
    Guid PostId);