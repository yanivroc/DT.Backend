namespace DT.Application.Dtos;

public class RegionsDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? StateId { get; set; }
}

public class CreateRegionsDto
{
    public string Name { get; set; } = string.Empty;
    public int? StateId { get; set; }
}

public class UpdateRegionsDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? StateId { get; set; }
}
