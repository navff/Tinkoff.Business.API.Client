namespace TinkoffBusiness.Api.Client.Models;

public class Balance
{
    public Decimal Otb { get; set; }
    public Decimal Authorized { get; set; }
    public Decimal PendingPayments { get; set; }
    public Decimal PendingRequisitions { get; set; }
    
}