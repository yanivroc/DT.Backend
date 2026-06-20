namespace DT.Application.Dtos;

public class StatesDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int CountryId { get; set; }
}

public class CreateStatesDto
{
    public string Name { get; set; } = string.Empty;
    public int CountryId { get; set; }
}

public class UpdateStatesDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int CountryId { get; set; }
}
