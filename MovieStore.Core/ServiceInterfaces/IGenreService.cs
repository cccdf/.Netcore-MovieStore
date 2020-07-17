using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.ServiceInterfaces
{
    public interface IGenreService
    {
        public Task<IEnumerable<Genre>> GetAllGenres();
    }
}
