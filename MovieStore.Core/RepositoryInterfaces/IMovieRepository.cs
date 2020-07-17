using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.RepositoryInterfaces
{
    public interface IMovieRepository:IAsyncRepository<Movie>
    {
        Task<IEnumerable<Movie>> GetHighestRevenueMovies();
        Task<IEnumerable<Movie>> GetTop25RatingsMovies();

    }
    //IAsyncRepo has 8 methods
    //public class MovieRepo:EFRepository, IMovieRepository
    //(
    //  1+8 methods or 1 method (wheather we iheritit EFRepository)
    //)
}
