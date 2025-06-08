namespace DesktopApp;

public class UserModel
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string PasswordHash { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<OrderModel> Orders { get; set; } = new List<OrderModel>();
    public ShoppingCartModel ShoppingCart { get; set; }
}