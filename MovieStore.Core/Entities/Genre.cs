using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieStore.Core.Entities
{
    //genre class represent our domain model, we are gonna have all the properties of Genre Columns
    [Table("Genre")]
    public class Genre
    {
        //by default ef is gonna consider any property in the entity class as Primary key for Id property
        public int Id { get; set; }
        [MaxLength(64)]
        [Required]
        public string Name { get; set; }

        public ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
