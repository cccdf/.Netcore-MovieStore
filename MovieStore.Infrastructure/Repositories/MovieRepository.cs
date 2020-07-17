using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MovieStore.Core.RepositoryInterfaces;
using System.Threading.Tasks;
using MovieStore.Infrastructure.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace MovieStore.Infrastructure.Repositories
{
    public class MovieRepository : EFRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieStoreDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<IEnumerable<Movie>> GetHighestRevenueMovies()
        {
            var movies = await _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(25).ToListAsync();
            return movies;
        }

        public async Task<IEnumerable<Movie>> GetTop25RatingsMovies()
        {
            //select top 25 m.Id from Movie m left join Review r on m.Id = r.MovieId group by m.Id order by AVG(r.Rating) desc

            var movies = await _dbContext.Movies.OrderByDescending(m => m.Reviews.Average(r=>r.Rating)).Take(25).ToListAsync();
            return movies;
        }
    }
}
