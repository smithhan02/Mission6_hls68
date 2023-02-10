using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newMission6_hls68.Models
{
    public class DateApplicationContext : DbContext
    {
        //constructor 
        public DateApplicationContext (DbContextOptions<DateApplicationContext> options) : base (options)
        {
            //leave blank for now 
        }
    public DbSet<ApplicationResponse> responses { get; set; }

    protected override void  OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    movieId = 1,
                    category = "Anime",
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
                    category = "Anime",
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
                    category = "Disney",
                    title = "Brother Bear",
                    year = 2003,
                    director = "AAron Blaise",
                    rating = "PG",
                    edited = false,
                    lentTo = "Ben",
                    notes = "This is my favorite!"

                }
                );
        }
    }

}
