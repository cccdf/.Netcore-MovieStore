using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Core.Models.Response
{
    public class MovieDetailsModel
    {
        public bool CheckBought { get; set; }
        public bool CheckFavorite { get; set; }
        public Movie Movie { get; set; }
        //public MovieDetailsModel(Movie movie)
        //{
        //    //var properties = typeof(Movie).GetProperties();
        //    //foreach (var property in properties)
        //    //{
        //    //    this.property.SetValue
        //    //}
        //    this.Id = movie.Id;
        //    this.Title = movie.Title;
        //    this.Tagline = movie.Tagline;
        //    this.Budget = movie.Budget;
        //    this.Revenue = movie.Revenue;
        //    this.ImdbUrl = movie.ImdbUrl;
        //    this.TmdbUrl = movie.TmdbUrl;
        //    this.PosterUrl = movie.PosterUrl;
        //    this.BackdropUrl = movie.BackdropUrl;
        //    this.OriginalLanguage = movie.OriginalLanguage;
        //    this.ReleaseDate = movie.ReleaseDate;
        //    this.RunTime = movie.RunTime;
        //    this.Price = movie.Price;
        //    this.Rating = movie.Rating;
        //    this.MovieGenres = movie.MovieGenres;
        //    this.MovieCasts = movie.MovieCasts;

        //}
    }
}
