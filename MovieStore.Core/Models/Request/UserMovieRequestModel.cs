using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Core.Models.Request
{
    public class UserMovieRequestModel
    {
        public int userId { get; set; }
        public int movieId { get; set; }
    }
}
