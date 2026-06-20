namespace DT.Domain.Entities;

public class Bizs
{
    public int BizId { get; set; }
    public string? BizName { get; set; }
    public string? BizDesc { get; set; }
    public string? BizAddress { get; set; }
    public string? BizSuburb { get; set; }
    public string? BizPostCode { get; set; }
    public string? BizLandLine { get; set; }
    public string? BizFaxNumber { get; set; }
    public string? BizMobilePhone { get; set; }
    public string? BizEmail { get; set; }
    public string? BizWeb { get; set; }
    public string? BizLat { get; set; }
    public string? BizLong { get; set; }
    public bool BizEnable { get; set; }
    public DateTime? CreateDateTime { get; set; }
    public DateTime? ModifyDateTime { get; set; }
    public int? MemberMemberId { get; set; }
    public string? BizDisplayTitle { get; set; }
    public int BizPostType { get; set; }
    public bool ShowMaps { get; set; }
    public bool BizPublic { get; set; }
    public bool BizLock { get; set; }
    public int? StateId { get; set; }
    public int? RegionId { get; set; }
    public string? MetaDesc { get; set; }
    public string? MetaKey { get; set; }
    public string? BizCustomTitle { get; set; }
}
