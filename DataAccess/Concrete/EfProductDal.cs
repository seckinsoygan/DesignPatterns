using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
	public class EfProductDal : GenericRepository<Product>, IProductDal
	{
		public EfProductDal(AppDbContext context) : base(context)
		{
		}
	}
}
