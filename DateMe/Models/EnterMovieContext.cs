using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Models
{
    public class EnterMovieContext : DbContext
    {
        //Contructor
        public EnterMovieContext (DbContextOptions<EnterMovieContext> options) : base (options)
        {

        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //gives each category of movie an assigned id
            mb.Entity<Category>().HasData(
                    new Category { CategoryId = 1, CategoryName = "Action/Adventure" },
                    new Category { CategoryId = 2, CategoryName = "Comedy" },
                    new Category { CategoryId = 3, CategoryName = "Drama" },
                    new Category { CategoryId = 4, CategoryName = "Family" },
                    new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                    new Category { CategoryId = 6, CategoryName = "Miscellaneous" }
            );

            //seeds the database with base entries
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    SubmissionId = 1,
                    CategoryId = 1,
                    Title = "Inception",
                    Year = 2010,
                    Director = "Christofer Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Favorite movie ever!"
                },
                   new ApplicationResponse
                   {
                       SubmissionId = 2,
                       CategoryId = 5,
                       Title = "The Menu",
                       Year = 2022,
                       Director = "Mark Mylod",
                       Rating = "R",
                       Edited = false,
                       LentTo = "",
                       Notes = "Best movie recently."
                   },
                      new ApplicationResponse
                      {
                          SubmissionId = 3,
                          CategoryId = 1,
                          Title = "Rogue One",
                          Year = 2016,
                          Director = "Gareth Edwards",
                          Rating = "PG-13",
                          Edited = true,
                          LentTo = "",
                          Notes = "Best Star Wars movie."
                      }
            );
        }
    }
}
