namespace movies.api.Models.DTOs.Movie
{
	public class MovieResponseDto
	{
		public int MovieId { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public string? PictureUrl { get; set; }
		public DateTime ReleaseDate {  get; set; }
		public List<string>? Genres { get; set; }
		public List<ActorInfo>? Actors { get; set; }
		public List<RatingInfo>? Ratings { get; set; }
	}

	public class ActorInfo
	{
		public string? ActorName { get; set; }
		public string? PictureUrl { get; set; }
	}

	public class RatingInfo
	{
		public double AverageRating { get; set; }
		public List<IndividualRating>? IndividualRatings { get; set; }
	}

	public class IndividualRating
	{
		public int Score { get; set; }
		public string? Comment { get; set; }
		public string? Username { get; set; }
	}
}
