namespace DT.Application.Dtos;

public class ErrorLogDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime SDateTime { get; set; }
}

public class CreateErrorLogDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime SDateTime { get; set; }
}

public class UpdateErrorLogDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime SDateTime { get; set; }
}
