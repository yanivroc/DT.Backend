namespace DT.Domain.Entities;

public class MemberAPI
{
    public int Id { get; set; }
    public string APIKey { get; set; } = string.Empty;
    public string APISecret { get; set; } = string.Empty;
    public string APIType { get; set; } = string.Empty;
    public bool APIStatus { get; set; }
    public DateTime APIDateTime { get; set; }
    public DateTime? APIUpdateDateTime { get; set; }
    public int MemberId { get; set; }
}
