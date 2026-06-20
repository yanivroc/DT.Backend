namespace DT.Domain.Entities;

public class MemberReferals
{
    public int Id { get; set; }
    public int MemberId { get; set; }
    public int? ReferMemberId { get; set; }
    public DateTime? ReferDateTime { get; set; }
}
