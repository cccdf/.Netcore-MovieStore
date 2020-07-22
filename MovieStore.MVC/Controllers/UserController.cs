using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.Entities;
using MovieStore.Core.Models.Response;
using MovieStore.Core.ServiceInterfaces;

namespace MovieStore.MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMovieService _movieService;
        public UserController(IUserService userService, IMovieService movieService)
        {
            _userService = userService;
            _movieService = movieService;
        }
        [HttpPost("/User/Purchase/{movieId}")]

        public async Task<IActionResult> Purchase(int movieId)
        {
            //check if logged user already bought this movie
            var userId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c=>c.Type==ClaimTypes.NameIdentifier).Value);
            var checkBought = await _userService.CheckBought(userId, movieId);
            var movie = await _movieService.GetMovieById(movieId);
            if (checkBought == false)//which means user did not buy this movie then store info to database
            {
                var userPurchased = await _userService.PurchaseMovie(userId, movieId);
                return LocalRedirect("/user/purchases");
            }
            else//which means user already bought this movie, then change buy button
            {
                var movieDetails = new MovieDetailsModel();
                movieDetails.Movie = movie;
                movieDetails.CheckBought = checkBought;
                return View("/Views/Movies/Details.cshtml", movieDetails);
            }
            
           
        }
        [HttpGet("/user/purchases")]
        public async Task<IActionResult> MoviesPurchasedByUser()
        {
            var userId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            var moviesPurchased = await _userService.MoviesPurchased(userId);

            return View(moviesPurchased);

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
