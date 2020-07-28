using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using MovieStore.Core.Entities;
using MovieStore.Core.RepositoryInterfaces;
using MovieStore.Core.ServiceInterfaces;

namespace MovieStore.Infrastructure.Services
{
    public class GenreService:IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMemoryCache _memoryCache;
        private static readonly string _genresKey = "genres";
        private static readonly TimeSpan _defaultCacheDuration = TimeSpan.FromDays(30);

        public GenreService(IGenreRepository genreRepository, IMemoryCache memoryCache)
        {
            _genreRepository = genreRepository;
            _memoryCache = memoryCache;
        }

        public async Task<IEnumerable<Genre>> GetAllGenres()
        {
            //check if genre lists in cache by genreKey
            var genres = await _memoryCache.GetOrCreateAsync(_genresKey, async entry => {
                entry.SlidingExpiration = _defaultCacheDuration;
                return await _genreRepository.ListAllAsync();
            });
            return genres;
        }
    }
}
