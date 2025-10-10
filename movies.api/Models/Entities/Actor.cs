namespace movies.api.Models.Entities
{
	public class Actor
	{
		public int Id { get; set; }
		public string? FullName { get; set; }
		public string? PictureUrl { get; set; }

		// Navigation property
		public ICollection<MovieActor>? MovieActors { get; set; }
	}
}
