using movies.api.Models.DTOs.Movie;

namespace movies.api.Services.Interfaces
{
	public interface IMovieService
	{
		Task<IEnumerable<MovieCatalogResponseDto>> GetMoviesCatalogWithMetadata();
		Task<MovieResponseDto>? GetMovieWithMetadata(int movieId);
	}
}
