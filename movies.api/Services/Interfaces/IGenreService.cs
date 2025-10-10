using movies.api.Models.DTOs.Genre;

namespace movies.api.Services.Interfaces
{
	public interface IGenreService
	{
		Task<IEnumerable<GenreResponseDto>> GetAllGenresAsync();
		Task<GenreResponseDto> GetGenreByIdAsync(int id);
		Task AddGenreAsync(GenreCreateDto genre);
		Task UpdateGenreAsync(GenreUpdateDto genre);
		Task DeleteGenreAsync(int id);
	}
}
