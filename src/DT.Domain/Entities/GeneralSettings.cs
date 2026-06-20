namespace DT.Domain.Entities;

public class GeneralSettings
{
    public int Id { get; set; }
    public string MailDomain { get; set; } = string.Empty;
    public string MailId { get; set; } = string.Empty;
    public string MailPassword { get; set; } = string.Empty;
    public int? MailIdPort { get; set; }
    public string MobileList { get; set; } = string.Empty;
    public int CountryId { get; set; }
    public int? WebBuilderId { get; set; }
    public int? ZoneId { get; set; }
    public int? RegionId { get; set; }
    public string? LogoPath { get; set; }
    public string? StateLabel { get; set; }
    public string? RegionLabel { get; set; }
    public string? PostcodeLabel { get; set; }
    public int SeoDayNumber { get; set; }
    public string? GoogleTrackCode { get; set; }
    public int? StateId { get; set; }
    public string FolderName { get; set; } = string.Empty;
    public bool EnableChat { get; set; }
    public string ChatScript { get; set; } = string.Empty;
    public string? Cordinates { get; set; }
}
