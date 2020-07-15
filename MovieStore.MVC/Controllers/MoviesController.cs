using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieStore.MVC.Models;

namespace MovieStore.MVC.Controllers
{
    public class MoviesController : Controller
    {
        //GET localhost/Movies/index
        [HttpGet]
  
        public IActionResult Index()
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
            return View();
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
    }
}
