using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			this.categoryDal = categoryDal;
		}

		public void Add(Category entity)
		{
			categoryDal.Add(entity);
		}

		public void Delete(Category entity)
		{
			categoryDal.Delete(entity);
		}

		public Category Get(int id)
		{
			return categoryDal.Get(id);
		}

		public IQueryable<Category> GetAll()
		{
			return categoryDal.GetAll();
		}

		public void Update(Category entity)
		{
			categoryDal.Update(entity);
		}
	}
}
