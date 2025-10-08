using System.ComponentModel.DataAnnotations;

namespace movies.api.Models.DTOs.Genre
{
	public class GenreCreateDto
	{
		[Required]
		public required string Name { get; set; }
	}
}
