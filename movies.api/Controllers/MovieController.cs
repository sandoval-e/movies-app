using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using movies.api.Models.DTOs.Movie;
using movies.api.Services.Interfaces;

namespace movies.api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MovieController : ControllerBase
	{
		private readonly IMovieService _service;

		public MovieController(IMovieService service)
		{
			_service = service;
		}

		[HttpGet("Catalog")]
		public async Task<IActionResult> GetMovieCatalog()
		{
			var result = await _service.GetMoviesCatalogWithMetadata();
			return Ok(result);
		}

		[HttpGet("Catalog/{id}")]
		public async Task<IActionResult> GetMovieData(int id)
		{
			MovieResponseDto? result = await _service.GetMovieWithMetadata(id);
			return result != null ? Ok(result) : NotFound();
		}
	}
}
