using Microsoft.EntityFrameworkCore;
using movies.api.DAL;
using movies.api.Models.DTOs.Movie;
using movies.api.Models.Entities;
using movies.api.Services.Interfaces;

namespace movies.api.Services.Implementations
{
	public class MovieService : IMovieService
	{
		private readonly AppDbContext _dbContext;

		public MovieService(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<IEnumerable<MovieCatalogResponseDto>> GetMoviesCatalogWithMetadata()
		{
			List<Movie>? movies = await _dbContext.Movies
										 .Include(m => m.MovieRatings)
										 .Include(m => m.MovieGenres)
											.ThenInclude(mg => mg.Genre)
										 .ToListAsync();

			List<MovieCatalogResponseDto>? movieCatalog = movies.Select(movie =>
			{
				double averageRating = movie.MovieRatings.Any() ? movie.MovieRatings.Average(mv => mv.Score) : 0;
				List<string>? genreNames = movie.MovieGenres.Select(mg => mg.Genre.Name).Distinct().ToList();

				return new MovieCatalogResponseDto
				{
					MovieId = movie.Id,
					Title = movie.Title,
					Description = movie.Description,
					PictureUrl = movie.PictureUrl,
					ReleaseDate = movie.ReleaseDate,
					AverageRating = Math.Round(averageRating, 2),
					Genres = genreNames
				};
			}).ToList();

			return movieCatalog;
		}

		public async Task<MovieResponseDto> GetMovieWithMetadata(int movieId)
		{
			var movie = await _dbContext.Movies
								.Include(m => m.MovieGenres)
								.ThenInclude(mg => mg.Genre)
								.Include(m => m.MovieActors)
								.ThenInclude(ma => ma.Actor)
								.Include(m => m.MovieRatings)
								.ThenInclude(mr => mr.User)
								.FirstOrDefaultAsync(m => m.Id == movieId);
			if (movie == null)
			{
				return null;
			}

			var genres = movie.MovieGenres.Select(mg => mg.Genre.Name)
										  .Distinct()
										  .ToList();

			var actors = movie.MovieActors.Select(ma => new ActorInfo
			{
				ActorName = ma.Actor?.FullName ?? "Unknown",
				PictureUrl = ma.Actor?.PictureUrl ?? string.Empty
			}).ToList();

			var averageRating = movie.MovieRatings.Any() ? movie.MovieRatings.Average(mr => mr.Score) : 0;

			var individualRatings = movie.MovieRatings.Select(mr => new IndividualRating
			{
				Score = mr.Score,
				Comment = mr.Comment ?? string.Empty,
				Username = mr.User?.UserName ?? string.Empty
			}).ToList();

			var ratingInfo = new RatingInfo
			{
				AverageRating = Math.Round(averageRating, 2),
				IndividualRatings = individualRatings,
			};

			return new MovieResponseDto
			{
				MovieId = movie.Id,
				Title = movie.Title,
				Description = movie.Description,
				PictureUrl = movie.PictureUrl,
				ReleaseDate = movie.ReleaseDate,
				Genres = genres,
				Actors = actors,
				Ratings = new List<RatingInfo> { ratingInfo }
			};
		}
	}
}
