namespace DT.Application.Dtos;

public class VideosDto
{
    public int VideoId { get; set; }
    public string VideoPath { get; set; } = string.Empty;
    public string? VideoDescription { get; set; }
    public int VideoType { get; set; }
    public int DisplayOrder { get; set; }
    public DateTime CreateDateTime { get; set; }
    public DateTime? UpdateDateTime { get; set; }
    public string? VideoUrl { get; set; }
}

public class CreateVideosDto
{
    public string VideoPath { get; set; } = string.Empty;
    public string? VideoDescription { get; set; }
    public int VideoType { get; set; }
    public int DisplayOrder { get; set; }
    public DateTime CreateDateTime { get; set; }
    public DateTime? UpdateDateTime { get; set; }
    public string? VideoUrl { get; set; }
}

public class UpdateVideosDto
{
    public int VideoId { get; set; }
    public string VideoPath { get; set; } = string.Empty;
    public string? VideoDescription { get; set; }
    public int VideoType { get; set; }
    public int DisplayOrder { get; set; }
    public DateTime CreateDateTime { get; set; }
    public DateTime? UpdateDateTime { get; set; }
    public string? VideoUrl { get; set; }
}
