namespace DT.Domain.Entities;

public class MemberOrders
{
    public int OrderId { get; set; }
    public int BizId { get; set; }
    public int UserId { get; set; }
    public decimal? Price { get; set; }
    public decimal Quantity { get; set; }
    public decimal? ShippingPrice { get; set; }
    public decimal Total { get; set; }
    public DateTime CreateDateTime { get; set; }
    public bool IsShipped { get; set; }
    public DateTime? ShippedDateTime { get; set; }
    public string? Notes { get; set; }
    public int InvoiceId { get; set; }
    public bool ShipToStore { get; set; }
    public bool IsRefunded { get; set; }
    public DateTime? RefundDateTime { get; set; }
    public string RefundNotes { get; set; } = string.Empty;
}
