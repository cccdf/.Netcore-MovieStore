using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieStore.Core.ServiceInterfaces;
using MovieStore.MVC.Models;

namespace MovieStore.MVC.Controllers
{
    // GET http://localhost:3000/Homeindex
    //home controller
   //index --- action method
    public class HomeController : Controller
    {
        //Action method
        private readonly IMovieService _movieService;
        private readonly IGenreService _genreService;

        public HomeController(IMovieService movieService, IGenreService genreService)
        {
            _movieService = movieService;
            _genreService = genreService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //return an instance of a class that implements that interface
           var genres = await _genreService.GetAllGenres();
            var movies = await _movieService.GetTop25HighestRevnueMovies();
            return View(movies);
        }

        public async Task<IActionResult> Error()
        {
            return View(new ErrorViewModel {
                RequestId = Activity.Current ? .Id ?? HttpContext.TraceIdentifier
            }); ;
        }
    }
}
