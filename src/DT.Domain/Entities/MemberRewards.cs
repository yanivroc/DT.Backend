namespace DT.Domain.Entities;

public class MemberRewards
{
    public int Id { get; set; }
    public double Val { get; set; }
    public string Uid { get; set; } = string.Empty;
    public int App { get; set; }
    public string TypeVal { get; set; } = string.Empty;
    public string Tx { get; set; } = string.Empty;
    public double Raw { get; set; }
    public int Rat { get; set; }
    public string Net { get; set; } = string.Empty;
    public int Loi { get; set; }
    public string Evt { get; set; } = string.Empty;
    public string Cat { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Reason { get; set; } = string.Empty;
    public string Trace { get; set; } = string.Empty;
    public string Hash { get; set; } = string.Empty;
    public DateTime CreateDateTime { get; set; }
    public string CompleteUrl { get; set; } = string.Empty;
    public int MemberId { get; set; }
    public bool IsConsumed { get; set; }
    public DateTime? ConsumedDateTime { get; set; }
}
