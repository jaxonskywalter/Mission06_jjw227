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

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    SubmissionId = 1,
                    Category = "Action",
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
                       Category = "Horror",
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
                          Category = "SciFi",
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
