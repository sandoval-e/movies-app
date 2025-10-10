﻿namespace movies.api.Models.Entities
{
	public class User
	{
		public int Id {  get; set; }
		public string? UserName { get; set; }
		public string? Email { get; set; }
		public ICollection<Rating>? Ratings { get; set; }
	}
}
