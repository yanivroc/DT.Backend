namespace DT.Application.Dtos;

public class WebBuildersDto
{
    public int Id { get; set; }
    public string WebTitle { get; set; } = string.Empty;
    public DateTime DateTime { get; set; }
    public int MemberMemberId { get; set; }
    public bool Enabled { get; set; }
    public DateTime? ModifiedDateTime { get; set; }
    public bool ShowSocialShare { get; set; }
    public string? DomainName { get; set; }
    public string? Description { get; set; }
    public string? EmailId { get; set; }
    public string? LogoImage { get; set; }
    public string? LogoFavicon { get; set; }
    public string? MenuItems { get; set; }
    public string? ForeColor { get; set; }
    public string? BackColor { get; set; }
    public string? FontFamily { get; set; }
    public string? DemoDomainName { get; set; }
    public string? WebDisplayPath { get; set; }
}

public class CreateWebBuildersDto
{
    public string WebTitle { get; set; } = string.Empty;
    public DateTime DateTime { get; set; }
    public int MemberMemberId { get; set; }
    public bool Enabled { get; set; }
    public DateTime? ModifiedDateTime { get; set; }
    public bool ShowSocialShare { get; set; }
    public string? DomainName { get; set; }
    public string? Description { get; set; }
    public string? EmailId { get; set; }
    public string? LogoImage { get; set; }
    public string? LogoFavicon { get; set; }
    public string? MenuItems { get; set; }
    public string? ForeColor { get; set; }
    public string? BackColor { get; set; }
    public string? FontFamily { get; set; }
    public string? DemoDomainName { get; set; }
    public string? WebDisplayPath { get; set; }
}

public class UpdateWebBuildersDto
{
    public int Id { get; set; }
    public string WebTitle { get; set; } = string.Empty;
    public DateTime DateTime { get; set; }
    public int MemberMemberId { get; set; }
    public bool Enabled { get; set; }
    public DateTime? ModifiedDateTime { get; set; }
    public bool ShowSocialShare { get; set; }
    public string? DomainName { get; set; }
    public string? Description { get; set; }
    public string? EmailId { get; set; }
    public string? LogoImage { get; set; }
    public string? LogoFavicon { get; set; }
    public string? MenuItems { get; set; }
    public string? ForeColor { get; set; }
    public string? BackColor { get; set; }
    public string? FontFamily { get; set; }
    public string? DemoDomainName { get; set; }
    public string? WebDisplayPath { get; set; }
}
