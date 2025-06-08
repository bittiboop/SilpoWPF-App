namespace DesktopApp;

public class CategoryModel
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public int? ParentCategoryId { get; set; }
    public CategoryModel ParentCategory { get; set; }
    public List<CategoryModel> Products { get; set; } = new List<CategoryModel>();
}