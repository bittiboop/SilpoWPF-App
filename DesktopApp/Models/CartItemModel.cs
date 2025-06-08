namespace DesktopApp;

public class CartItemModel
{
    public int CartItemId { get; set; }
    public int CartId { get; set; }
    public int ProductId { get; set; }
    public ProductModel Product { get; set; }
    public int Quantity { get; set; }
}