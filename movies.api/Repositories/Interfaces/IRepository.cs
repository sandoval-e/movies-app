namespace movies.api.Repositories.Interfaces
{
	public interface IRepository<T> where T : class
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
		Task AddAsync(T entity);
		Task SaveAsync();
		void Update(T entity);
		void Remove(T entity);

	}
}
