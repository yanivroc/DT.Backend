namespace DT.Application.Dtos;

public class UserAgentsDto
{
    public int Id { get; set; }
    public string Agent { get; set; } = string.Empty;
}

public class CreateUserAgentsDto
{
    public string Agent { get; set; } = string.Empty;
}

public class UpdateUserAgentsDto
{
    public int Id { get; set; }
    public string Agent { get; set; } = string.Empty;
}
