using System.Text;

namespace DesignPattern.Composite.CompositePattern
{
	public class ProductComposite : IComponent
	{
		public ProductComposite(int id, string name)
		{
			Id = id;
			Name = name;
			components = new List<IComponent>();
		}

		public int Id { get; set; }
		public string Name { get; set; }
		private List<IComponent> components;
		public ICollection<IComponent> Components => components;
		public void Add(IComponent component)
		{
			components.Add(component);
		}

		public string Display()
		{
			var stringBuilder = new StringBuilder();
			stringBuilder.Append($"<div class='text-success'>{Name} ({TotalCount()})</div>");
			stringBuilder.Append("<ul class='list-group list-group-flash ms-2'>");
			foreach (var item in components)
			{
				stringBuilder.Append(item.Display());
			}
			stringBuilder.Append("</ul>");
			return stringBuilder.ToString();
		}

		public int TotalCount()
		{
			return components.Sum(x => x.TotalCount());
		}
	}
}
