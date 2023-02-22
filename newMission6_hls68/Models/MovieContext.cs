using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newMission6_hls68.Models
{
    public class MovieContext : DbContext
    {
        //constructor 
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            //leave blank for now 
        }
    public DbSet<ApplicationResponse> responses { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void  OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { categoryId=1, categoryName="Action"},
                new Category { categoryId=2, categoryName="Romance"},
                new Category { categoryId = 3, categoryName = "Anime" },
                new Category { categoryId = 4, categoryName = "Comedy" }

                );
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    movieId = 1,
                    categoryId = 3,
                    title = "Kiki's Delivery Service",
                    year = 1989,
                    director = " Hayao Miyazaki",
                    rating = "G",
                    edited = false,
                    lentTo = "Hannah",
                    notes = "This is a classic!"

                },
                new ApplicationResponse
                {
                movieId = 2,
                    categoryId = 3,
                    title = "Ponyo",
                    year = 2008,
                    director = " Hayao Miyazaki",
                    rating = "G",
                    edited = false,
                    lentTo = "Daniel",
                    notes = "Love this movie!"

                },
                new ApplicationResponse
                {
                    movieId = 3,
                    categoryId = 4,
                    title = "Brother Bear",
                    year = 2003,
                    director = "Aaron Blaise",
                    rating = "PG",
                    edited = false,
                    lentTo = "Ben",
                    notes = "This is my favorite!"

                }
                );
        }
    }

}
