namespace DataAccess
{
	public interface IGenericRepository<T>
	{
		IQueryable<T> GetAll();
		T Get(int id);
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);

	}
}
