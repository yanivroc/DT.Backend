namespace DT.Domain.Entities;

public class BizTypes
{
    public int Id { get; set; }
    public string Type { get; set; } = string.Empty;
    public int? MemberId { get; set; }
}
