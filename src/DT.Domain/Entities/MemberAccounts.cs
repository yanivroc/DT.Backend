namespace DT.Domain.Entities;

public class MemberAccounts
{
    public int Id { get; set; }
    public string AccountName { get; set; } = string.Empty;
    public string AccountNumber { get; set; } = string.Empty;
    public string AccountCode { get; set; } = string.Empty;
    public string? PayPalClientId { get; set; }
    public DateTime CreateDateTime { get; set; }
    public DateTime? UpdateDateTime { get; set; }
    public int MemberId { get; set; }
    public bool IsValid { get; set; }
    public DateTime? ValidationDateTime { get; set; }
}
