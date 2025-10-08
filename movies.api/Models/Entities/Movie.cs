namespace movies.api.Models.Entities
{
	public class Movie
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public string? PictureUrl { get; set; }
		public DateTime ReleaseDate { get; set; } = DateTime.UtcNow;

		// Navigation properties
		public ICollection<MovieActor>? MovieActors { get; set; }
		public ICollection<MovieGenre>? MovieGenres { get; set; }
		public ICollection<Rating>? MovieRatings { get; set; }
	}
}
