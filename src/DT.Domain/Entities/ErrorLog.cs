namespace DT.Domain.Entities;

public class ErrorLog
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime SDateTime { get; set; }
}
