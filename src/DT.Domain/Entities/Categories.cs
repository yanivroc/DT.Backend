namespace DT.Domain.Entities;

public class Categories
{
    public int CategoryId { get; set; }
    public string CategoryTitle { get; set; } = string.Empty;
    public int? MemberMemberId { get; set; }
    public string CategoryDisplayTitle { get; set; } = string.Empty;
    public DateTime CreateDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string ImagePath { get; set; } = string.Empty;
}
