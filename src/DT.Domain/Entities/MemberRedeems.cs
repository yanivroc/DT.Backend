namespace DT.Domain.Entities;

public class MemberRedeems
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
