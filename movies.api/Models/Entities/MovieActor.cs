﻿namespace movies.api.Models.Entities
{
	public class MovieActor
	{
		public int MovieId { get; set; }
		public int ActorId { get; set; }
		public Movie? Movie { get; set; }
		public Actor? Actor { get; set; }
	}
}
