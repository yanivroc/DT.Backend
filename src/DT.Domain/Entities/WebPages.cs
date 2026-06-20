namespace DT.Domain.Entities;

public class WebPages
{
    public int Id { get; set; }
    public string PageTitle { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DateTime { get; set; }
    public string? SeoDescription { get; set; }
    public string? SeoKeywords { get; set; }
    public string PagePath { get; set; } = string.Empty;
    public int WebBuilderId { get; set; }
    public DateTime? ModifyDateTime { get; set; }
    public bool IsIndexable { get; set; }
    public string? PageUrl { get; set; }
    public bool IsInMenu { get; set; }
    public bool DisablePage { get; set; }
}
