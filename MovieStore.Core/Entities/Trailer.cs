using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Core.Entities
{
    //one trailer belongs to single movie, but one movie can have multiple trailers
    public class Trailer
    {
        public int Id { get; set; }
        public string TrailerUrl { get; set; }
        public string Name { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
