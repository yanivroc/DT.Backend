namespace DT.Application.Dtos;

public class ContactsDto
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string? MobilePhone { get; set; }
    public string? Email { get; set; }
    public bool RecieveSms { get; set; }
    public bool RecieveEmail { get; set; }
    public int MemberMemberId { get; set; }
    public string? Source { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? ModifyDate { get; set; }
    public int? RegionId { get; set; }
    public int? StateId { get; set; }
    public int? CountryId { get; set; }
    public string? Notes { get; set; }
    public bool? IsOverseasContact { get; set; }
    public bool IsDeleted { get; set; }
}

public class CreateContactsDto
{
    public string FullName { get; set; } = string.Empty;
    public string? MobilePhone { get; set; }
    public string? Email { get; set; }
    public bool RecieveSms { get; set; }
    public bool RecieveEmail { get; set; }
    public int MemberMemberId { get; set; }
    public string? Source { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? ModifyDate { get; set; }
    public int? RegionId { get; set; }
    public int? StateId { get; set; }
    public int? CountryId { get; set; }
    public string? Notes { get; set; }
    public bool? IsOverseasContact { get; set; }
    public bool IsDeleted { get; set; }
}

public class UpdateContactsDto
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string? MobilePhone { get; set; }
    public string? Email { get; set; }
    public bool RecieveSms { get; set; }
    public bool RecieveEmail { get; set; }
    public int MemberMemberId { get; set; }
    public string? Source { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? ModifyDate { get; set; }
    public int? RegionId { get; set; }
    public int? StateId { get; set; }
    public int? CountryId { get; set; }
    public string? Notes { get; set; }
    public bool? IsOverseasContact { get; set; }
    public bool IsDeleted { get; set; }
}
