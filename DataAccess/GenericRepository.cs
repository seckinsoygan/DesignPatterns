using DataAccess.Concrete;

namespace DataAccess
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
	{
		private readonly AppDbContext _context;
		public GenericRepository(AppDbContext context)
		{
			_context = context;
		}

		public void Add(T entity)
		{
			_context.Add(entity);
		}

		public void Delete(T entity)
		{
			_context.Remove(entity);
		}

		public T Get(int id)
		{
			return _context.Set<T>().Find(id);
		}

		public IQueryable<T> GetAll()
		{
			return _context.Set<T>().AsQueryable();
		}

		public void Update(T entity)
		{
			_context.Update(entity);
		}
	}
}
