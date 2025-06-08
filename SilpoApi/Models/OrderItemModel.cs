namespace DesktopApp;

public class OrderItemModel
{
    public int OrderItemId { get; set; }
    public int OrderId { get; set; }
    public OrderModel Order { get; set; }
    public int ProductId { get; set; }
    public ProductModel Product { get; set; }
    public int Quantity { get; set; }
    
}