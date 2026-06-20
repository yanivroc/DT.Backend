namespace DT.Application.Dtos;

public class BizTypesDto
{
    public int Id { get; set; }
    public string Type { get; set; } = string.Empty;
    public int? MemberId { get; set; }
}

public class CreateBizTypesDto
{
    public string Type { get; set; } = string.Empty;
    public int? MemberId { get; set; }
}

public class UpdateBizTypesDto
{
    public int Id { get; set; }
    public string Type { get; set; } = string.Empty;
    public int? MemberId { get; set; }
}
