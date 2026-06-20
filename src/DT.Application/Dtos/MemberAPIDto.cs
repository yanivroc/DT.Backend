namespace DT.Application.Dtos;

public class MemberAPIDto
{
    public int Id { get; set; }
    public string APIKey { get; set; } = string.Empty;
    public string APISecret { get; set; } = string.Empty;
    public string APIType { get; set; } = string.Empty;
    public bool APIStatus { get; set; }
    public DateTime APIDateTime { get; set; }
    public DateTime? APIUpdateDateTime { get; set; }
    public int MemberId { get; set; }
}

public class CreateMemberAPIDto
{
    public string APIKey { get; set; } = string.Empty;
    public string APISecret { get; set; } = string.Empty;
    public string APIType { get; set; } = string.Empty;
    public bool APIStatus { get; set; }
    public DateTime APIDateTime { get; set; }
    public DateTime? APIUpdateDateTime { get; set; }
    public int MemberId { get; set; }
}

public class UpdateMemberAPIDto
{
    public int Id { get; set; }
    public string APIKey { get; set; } = string.Empty;
    public string APISecret { get; set; } = string.Empty;
    public string APIType { get; set; } = string.Empty;
    public bool APIStatus { get; set; }
    public DateTime APIDateTime { get; set; }
    public DateTime? APIUpdateDateTime { get; set; }
    public int MemberId { get; set; }
}
