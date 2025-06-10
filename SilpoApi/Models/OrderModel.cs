namespace DesktopApp.Models;

public class OrderModel
{
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public UserModel User { get; set; }
    public decimal Amount { get; set; }
    public string PaymentStatus { get; set; }
    public String OrderStatus { get; set; }
    public string ShippingAddress { get; set; }
    public List<OrderItemModel> OrderItems { get; set; }
}