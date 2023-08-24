namespace DesignPattern.Composite.DAL
{
	public class Category
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public List<Product> Products { get; set; }
		public int UpperCategoryId { get; set; }
	}
}
