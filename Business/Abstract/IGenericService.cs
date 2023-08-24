﻿namespace Business.Abstract
{
	public interface IGenericService<T> where T : class
	{
		IQueryable<T> GetAll();
		T Get(int id);
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}
