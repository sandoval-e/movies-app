using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using movies.api.Models.DTOs.Genre;
using movies.api.Services.Implementations;
using movies.api.Services.Interfaces;

namespace movies.api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GenreController : ControllerBase
	{
		private readonly IGenreService _service;

		public GenreController(IGenreService genreService)
		{
			_service = genreService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllGenres()
		{
			var result = await _service.GetAllGenresAsync();
			return Ok(result);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetGenreById(int id)
		{
			var result = await _service.GetGenreByIdAsync(id);

			if(result == null) return NotFound();
			return Ok(result);
		}

		[HttpPost]
		public async Task<IActionResult> CreateGenre([FromBody] GenreCreateDto data)
		{
			await _service.AddGenreAsync(data);
			return Ok("Genre created successfully.");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateGenre(int id, [FromBody] GenreUpdateDto data)
		{
			if(data == null || data.Id != id) return BadRequest("Invalid request");

			await _service.UpdateGenreAsync(data);
			return Ok("Genre updated successfully.");
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteGenre(int id)
		{
			await _service.DeleteGenreAsync(id);
			return Ok("Genre deleted successfully.");
		}
	}
}
