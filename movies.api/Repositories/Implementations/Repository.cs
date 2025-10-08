using Microsoft.EntityFrameworkCore;
using movies.api.DAL;
using movies.api.Repositories.Interfaces;

namespace movies.api.Repositories.Implementations
{
	public class Repository<T> : IRepository<T> where T : class
	{
		protected readonly AppDbContext _dbContext;
		private readonly DbSet<T> _dbSet;
		public Repository(AppDbContext dbContext)
		{
			_dbContext = dbContext;
			_dbSet = dbContext.Set<T>();
		}
		public async Task AddAsync(T entity)
		{
			await _dbSet.AddAsync(entity);
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<T> GetByIdAsync(int id)
		{
			return await _dbSet.FindAsync(id);
		}

		public async Task SaveAsync()
		{
			await _dbContext.SaveChangesAsync();
		}

		public void Remove(T entity)
		{
			_dbSet.Remove(entity);
		}

		public void Update(T entity)
		{
			_dbSet.Update(entity);
		}
	}
}
