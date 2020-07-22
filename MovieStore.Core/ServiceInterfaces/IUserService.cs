using MovieStore.Core.Entities;
using MovieStore.Core.Models.Request;
using MovieStore.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.ServiceInterfaces
{
    public interface IUserService
    {
        Task<UserRegisterResponseModel> RegisterUser(UserRegisterRequestModel registerRequestModel);
        Task<UserLoginResponseModel> ValidateUser(string email, string password);
        Task<bool> CheckBought(int userId, int movieId );
        Task<bool> CheckFavorite(int userId, int movieId);

        Task<Purchase> PurchaseMovie(int userId, int movieId);
        Task<ICollection<Movie>> MoviesPurchased(int userId);

        Task<ICollection<Review>> GetAllReviewsByUser(int userId);
        Task<Favorite> AddFavorite(int userId, int movieId);
        Task<bool> DeleteFavorite(int userId, int movieId);

        Task<Movie> CheckMovieFavoritedByUser(int userId, int movieId);
    }
}
