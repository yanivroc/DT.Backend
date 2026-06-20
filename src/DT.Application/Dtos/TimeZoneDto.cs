namespace DT.Application.Dtos;

public class TimeZoneDto
{
    public int Id { get; set; }
    public string Zone { get; set; } = string.Empty;
    public int? CountryId { get; set; }
}

public class CreateTimeZoneDto
{
    public string Zone { get; set; } = string.Empty;
    public int? CountryId { get; set; }
}

public class UpdateTimeZoneDto
{
    public int Id { get; set; }
    public string Zone { get; set; } = string.Empty;
    public int? CountryId { get; set; }
}
