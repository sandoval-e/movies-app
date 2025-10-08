using System.ComponentModel.DataAnnotations;

namespace movies.api.Models.DTOs.Genre
{
	public class GenreUpdateDto
	{
		[Required]
		public int Id { get; set; }

		[Required]
		public required string Name { get; set; }
	}
}
