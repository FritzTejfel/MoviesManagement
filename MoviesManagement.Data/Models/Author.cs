using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoviesManagement.Data.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        public DateTime BirthOfDate { get; set; }

        public List<Movie> Movies { get; set; }
    }
}