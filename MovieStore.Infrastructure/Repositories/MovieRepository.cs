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
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;

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


        public async Task<IEnumerable<Movie>> GetMoviesByGenreId(int genreID)
        {
            //select * from movie m join MovieGenre mg on m.Id=mg.MovieId where mg.GenreId=1
            
            var movies = await (from m in _dbContext.Movies
                               join mg in _dbContext.MovieGenres on m.Id equals mg.MovieId
                               where mg.GenreId == genreID
                               select m
                               )
                .ToListAsync();
            return movies;
        }

        public async Task<IEnumerable<Movie>> GetTop25RatingsMovies()
        {
            //select top 25 m.Id from Movie m left join Review r on m.Id = r.MovieId group by m.Id order by AVG(r.Rating) desc

            //var movies =
            //    from m in _dbContext.Movies
            //    join r in _dbContext.Reviews on m.Id equals r.MovieId

            //    group m by m.Id into mr
            //    //orderby mr.Key
            //    select new Movie
            //    {
            //        Id = mr.Key,
            //        Rating 

            //    };



            var movies = await _dbContext.Movies.OrderByDescending(m => m.Reviews.Average(r => r.Rating)).Select(m=>new Movie{ Id=m.Id, Rating = m.Reviews.Average(r=>r.Rating) }).Take(25).ToListAsync();
            return movies;
        }

        public override async Task<Movie> GetByIdAsync(int id)
        {
            var movie = await _dbContext.Movies.Where(m=>m.Id==id).FirstAsync();
            movie.Rating = await _dbContext.Reviews.Where(r => r.MovieId == id).AverageAsync(r => r.Rating);
            movie.MovieCasts = await _dbContext.MovieCasts.Include(mc=>mc.Cast).Where(mc => mc.MovieId == id).ToListAsync();
            movie.MovieGenres = await _dbContext.MovieGenres.Include(mg => mg.Genre).Where(mg => mg.MovieId == id).ToListAsync();
            return movie;
            
             
        }
    }
}
