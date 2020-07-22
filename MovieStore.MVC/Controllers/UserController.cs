using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.Entities;
using MovieStore.Core.Models.Request;
using MovieStore.Core.Models.Response;
using MovieStore.Core.ServiceInterfaces;

namespace MovieStore.MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMovieService _movieService;
        private readonly IReviewService _reviewService;
        private readonly IFavoriteService _favoriteService;
        public UserController(IUserService userService, IMovieService movieService, IReviewService reviewService, IFavoriteService favoriteService)
        {
            _userService = userService;
            _movieService = movieService;
            _reviewService = reviewService;
            _favoriteService = favoriteService;
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
        [HttpGet("/User/Review/{movieId}")]
        public ActionResult Review(int movieId)
        {

            return View(movieId);
        }
        [HttpPost("/User/Review/{movieId:int}")]
        public async Task<IActionResult> Review(string ReviewText, string Rating, int movieId)
        {
            var userId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            int rating = Convert.ToInt32(Rating);
            var review = new Review
            {
                MovieId = movieId,
                ReviewText = ReviewText,
                UserId = userId,
                Rating = (decimal)rating
            };
            await _reviewService.AddReview(review);
            
            return LocalRedirect("/User/Review");
        }

        [HttpGet("/User/Review")]
        public async Task<IActionResult> GetAllReviewsByUser()
        {
            var userId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            var reviews = await _userService.GetAllReviewsByUser(userId);

            return View("AllReviewsFromTheUser",reviews);

        }

        [HttpPost("/User/Favorite/{movieId}")]
        public async Task<IActionResult> AddFavoriteForUser(int movieId)
        {
            var userId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            await _userService.AddFavorite(userId, movieId);

            var checkBought = await _userService.CheckBought(userId, movieId);
            var movieDetails = new MovieDetailsModel();
            var movie = await _movieService.GetMovieById(movieId);
            movieDetails.Movie = movie;
            movieDetails.CheckFavorite = true;

            return View("/Views/Movies/Details.cshtml",movieDetails);
        }

        [HttpGet("/User/{userId}/Movie/{movieId}/Favorite")]

        public async Task<IActionResult> UserMovieFavorite(int userId, int movieId)
        {
            var movie = await _userService.CheckMovieFavoritedByUser(userId, movieId); 
            if(movie != null)//means this movie is this user favorite
            {

            }
            else
            {

            }
            return null;
        }
        [HttpDelete("/User/Favorite/{movieId}")]

        public async Task<IActionResult> DeleteFavoriteForUser(int movieId)
        {
            var userId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);

           var deleted =  await _userService.DeleteFavorite(userId,movieId);

            var checkBought = await _userService.CheckBought(userId, movieId);
            var movieDetails = new MovieDetailsModel();
            var movie = await _movieService.GetMovieById(movieId);
            movieDetails.Movie = movie;
            var movie1 = await _userService.CheckMovieFavoritedByUser(userId, movieId);
            if(movie1 != null)//this movie is still user favorite
            {
                movieDetails.CheckFavorite = true;
            }
            else
            {
                movieDetails.CheckFavorite = false;
            }

            return View("/Views/Movies/Details.cshtml", movieDetails);


        }
    }
}
