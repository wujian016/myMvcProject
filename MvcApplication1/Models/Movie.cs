using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcApplication1.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [Range(1, 100)]
        public decimal Price { get; set; }
        [StringLength(5)]
        public string Rating { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}