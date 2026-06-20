namespace DT.Application.Dtos;

public class MemberInvoicesDto
{
    public int InvoiceId { get; set; }
    public string InvoiceTitle { get; set; } = string.Empty;
    public string InvoicePath { get; set; } = string.Empty;
    public string InvoiceUrl { get; set; } = string.Empty;
    public decimal InvoiceAmount { get; set; }
    public int MemberId { get; set; }
    public int AdminId { get; set; }
    public DateTime AdminCreateDateTime { get; set; }
    public bool IsInvoicePaid { get; set; }
    public DateTime? PaidDateTime { get; set; }
    public int WebCount { get; set; }
    public int PostCount { get; set; }
    public int WebPageCount { get; set; }
    public int PaymentMode { get; set; }
    public string? Notes { get; set; }
    public decimal? SubTotal { get; set; }
    public decimal? Delivery { get; set; }
    public bool? IsDelivered { get; set; }
    public DateTime? DeliverdDateTime { get; set; }
}

public class CreateMemberInvoicesDto
{
    public string InvoiceTitle { get; set; } = string.Empty;
    public string InvoicePath { get; set; } = string.Empty;
    public string InvoiceUrl { get; set; } = string.Empty;
    public decimal InvoiceAmount { get; set; }
    public int MemberId { get; set; }
    public int AdminId { get; set; }
    public DateTime AdminCreateDateTime { get; set; }
    public bool IsInvoicePaid { get; set; }
    public DateTime? PaidDateTime { get; set; }
    public int WebCount { get; set; }
    public int PostCount { get; set; }
    public int WebPageCount { get; set; }
    public int PaymentMode { get; set; }
    public string? Notes { get; set; }
    public decimal? SubTotal { get; set; }
    public decimal? Delivery { get; set; }
    public bool? IsDelivered { get; set; }
    public DateTime? DeliverdDateTime { get; set; }
}

public class UpdateMemberInvoicesDto
{
    public int InvoiceId { get; set; }
    public string InvoiceTitle { get; set; } = string.Empty;
    public string InvoicePath { get; set; } = string.Empty;
    public string InvoiceUrl { get; set; } = string.Empty;
    public decimal InvoiceAmount { get; set; }
    public int MemberId { get; set; }
    public int AdminId { get; set; }
    public DateTime AdminCreateDateTime { get; set; }
    public bool IsInvoicePaid { get; set; }
    public DateTime? PaidDateTime { get; set; }
    public int WebCount { get; set; }
    public int PostCount { get; set; }
    public int WebPageCount { get; set; }
    public int PaymentMode { get; set; }
    public string? Notes { get; set; }
    public decimal? SubTotal { get; set; }
    public decimal? Delivery { get; set; }
    public bool? IsDelivered { get; set; }
    public DateTime? DeliverdDateTime { get; set; }
}
