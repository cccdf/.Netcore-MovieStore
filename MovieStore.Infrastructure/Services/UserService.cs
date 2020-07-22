using MovieStore.Core.Entities;
using MovieStore.Core.Models.Request;
using MovieStore.Core.Models.Response;
using MovieStore.Core.RepositoryInterfaces;
using MovieStore.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Infrastructure.Services
{
    public class UserService : IUserService

    {
        private readonly IUserRepository _userRepository;
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly ICryptoService _cryptoService;
        private readonly IMovieRepository _movieRepository;
        public UserService(IUserRepository userRepository, ICryptoService cryptoService, IPurchaseRepository purchaseRepository, IMovieRepository movieRepository)
        {
            _userRepository = userRepository;
            _cryptoService = cryptoService;
            _purchaseRepository = purchaseRepository;
            _movieRepository = movieRepository;
        }

        public async Task<bool> CheckBought(int userId, int movieId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            foreach (var purchase in user.Purchases)
            {
                if(purchase.MovieId == movieId)
                {
                    return true;
                }
            }
            return false;

        }

        public async Task<ICollection<Movie>> MoviesPurchased(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            var purchases = await _purchaseRepository.GetPurchasesByUserId(userId);
            List<Movie> movies = new List<Movie>();
            foreach (var purchase in purchases)
            {
                movies.Add(purchase.Movie);
            }

            return movies;

        }

        public async Task<Purchase> PurchaseMovie(int userId, int movieId)
        {
            var movie = await _movieRepository.GetByIdAsync(movieId);
            var user = await _userRepository.GetByIdAsync(userId);
            var userPurchase = new Purchase
            {
                UserId = userId,
                MovieId = movieId,
                TotalPrice = (decimal)movie.Price,
                PurchaseNumber = Guid.NewGuid(),
                PurchaseDateTime = DateTime.UtcNow,
                Customer = user,
                Movie=movie

            };
            return await _purchaseRepository.AddAsync(userPurchase);
        }

        public async Task<UserRegisterResponseModel> RegisterUser(UserRegisterRequestModel registerRequestModel)
        {
            //step 1: check whether this user already exists in the database.
            var dbUser = await _userRepository.GetUserByEmail(registerRequestModel.Email);
            if(dbUser != null)
            {
                //we already have this user in our database
                //return or throw an exception saying conflict user
                throw new Exception("User already registered, Please try to Login");
            }
            //step 2: lets create a random unique salt
            //never ever create your own Hashing Algorithm, always use Industry tested/tried Hashing Algorithm
            string salt = _cryptoService.GenerateSalt();

            //step 3: we hash the password with the salt created in the last step
            string hashedPassword = _cryptoService.HashPassword(registerRequestModel.Password, salt);
            //create user object so that we can save it to user table
            var user = new User
            {
                Email = registerRequestModel.Email,
                Salt = salt,
                HashedPassword = hashedPassword,
                FirstName = registerRequestModel.FirstName,
                LastName = registerRequestModel.LastName
            };
            var createdUser = await _userRepository.AddAsync(user);

            var response = new UserRegisterResponseModel
            {
                Id = createdUser.Id,
                Email = createdUser.Email,
                Firstname = createdUser.FirstName,
                LastName = createdUser.LastName
            };

            return response;

        }

        public async Task<UserLoginResponseModel> ValidateUser(string email, string password)
        {
            //step 1: get user in database
            var dbUser = await _userRepository.GetUserByEmail(email);

            if(dbUser == null)
            {
                //user does not exists
                throw new Exception("Register first, user does not exists");
            }

            //step 2: hash the password that user entered in th page with salt from the database

            var salt = dbUser.Salt;
            var hashedPassword = _cryptoService.HashPassword(password, salt);

            //step3: if equals login successfully

            if(dbUser.HashedPassword == hashedPassword)
            {
                //user enter right password
                //send some user details
                var response = new UserLoginResponseModel
                {
                    Id = dbUser.Id,
                    Email = dbUser.Email,
                    FirstName = dbUser.FirstName,
                    LastName = dbUser.LastName,
                    DateOfBirth = dbUser.DateOfBirth,
                    
                };
                return response;
            }
            return null;
        }
    }
}
