using Microsoft.EntityFrameworkCore;
using MvcMovie.models;

namespace MvcMovie.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
        public DbSet<Person> Person{get; set;}
    }
}