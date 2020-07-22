using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.Entities;
using MovieStore.Core.ServiceInterfaces;
using MovieStore.Core.Models;
using MovieStore.MVC.Models;
using MovieStore.Core.Models.Response;
using System.Security.Claims;

namespace MovieStore.MVC.Controllers
{
    public class MoviesController : Controller
    {
        //ioc .net core has built in ioc/di,we need to rely on third-party ioc to do dependency injection, Autofac, Ninject
        private readonly IMovieService _movieService;
        private readonly IGenreService _genreService;
        private readonly IUserService _userService;
        public MoviesController(IMovieService movieService, IGenreService genreService,IUserService userService)
        {
            _movieService = movieService;
            _genreService = genreService;
            _userService = userService;
        }
        //GET localhost/Movies/index
        [HttpGet]

        public async Task<IActionResult> Index()
        {
            //goto database and get some list of movies and give it to the view
            //var movies = new List<Movie> {
            //    new Movie {Id = 1, Title = "Avengers: Infinity War", Budget = 1200000},
            //    new Movie {Id = 2, Title = "Avatar", Budget = 1200000},
            //    new Movie {Id = 3, Title = "Star Wars: The Force Awakens", Budget = 1200000},
            //    new Movie {Id = 4, Title = "Titanic", Budget = 1200000},
            //    new Movie {Id = 5, Title = "Inception", Budget = 1200000},
            //    new Movie {Id = 6, Title = "Avengers: Age of Ultron", Budget = 1200000},
            //    new Movie {Id = 7, Title = "Interstellar", Budget = 1200000},
            //    new Movie {Id = 8, Title = "Fight Club", Budget = 1200000},
            //};
            //ViewBag.MoviesCount = movies.Count;
            //we need to pass data from controller action method to the view
            //usually its prefer to send a strongly typed model or object


            //var movieService = new MovieService();
            //var movies = await  movieService.GetAllMovie();

            //call movie service method, highest grossing method

            //var movies = await _movieService.GetTop25HighestRevnueMovies();
            var movies = await _movieService.Get25TopRatedMovies();
            //var movies = await _movieService.GetMovieById(1);
            //var movies = await _movieService.GetMoviesCount("Iron Man");
            //var movies = await _movieService.CreateMovie(new Movie() { Title = "test" });
            //var movies = await _movieService.UpdateMovie(new Movie() { Id = 201, Title = "testupdate" });
            //var genres = await _genreService.GetAllGenres();
            return View(movies);
        }
        [HttpPost]
        public IActionResult Create(string title, decimal budget)
        {
            //we need to get the data from the view and save it in database
            // POST http://localhost/movies/create
            return View();

        }
        [HttpGet]
        public IActionResult Create()
        {
            //we need to have this method so that we can show the empty page for user to enter information
            // GET http://localhost/movies/create
            return View();
        }

        [HttpGet("/Genre/{genreId}")]
        public async Task<IActionResult> GetMoviesByGenre(int genreId)
        {
            var movies = await _movieService.GetMoviesByGenreId(genreId);
            return View(movies);
        }

        [HttpGet("/Movie/{movieId}")]
        public async Task<IActionResult> Details(int movieId)
        {
            var movie = await _movieService.GetMovieById(movieId);
            MovieDetailsModel movieDetailsModel = new MovieDetailsModel();
            movieDetailsModel.Movie = movie;

            var userLoggedIn = HttpContext.User.Identity.IsAuthenticated;
            if(userLoggedIn)//user already logged in then check if the movie purchased
            {
                var userId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
                movieDetailsModel.CheckBought = await _userService.CheckBought(Convert.ToInt32(userId), movieId);
            }
            else
            {
                movieDetailsModel.CheckBought = false;
            }
            return View(movieDetailsModel);
        }


    }
}
