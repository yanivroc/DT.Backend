namespace DT.Domain.Entities;

public class TimeZone
{
    public int Id { get; set; }
    public string Zone { get; set; } = string.Empty;
    public int? CountryId { get; set; }
}
