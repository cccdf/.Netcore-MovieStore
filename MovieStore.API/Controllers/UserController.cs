using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.Entities;
using MovieStore.Core.Models.Request;
using MovieStore.Core.ServiceInterfaces;

namespace MovieStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
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
        [HttpPost]
        [Route("purchase")]
        public async Task<IActionResult> Purchase([FromBody] UserMovieRequestModel purchaseRequest)
        {
            //check if logged user already bought this movie

            var checkBought = await _userService.CheckBought(purchaseRequest.userId, purchaseRequest.movieId);

            if (checkBought == false)//which means user did not buy this movie then store info to database
            {
                var userPurchased = await _userService.PurchaseMovie(purchaseRequest.userId, purchaseRequest.movieId);
                return Ok(userPurchased);
            }
            else//which means user already bought this movie, then change buy button
            {
                return BadRequest("User already bought this movie");
            }


        }
        [HttpGet]
        [Route("purchased")]
        public async Task<IActionResult> MoviesPurchasedByUser([FromBody] UserMovieRequestModel purchaseRequest)
        {
            var moviesPurchased = await _userService.MoviesPurchased(purchaseRequest.userId);
            return Ok(moviesPurchased);
        }
        [HttpGet]
        [Route("review")]
        public async Task<IActionResult> GetAllReviewsByUser([FromBody] UserMovieRequestModel Request)
        {
            var reviews = await _userService.GetAllReviewsByUser(Request.userId);
            return Ok(reviews);
        }
        [HttpPost]
        [Route("review")]
        public async Task<IActionResult> UserMakeReview([FromBody] UserMakeReviewRequestModel userMakeReviewRequest)
        {
            var review = new Review
            {
                MovieId = userMakeReviewRequest.movieId,
                ReviewText = userMakeReviewRequest.ReviewText,
                UserId = userMakeReviewRequest.userId,
                Rating = (decimal)userMakeReviewRequest.Rating
            };
            var reviewAdded = await _reviewService.AddReview(review);
            return Ok(reviewAdded);
        }
        [HttpPost]
        [Route("addfavorite")]
        public async Task<IActionResult> AddFavoriteForUser([FromBody] UserMovieRequestModel Request)
        {
            var favoriteAdded = await _userService.AddFavorite(Request.userId, Request.movieId);
            return Ok(favoriteAdded);
           
        }

        [HttpPost]
        [Route("checkfavorite")]
        public async Task<IActionResult> CheckFavorite([FromBody] UserMovieRequestModel Request)
        {
            var movie = await _userService.CheckMovieFavoritedByUser(Request.userId, Request.movieId);
            return Ok(movie);
        }
        [HttpPost]
        [Route("deletefavorite")]
        public async Task<IActionResult> DeleteFavoriteForUser([FromBody] UserMovieRequestModel Request)
        {

            var deleted = await _userService.DeleteFavorite(Request.userId, Request.movieId);

            return Ok(deleted);


        }
    }
}
