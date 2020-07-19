using MovieStore.Core.Entities;
using MovieStore.Core.RepositoryInterfaces;
using MovieStore.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        //constructor injection, inject movierepository class instance

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<Movie> CreateMovie(Movie movie)
        {
            return await _movieRepository.AddAsync(movie);
        }

        public async Task<IEnumerable<Movie>> Get25TopRatedMovies()
        {

            //select top 25 m.Id from Movie m left join Review r on m.Id = r.MovieId group by m.Id order by AVG(r.Rating) desc
            return await _movieRepository.GetTop25RatingsMovies();
        }

        public async Task<Movie> GetMovieById(int id)
        {
            return await _movieRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Movie>> GetMoviesByGenreId(int genreId)
        {
            return await _movieRepository.GetMoviesByGenreId(genreId);
        }

        public async Task<int> GetMoviesCount(string title = "")
        {
            return await _movieRepository.GetCountAsync(m=>m.Title==title);
        }

        public async Task<IEnumerable<Movie>> GetTop25HighestRevnueMovies()
        {
            return await _movieRepository.GetHighestRevenueMovies();
        }


        public async Task<Movie> UpdateMovie(Movie movie)
        {
            return await _movieRepository.UpdateAsync(movie);
        }
    }
    //public class MovieServiceTest : IMovieService
    //{
    //    public async Task<IEnumerable<Movie>> GetTop25HighestRevnueMovies()
    //    {
    //        var movies = new List<Movie>()
    //        {
    //            new Movie {Id = 1, Title = "Avengers: Infinity War", Budget = 1200000},
    //                        new Movie {Id = 2, Title = "Avatar", Budget = 1200000},
    //                        new Movie {Id = 3, Title = "Star Wars: The Force Awakens", Budget = 1200000},
    //                        new Movie {Id = 4, Title = "Titanic", Budget = 1200000},
    //        };

    //        return movies;
    //    }

    //    public Task<IEnumerable<Movie>> GetTopRatedMovies()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
