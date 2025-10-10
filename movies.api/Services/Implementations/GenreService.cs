using movies.api.Models.DTOs.Genre;
using movies.api.Models.Entities;
using movies.api.Repositories.Interfaces;
using movies.api.Services.Interfaces;

namespace movies.api.Services.Implementations
{
	public class GenreService : IGenreService
	{
		private readonly IRepository<Genre> _repository;

		public GenreService(IRepository<Genre> repository)
		{
			_repository = repository;
		}

		public async Task<IEnumerable<GenreResponseDto>> GetAllGenresAsync()
		{
			var genres = await _repository.GetAllAsync();
			var result = genres.Select(x => new GenreResponseDto
			{
				Id = x.Id,
				Name = x.Name,
			});

			return result;
		}

		public async Task<GenreResponseDto> GetGenreByIdAsync(int id)
		{
			var genre = await _repository.GetByIdAsync(id);

			if (genre == null) return null;

			return new GenreResponseDto { Id = genre.Id, Name = genre.Name };
		}

		public async Task AddGenreAsync(GenreCreateDto genre)
		{
			var newGenre = new Genre()
			{
				Name = genre.Name,
			};

			await _repository.AddAsync(newGenre);
			await _repository.SaveAsync();
		}

		public async Task UpdateGenreAsync(GenreUpdateDto genre)
		{
			var updatedGenre = await _repository.GetByIdAsync(genre.Id);

			if(updatedGenre == null) return;

			updatedGenre.Name = genre.Name;
			_repository.Update(updatedGenre);
			await _repository.SaveAsync();
		}

		public async Task DeleteGenreAsync(int id)
		{
			var deletedGenre = await _repository.GetByIdAsync(id);

			if(deletedGenre != null)
			{
				_repository.Remove(deletedGenre);
				await _repository.SaveAsync();
			}
		}
	}
}
