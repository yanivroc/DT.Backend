namespace DT.Domain.Entities;

public class Countries
{
    public int Id { get; set; }
    public string CountryName { get; set; } = string.Empty;
    public string Currency { get; set; } = string.Empty;
    public string CountryCode { get; set; } = string.Empty;
    public string DateFormat { get; set; } = string.Empty;
    public string Culture { get; set; } = string.Empty;
    public string Flag { get; set; } = string.Empty;
    public bool IsPublic { get; set; }
    public string? SouthwestBounds { get; set; }
    public string? NortheastBounds { get; set; }
    public string? LatLng { get; set; }
    public string? CountryISO { get; set; }
}
