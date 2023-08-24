using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
	public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
	{
		public EfCategoryDal(AppDbContext context) : base(context)
		{
		}
	}
}
