namespace DesktopApp;

public class ProductModel
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsOnSale { get; set; }
    public decimal Price { get; set; }
    public decimal DiscountPrice { get; set; }
    public int CategoryTypeId { get; set; }
    public string ImageUrl { get; set; }
    public string CategoryTypeName { get; set; }
    public CategoryModel Category { get; set; }
}