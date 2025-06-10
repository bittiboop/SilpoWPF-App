namespace DesktopApp.Models;

public class CartItemModel
{
    public int ItemId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal DiscountPrice { get; set; }
    public int ShoppingCartModelId { get; set; }
    public ShoppingCartModel ShoppingCart { get; set; }
    public ProductModel Product { get; set; }
    
    
}