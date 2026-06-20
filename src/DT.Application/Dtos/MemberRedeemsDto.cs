namespace DT.Application.Dtos;

public class MemberRedeemsDto
{
    public int Id { get; set; }
    public int MemberId { get; set; }
    public DateTime RedeemDateTime { get; set; }
    public decimal RedeemAmount { get; set; }
    public string TransactionUrl { get; set; } = string.Empty;
    public string RedeemTitle { get; set; } = string.Empty;
    public bool IsValidated { get; set; }
    public DateTime? ValidationDateTime { get; set; }
    public int? ValidatedMemberId { get; set; }
    public string? RedeemType { get; set; }
}

public class CreateMemberRedeemsDto
{
    public int MemberId { get; set; }
    public DateTime RedeemDateTime { get; set; }
    public decimal RedeemAmount { get; set; }
    public string TransactionUrl { get; set; } = string.Empty;
    public string RedeemTitle { get; set; } = string.Empty;
    public bool IsValidated { get; set; }
    public DateTime? ValidationDateTime { get; set; }
    public int? ValidatedMemberId { get; set; }
    public string? RedeemType { get; set; }
}

public class UpdateMemberRedeemsDto
{
    public int Id { get; set; }
    public int MemberId { get; set; }
    public DateTime RedeemDateTime { get; set; }
    public decimal RedeemAmount { get; set; }
    public string TransactionUrl { get; set; } = string.Empty;
    public string RedeemTitle { get; set; } = string.Empty;
    public bool IsValidated { get; set; }
    public DateTime? ValidationDateTime { get; set; }
    public int? ValidatedMemberId { get; set; }
    public string? RedeemType { get; set; }
}
