namespace movies.api.Models.Entities
{
	public class Rating
	{
		public int Id { get; set; }
		public int Score { get; set; }
		public string? Comment { get; set; }
		public int ActorId { get; set; }
		public int MovieId { get; set; }
		public User? User { get; set; }
		public Movie? Movie {  get; set; }
	}
}
