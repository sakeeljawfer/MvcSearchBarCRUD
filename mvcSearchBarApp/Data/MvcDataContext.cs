using System;
using Microsoft.EntityFrameworkCore;
using mvcSearchBarApp.Models;

namespace mvcSearchBarApp.Data
{
    public class MvcDataContext : DbContext
    {
        public MvcDataContext(DbContextOptions<MvcDataContext> options)
             : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
