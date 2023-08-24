using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class ProductManager : IProductService
	{
		private readonly IProductDal productDal;

		public ProductManager(IProductDal productDal)
		{
			this.productDal = productDal;
		}

		public void Add(Product entity)
		{
			productDal.Add(entity);
		}

		public void Delete(Product entity)
		{
			productDal.Delete(entity);
		}

		public Product Get(int id)
		{
			return productDal.Get(id);
		}

		public IQueryable<Product> GetAll()
		{
			return productDal.GetAll();
		}

		public void Update(Product entity)
		{
			productDal.Update(entity);
		}
	}
}
