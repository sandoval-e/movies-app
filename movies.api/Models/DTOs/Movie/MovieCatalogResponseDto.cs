﻿namespace movies.api.Models.DTOs.Movie
{
	public class MovieCatalogResponseDto
	{
		public int MovieId { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public string? PictureUrl { get; set; }
		public DateTime ReleaseDate { get; set; }
		public double AverageRating { get; set; }
		public List<string>? Genres { get; set; }
	}
}
