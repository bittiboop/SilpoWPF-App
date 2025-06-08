namespace DesktopApp;

public class ShoppingCartModel
{
    public int CartId { get; set; }
    public int UserId { get; set; }
    public UserModel User { get; set; }
    public List<CartItemModel> CartItems { get; set; } = new List<CartItemModel>();
    public decimal TotalPrice 
    { 
        get 
        {
            return CartItems.Sum(item => item.Product.Price * item.Quantity);
        } 
    }
}