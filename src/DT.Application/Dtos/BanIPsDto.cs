namespace DT.Application.Dtos;

public class BanIPsDto
{
    public int Id { get; set; }
    public string IPAddress { get; set; } = string.Empty;
}

public class CreateBanIPsDto
{
    public string IPAddress { get; set; } = string.Empty;
}

public class UpdateBanIPsDto
{
    public int Id { get; set; }
    public string IPAddress { get; set; } = string.Empty;
}
