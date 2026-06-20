namespace DT.Application.Dtos;

public class MemberReferalsDto
{
    public int Id { get; set; }
    public int MemberId { get; set; }
    public int? ReferMemberId { get; set; }
    public DateTime? ReferDateTime { get; set; }
}

public class CreateMemberReferalsDto
{
    public int MemberId { get; set; }
    public int? ReferMemberId { get; set; }
    public DateTime? ReferDateTime { get; set; }
}

public class UpdateMemberReferalsDto
{
    public int Id { get; set; }
    public int MemberId { get; set; }
    public int? ReferMemberId { get; set; }
    public DateTime? ReferDateTime { get; set; }
}
