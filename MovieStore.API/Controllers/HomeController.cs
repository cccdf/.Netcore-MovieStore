using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.ServiceInterfaces;

namespace MovieStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IGenreService _genreService;

        public HomeController(IMovieService movieService, IGenreService genreService)
        {
            _movieService = movieService;
            _genreService = genreService;
        }

        [HttpGet]
        [Route("allgenres")]
        public async Task<IActionResult> GetAllGenrens()
        {
            var genres = await _genreService.GetAllGenres();
            return Ok(genres);
        }
    }
}
