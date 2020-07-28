using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.Models.Response;
using MovieStore.Core.ServiceInterfaces;
using Newtonsoft.Json;

namespace MovieStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IUserService _userService;
        public MoviesController(IMovieService movieService,IUserService userService)
        {
            _movieService = movieService;
            _userService = userService;
        }
        //we want to construct a url for showing top 25 revenue movies
        //http:localhost/api/movies/toprevenue -- GET
        [HttpGet]
        [Route("toprevenue")]
        public async Task<IActionResult> GetTopRevenueMovies()
        {
            var movies = await _movieService.GetTop25HighestRevnueMovies();
            if (!movies.Any())
            {
                return NotFound("No Movies Found!");
            }

            return Ok(movies);
        }
        [HttpGet]
        [Route("toprated")]
        public async Task<IActionResult> GetTopRatedMovies()
        {
            var movies = await _movieService.Get25TopRatedMovies();
            if (!movies.Any())
            {
                return NotFound("No Movies Found!");
            }

            return Ok(movies);
        }

        [HttpGet]
        [Route("Genre/{genreId}")]
        public async Task<IActionResult> GetMoviesByGenre(int genreId)
        {
            var movies = await _movieService.GetMoviesByGenreId(genreId);
            return Ok(movies);
        }

        [HttpGet]
        [Route("Movie/{movieId}")]
        public async Task<IActionResult> Details(int movieId)
        {
            var movie = await _movieService.GetMovieById(movieId);
            MovieDetailsModel movieDetailsModel = new MovieDetailsModel();
            movieDetailsModel.Movie = movie;

            var userLoggedIn = HttpContext.User.Identity.IsAuthenticated;
            if (userLoggedIn)//user already logged in then check if the movie purchased
            {
                var userId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
                movieDetailsModel.CheckBought = await _userService.CheckBought(Convert.ToInt32(userId), movieId);
                movieDetailsModel.CheckFavorite = await _userService.CheckFavorite(Convert.ToInt32(userId), movieId);
            }
            else
            {
                movieDetailsModel.CheckBought = false;
                movieDetailsModel.CheckFavorite = false;
            }
           
            return Ok(movieDetailsModel);
        }


    }
}
