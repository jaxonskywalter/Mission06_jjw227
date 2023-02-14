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
    }
}
