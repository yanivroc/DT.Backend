namespace DT.Application.Dtos;

public class MemberProofsDto
{
    public int Id { get; set; }
    public int MemberId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Details { get; set; } = string.Empty;
    public DateTime CreateDateTime { get; set; }
    public string FilePath { get; set; } = string.Empty;
    public bool IsValidated { get; set; }
    public DateTime? ValidationDateTime { get; set; }
    public int? ValidatedMemberId { get; set; }
}

public class CreateMemberProofsDto
{
    public int MemberId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Details { get; set; } = string.Empty;
    public DateTime CreateDateTime { get; set; }
    public string FilePath { get; set; } = string.Empty;
    public bool IsValidated { get; set; }
    public DateTime? ValidationDateTime { get; set; }
    public int? ValidatedMemberId { get; set; }
}

public class UpdateMemberProofsDto
{
    public int Id { get; set; }
    public int MemberId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Details { get; set; } = string.Empty;
    public DateTime CreateDateTime { get; set; }
    public string FilePath { get; set; } = string.Empty;
    public bool IsValidated { get; set; }
    public DateTime? ValidationDateTime { get; set; }
    public int? ValidatedMemberId { get; set; }
}
