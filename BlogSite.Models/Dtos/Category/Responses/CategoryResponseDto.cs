namespace BlogSite.Models.Dtos.Category.Responses;
public sealed record CategoryResponseDto
{
    public int Id { get; init; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; init; }

}