namespace DesktopApp;

public class PaymentModel
{
    public int PaymentId { get; set; }
    public int OrderId { get; set; }
    public decimal Amount { get; set; }
    public string PaymentMethod { get; set; }
    public string TransactionId { get; set; }
    public string Status { get; set; }
}