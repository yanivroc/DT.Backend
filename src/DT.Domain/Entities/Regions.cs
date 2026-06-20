namespace DT.Domain.Entities;

public class Regions
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? StateId { get; set; }
}
