namespace DT.Application.Dtos;

public class MembersDto
{
    public int MemberId { get; set; }
    public string MemberFullName { get; set; } = string.Empty;
    public string MemberEmail { get; set; } = string.Empty;
    public string MemberPassword { get; set; } = string.Empty;
    public bool MemberEnable { get; set; }
    public DateTime? CreateDateTime { get; set; }
    public DateTime? ModifyDateTime { get; set; }
    public DateTime? DateofBirth { get; set; }
    public int MemberType { get; set; }
    public string? MemberDirectory { get; set; }
    public string? PrivateEmail { get; set; }
    public string? PrivateEmailPwd { get; set; }
    public string? PrivateEmailDomain { get; set; }
    public int? PrivateEmailPort { get; set; }
    public string? PrivateSmsNumber { get; set; }
    public string? PrivateSmsId { get; set; }
    public string? ProfilePicture { get; set; }
    public string? Description { get; set; }
    public string? Address { get; set; }
    public int? CountryId { get; set; }
    public int? StateId { get; set; }
    public int? RegionId { get; set; }
    public string? GoogleProfile { get; set; }
    public string? MemberDisplayPath { get; set; }
    public string? MobileNumber { get; set; }
    public string? LandLine { get; set; }
    public string? Suburb { get; set; }
    public string? PostCode { get; set; }
    public string? FacebookProfile { get; set; }
    public string? TwitterProfile { get; set; }
    public string? InstagramProfile { get; set; }
    public string? YoutubeProfile { get; set; }
    public string? LinkedinProfile { get; set; }
    public string? Website { get; set; }
    public int DiskSpace { get; set; }
    public bool IsPublic { get; set; }
    public string? ProfileThumbPicture { get; set; }
    public string MetaDesc { get; set; } = string.Empty;
    public string MetaKey { get; set; } = string.Empty;
    public string? BizLat { get; set; }
    public string? BizLong { get; set; }
    public int? ZoneId { get; set; }
    public string? CustomerName { get; set; }
    public bool Enable2fa { get; set; }
    public DateTime? Enable2faDateTime { get; set; }
    public string? TikTokProfile { get; set; }
    public string? SnapChatProfile { get; set; }
    public string? PinInterestProfile { get; set; }
    public string? RedditProfile { get; set; }
    public string? DiscordProfile { get; set; }
}

public class CreateMembersDto
{
    public string MemberFullName { get; set; } = string.Empty;
    public string MemberEmail { get; set; } = string.Empty;
    public string MemberPassword { get; set; } = string.Empty;
    public bool MemberEnable { get; set; }
    public DateTime? CreateDateTime { get; set; }
    public DateTime? ModifyDateTime { get; set; }
    public DateTime? DateofBirth { get; set; }
    public int MemberType { get; set; }
    public string? MemberDirectory { get; set; }
    public string? PrivateEmail { get; set; }
    public string? PrivateEmailPwd { get; set; }
    public string? PrivateEmailDomain { get; set; }
    public int? PrivateEmailPort { get; set; }
    public string? PrivateSmsNumber { get; set; }
    public string? PrivateSmsId { get; set; }
    public string? ProfilePicture { get; set; }
    public string? Description { get; set; }
    public string? Address { get; set; }
    public int? CountryId { get; set; }
    public int? StateId { get; set; }
    public int? RegionId { get; set; }
    public string? GoogleProfile { get; set; }
    public string? MemberDisplayPath { get; set; }
    public string? MobileNumber { get; set; }
    public string? LandLine { get; set; }
    public string? Suburb { get; set; }
    public string? PostCode { get; set; }
    public string? FacebookProfile { get; set; }
    public string? TwitterProfile { get; set; }
    public string? InstagramProfile { get; set; }
    public string? YoutubeProfile { get; set; }
    public string? LinkedinProfile { get; set; }
    public string? Website { get; set; }
    public int DiskSpace { get; set; }
    public bool IsPublic { get; set; }
    public string? ProfileThumbPicture { get; set; }
    public string MetaDesc { get; set; } = string.Empty;
    public string MetaKey { get; set; } = string.Empty;
    public string? BizLat { get; set; }
    public string? BizLong { get; set; }
    public int? ZoneId { get; set; }
    public string? CustomerName { get; set; }
    public bool Enable2fa { get; set; }
    public DateTime? Enable2faDateTime { get; set; }
    public string? TikTokProfile { get; set; }
    public string? SnapChatProfile { get; set; }
    public string? PinInterestProfile { get; set; }
    public string? RedditProfile { get; set; }
    public string? DiscordProfile { get; set; }
}

public class UpdateMembersDto
{
    public int MemberId { get; set; }
    public string MemberFullName { get; set; } = string.Empty;
    public string MemberEmail { get; set; } = string.Empty;
    public string MemberPassword { get; set; } = string.Empty;
    public bool MemberEnable { get; set; }
    public DateTime? CreateDateTime { get; set; }
    public DateTime? ModifyDateTime { get; set; }
    public DateTime? DateofBirth { get; set; }
    public int MemberType { get; set; }
    public string? MemberDirectory { get; set; }
    public string? PrivateEmail { get; set; }
    public string? PrivateEmailPwd { get; set; }
    public string? PrivateEmailDomain { get; set; }
    public int? PrivateEmailPort { get; set; }
    public string? PrivateSmsNumber { get; set; }
    public string? PrivateSmsId { get; set; }
    public string? ProfilePicture { get; set; }
    public string? Description { get; set; }
    public string? Address { get; set; }
    public int? CountryId { get; set; }
    public int? StateId { get; set; }
    public int? RegionId { get; set; }
    public string? GoogleProfile { get; set; }
    public string? MemberDisplayPath { get; set; }
    public string? MobileNumber { get; set; }
    public string? LandLine { get; set; }
    public string? Suburb { get; set; }
    public string? PostCode { get; set; }
    public string? FacebookProfile { get; set; }
    public string? TwitterProfile { get; set; }
    public string? InstagramProfile { get; set; }
    public string? YoutubeProfile { get; set; }
    public string? LinkedinProfile { get; set; }
    public string? Website { get; set; }
    public int DiskSpace { get; set; }
    public bool IsPublic { get; set; }
    public string? ProfileThumbPicture { get; set; }
    public string MetaDesc { get; set; } = string.Empty;
    public string MetaKey { get; set; } = string.Empty;
    public string? BizLat { get; set; }
    public string? BizLong { get; set; }
    public int? ZoneId { get; set; }
    public string? CustomerName { get; set; }
    public bool Enable2fa { get; set; }
    public DateTime? Enable2faDateTime { get; set; }
    public string? TikTokProfile { get; set; }
    public string? SnapChatProfile { get; set; }
    public string? PinInterestProfile { get; set; }
    public string? RedditProfile { get; set; }
    public string? DiscordProfile { get; set; }
}
