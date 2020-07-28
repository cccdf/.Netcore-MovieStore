using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Core.Models.Request
{
    public class UserMakeReviewRequestModel
    {
        public int userId { get; set; }
        public int movieId { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
    }
}
